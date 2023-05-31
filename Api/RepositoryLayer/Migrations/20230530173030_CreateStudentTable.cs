using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class CreateStudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 915, DateTimeKind.Local).AddTicks(4279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 401, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 915, DateTimeKind.Local).AddTicks(4129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 401, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 914, DateTimeKind.Local).AddTicks(9653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 400, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 914, DateTimeKind.Local).AddTicks(9451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 400, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 917, DateTimeKind.Local).AddTicks(6678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 406, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 917, DateTimeKind.Local).AddTicks(6535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 406, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 915, DateTimeKind.Local).AddTicks(9665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 402, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 915, DateTimeKind.Local).AddTicks(9494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 402, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(6149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 416, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(5977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 416, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(4616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 416, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(4460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 416, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 918, DateTimeKind.Local).AddTicks(2482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 407, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 918, DateTimeKind.Local).AddTicks(2337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 407, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 917, DateTimeKind.Local).AddTicks(868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 404, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 917, DateTimeKind.Local).AddTicks(723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 404, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(5411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 416, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(5238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 416, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 916, DateTimeKind.Local).AddTicks(5648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 403, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 916, DateTimeKind.Local).AddTicks(5500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 403, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Info = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsGraduated = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(6957)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(7109))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_CourseId",
                table: "Student",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 401, DateTimeKind.Local).AddTicks(5742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 915, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 401, DateTimeKind.Local).AddTicks(5492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 915, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 400, DateTimeKind.Local).AddTicks(8298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 914, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 400, DateTimeKind.Local).AddTicks(8042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 914, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 406, DateTimeKind.Local).AddTicks(1615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 917, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 406, DateTimeKind.Local).AddTicks(1339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 917, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 402, DateTimeKind.Local).AddTicks(6011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 915, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 402, DateTimeKind.Local).AddTicks(5760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 915, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 416, DateTimeKind.Local).AddTicks(7720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 416, DateTimeKind.Local).AddTicks(7013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 416, DateTimeKind.Local).AddTicks(3453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 416, DateTimeKind.Local).AddTicks(3181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 407, DateTimeKind.Local).AddTicks(1500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 918, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 407, DateTimeKind.Local).AddTicks(1218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 918, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 404, DateTimeKind.Local).AddTicks(7285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 917, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 404, DateTimeKind.Local).AddTicks(6806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 917, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 416, DateTimeKind.Local).AddTicks(5208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 416, DateTimeKind.Local).AddTicks(4952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 923, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 403, DateTimeKind.Local).AddTicks(4504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 916, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 30, 20, 27, 21, 403, DateTimeKind.Local).AddTicks(4253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 30, 21, 30, 29, 916, DateTimeKind.Local).AddTicks(5500));
        }
    }
}
