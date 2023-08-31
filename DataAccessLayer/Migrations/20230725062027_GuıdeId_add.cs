﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class GuıdeId_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Guides",
                table: "Guides");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Guides",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "GuideID",
                table: "Guides",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guides",
                table: "Guides",
                column: "GuideID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Guides",
                table: "Guides");

            migrationBuilder.DropColumn(
                name: "GuideID",
                table: "Guides");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Guides",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guides",
                table: "Guides",
                column: "Name");
        }
    }
}
