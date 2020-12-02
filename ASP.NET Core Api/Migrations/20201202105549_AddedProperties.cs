using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Api.Migrations
{
    public partial class AddedProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "User",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 12, 2, 12, 54, 9, 452, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LogDate",
                table: "Logs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 12, 2, 12, 54, 9, 438, DateTimeKind.Local).AddTicks(8895));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "User",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2020, 12, 2, 12, 54, 9, 452, DateTimeKind.Local).AddTicks(6307),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LogDate",
                table: "Logs",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2020, 12, 2, 12, 54, 9, 438, DateTimeKind.Local).AddTicks(8895),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
