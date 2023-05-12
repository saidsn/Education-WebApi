using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class addDescColumntoAbouttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 594, DateTimeKind.Local).AddTicks(6661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 885, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 594, DateTimeKind.Local).AddTicks(6412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 885, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 593, DateTimeKind.Local).AddTicks(8433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 884, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 593, DateTimeKind.Local).AddTicks(8140),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 884, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 595, DateTimeKind.Local).AddTicks(3997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 886, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 595, DateTimeKind.Local).AddTicks(3797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 886, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 596, DateTimeKind.Local).AddTicks(2863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 887, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 596, DateTimeKind.Local).AddTicks(2653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 887, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "About",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 594, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 885, DateTimeKind.Local).AddTicks(6123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 594, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 884, DateTimeKind.Local).AddTicks(9640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 593, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 884, DateTimeKind.Local).AddTicks(9407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 593, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 886, DateTimeKind.Local).AddTicks(3998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 595, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 886, DateTimeKind.Local).AddTicks(3755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 595, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 887, DateTimeKind.Local).AddTicks(1635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 596, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 20, 19, 21, 887, DateTimeKind.Local).AddTicks(1432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 20, 21, 34, 596, DateTimeKind.Local).AddTicks(2653));
        }
    }
}
