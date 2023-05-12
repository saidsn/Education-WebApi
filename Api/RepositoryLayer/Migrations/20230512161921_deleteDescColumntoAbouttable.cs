using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class deleteDescColumntoAbouttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "About");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 885, DateTimeKind.Local).AddTicks(6404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 301, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 885, DateTimeKind.Local).AddTicks(6123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 301, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 884, DateTimeKind.Local).AddTicks(9640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 300, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 884, DateTimeKind.Local).AddTicks(9407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 300, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 886, DateTimeKind.Local).AddTicks(3998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 302, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 886, DateTimeKind.Local).AddTicks(3755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 302, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 887, DateTimeKind.Local).AddTicks(1635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 303, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 887, DateTimeKind.Local).AddTicks(1432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 303, DateTimeKind.Local).AddTicks(7264));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 301, DateTimeKind.Local).AddTicks(1972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 885, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 301, DateTimeKind.Local).AddTicks(1489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 885, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 300, DateTimeKind.Local).AddTicks(844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 884, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 300, DateTimeKind.Local).AddTicks(528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 884, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 302, DateTimeKind.Local).AddTicks(5687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 886, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 302, DateTimeKind.Local).AddTicks(5416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 886, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 303, DateTimeKind.Local).AddTicks(7601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 887, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 18, 14, 8, 303, DateTimeKind.Local).AddTicks(7264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 887, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "About",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }
    }
}
