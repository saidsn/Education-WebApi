using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class CreateServiceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(1330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 773, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(1190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 773, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 442, DateTimeKind.Local).AddTicks(6871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 772, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 442, DateTimeKind.Local).AddTicks(6680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 772, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(7041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 774, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(6832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 774, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 445, DateTimeKind.Local).AddTicks(4272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 775, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 445, DateTimeKind.Local).AddTicks(3954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 775, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 444, DateTimeKind.Local).AddTicks(5011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 774, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 444, DateTimeKind.Local).AddTicks(4850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 774, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 446, DateTimeKind.Local).AddTicks(3313)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 446, DateTimeKind.Local).AddTicks(3508))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 773, DateTimeKind.Local).AddTicks(4031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 773, DateTimeKind.Local).AddTicks(3816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 772, DateTimeKind.Local).AddTicks(7475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 442, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 772, DateTimeKind.Local).AddTicks(7204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 442, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 774, DateTimeKind.Local).AddTicks(1458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 774, DateTimeKind.Local).AddTicks(1198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 775, DateTimeKind.Local).AddTicks(6951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 445, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 775, DateTimeKind.Local).AddTicks(6685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 445, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 774, DateTimeKind.Local).AddTicks(9705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 444, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 11, 40, 12, 774, DateTimeKind.Local).AddTicks(9452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 444, DateTimeKind.Local).AddTicks(4850));
        }
    }
}
