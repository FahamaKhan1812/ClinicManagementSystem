using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS.Migrations
{
    public partial class Doctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    DoctorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorAge = table.Column<int>(type: "int", nullable: false),
                    DoctorGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorPhone = table.Column<string>(type: "char(10)", nullable: true),
                    Qualification = table.Column<string>(type: "varchar(50)", nullable: true),
                    Specialization = table.Column<string>(type: "varchar(50)", nullable: true),
                    Charges = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.DoctorID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor");
        }
    }
}
