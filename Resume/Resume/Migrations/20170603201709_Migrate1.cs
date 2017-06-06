using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Resume.Migrations
{
    public partial class Migrate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ResumeMain",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MyName",
                table: "ResumeMain",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Objective",
                table: "ResumeMain",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "ResumeMain",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "ResumeMain",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "ResumeMain");

            migrationBuilder.DropColumn(
                name: "MyName",
                table: "ResumeMain");

            migrationBuilder.DropColumn(
                name: "Objective",
                table: "ResumeMain");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "ResumeMain");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "ResumeMain");
        }
    }
}
