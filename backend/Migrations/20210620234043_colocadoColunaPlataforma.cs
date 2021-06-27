using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class colocadoColunaPlataforma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Resume",
                table: "pages",
                newName: "Platforms");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "Registered",
                value: new DateTime(2021, 6, 20, 20, 40, 42, 688, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 2L,
                column: "Registered",
                value: new DateTime(2021, 6, 20, 20, 40, 42, 689, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 3L,
                column: "Registered",
                value: new DateTime(2021, 6, 20, 20, 40, 42, 689, DateTimeKind.Local).AddTicks(890));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Platforms",
                table: "pages",
                newName: "Resume");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "Registered",
                value: new DateTime(2021, 6, 20, 18, 53, 47, 673, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 2L,
                column: "Registered",
                value: new DateTime(2021, 6, 20, 18, 53, 47, 673, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 3L,
                column: "Registered",
                value: new DateTime(2021, 6, 20, 18, 53, 47, 673, DateTimeKind.Local).AddTicks(7851));
        }
    }
}
