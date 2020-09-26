using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Data.Migrations
{
    public partial class PasswordField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 26, 8, 22, 47, 961, DateTimeKind.Local).AddTicks(3033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 27, 18, 52, 38, 325, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                nullable: false,
                defaultValue: "TesteTemplate");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7dce21b-d207-4869-bf5f-08eb138bb919"),
                column: "DateCreated",
                value: new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 27, 18, 52, 38, 325, DateTimeKind.Local).AddTicks(9630),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 9, 26, 8, 22, 47, 961, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7dce21b-d207-4869-bf5f-08eb138bb919"),
                column: "DateCreated",
                value: new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
