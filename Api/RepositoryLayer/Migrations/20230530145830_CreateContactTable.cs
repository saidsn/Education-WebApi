using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class CreateContactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 923, DateTimeKind.Local).AddTicks(5236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 923, DateTimeKind.Local).AddTicks(4482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 921, DateTimeKind.Local).AddTicks(5435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 442, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 921, DateTimeKind.Local).AddTicks(4680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 442, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 933, DateTimeKind.Local).AddTicks(4809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 446, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 933, DateTimeKind.Local).AddTicks(4031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 446, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 925, DateTimeKind.Local).AddTicks(8200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 925, DateTimeKind.Local).AddTicks(7552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 931, DateTimeKind.Local).AddTicks(1835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 445, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 931, DateTimeKind.Local).AddTicks(1127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 445, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 928, DateTimeKind.Local).AddTicks(3522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 444, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 928, DateTimeKind.Local).AddTicks(1971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 444, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 935, DateTimeKind.Local).AddTicks(4489)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 935, DateTimeKind.Local).AddTicks(5234))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(1330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 923, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(1190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 923, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 442, DateTimeKind.Local).AddTicks(6871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 921, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 442, DateTimeKind.Local).AddTicks(6680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 921, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 446, DateTimeKind.Local).AddTicks(3508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 933, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 446, DateTimeKind.Local).AddTicks(3313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 933, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(7041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 925, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 443, DateTimeKind.Local).AddTicks(6832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 925, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 445, DateTimeKind.Local).AddTicks(4272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 931, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 445, DateTimeKind.Local).AddTicks(3954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 931, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 444, DateTimeKind.Local).AddTicks(5011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 928, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 15, 48, 52, 444, DateTimeKind.Local).AddTicks(4850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 18, 58, 29, 928, DateTimeKind.Local).AddTicks(1971));
        }
    }
}
