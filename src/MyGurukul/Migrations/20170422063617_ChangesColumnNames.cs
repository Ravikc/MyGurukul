using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGurukul.Migrations
{
    public partial class ChangesColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Student_StudentID",
                table: "Attendance");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Attendance",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Student_StudentID",
                table: "Attendance",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameColumn(
                name: "profilePicture",
                table: "AspNetUsers",
                newName: "ProfilePicture");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Student_StudentID",
                table: "Attendance");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Attendance",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Student_StudentID",
                table: "Attendance",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "AspNetUsers",
                newName: "profilePicture");
        }
    }
}
