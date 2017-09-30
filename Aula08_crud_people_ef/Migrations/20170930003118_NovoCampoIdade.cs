using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace crud_people.Migrations
{
    public partial class NovoCampoIdade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "People");
        }
    }
}
