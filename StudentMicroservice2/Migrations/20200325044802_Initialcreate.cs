using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentMicroservice2.Migrations
{
    public partial class Initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ccas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ccas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CcaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ccas",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Div A and Div B Football team", "Football" });

            migrationBuilder.InsertData(
                table: "Ccas",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Sing", "Choir" });

            migrationBuilder.InsertData(
                table: "Ccas",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Draw", "Art Class" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ccas");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
