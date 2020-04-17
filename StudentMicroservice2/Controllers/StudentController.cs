using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentMicroservice2.Models;
using StudentMicroservice2.Repository;
using System.Transactions;
using StudentMicroservice2.IntergrationEvents.Events;
using StudentMicroservice2.Service;
using System.Diagnostics;

namespace StudentMicroservice2.DbContexts
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentRepository _studentRepository;
        private readonly ISimpleEventBusService _simpleEventBusService;
        public StudentController(IStudentRepository studentRepository, ISimpleEventBusService simpleEventBusService)
        {
            _studentRepository = studentRepository;
            _simpleEventBusService = simpleEventBusService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var students = _studentRepository.GetStudents();
            return new OkObjectResult(students);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var student = _studentRepository.GetStudentByID(id);
            return new OkObjectResult(student);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            using (var scope = new TransactionScope())
            {
                _studentRepository.InsertStudent(student);
                scope.Complete();
                StudentCreatedIntegratedEvent studentCreatedIntegratedEvent = new StudentCreatedIntegratedEvent(student.Id, student.Name);
                _simpleEventBusService.Publish(studentCreatedIntegratedEvent);
                Debug.WriteLine("Publish to eventbus");
                return CreatedAtAction(nameof(Get), new { id = student.Id }, student);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Student student)
        {
            if (student != null)
            {
                using (var scope = new TransactionScope())
                {
                    _studentRepository.UpdateStudent(student);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _studentRepository.DeleteStudent(id);
            return new OkResult();
        }
    }
}
