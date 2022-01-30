using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    AppointID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Appointment_Status = table.Column<int>(type: "int", nullable: false),
                    BillAmount = table.Column<float>(type: "real", nullable: false),
                    BillStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorNotification = table.Column<int>(type: "int", nullable: false),
                    PatientNotification = table.Column<int>(type: "int", nullable: false),
                    FeedbackStatus = table.Column<int>(type: "int", nullable: false),
                    Disease = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Progress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.AppointID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");
        }
    }
}
