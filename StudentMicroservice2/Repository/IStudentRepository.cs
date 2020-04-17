using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentMicroservice2.Models;

namespace StudentMicroservice2.Repository
{
   public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByID(int StudentId);
        void InsertStudent(Student Student);
        void DeleteStudent(int StudentId);
        void UpdateStudent(Student Student);
        void Save();
    }
}
