using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheNicestWebApp.Data.Migrations
{
    public partial class addNewTitleDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Persons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Persons");
        }
    }
}
