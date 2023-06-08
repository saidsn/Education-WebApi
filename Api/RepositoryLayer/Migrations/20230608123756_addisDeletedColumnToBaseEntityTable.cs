using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class addisDeletedColumnToBaseEntityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Title",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Student",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Slider",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Service",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "CourseAuthor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Course",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Contact",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Banner",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Author",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "About",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Title");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "CourseAuthor");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Banner");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "About");
        }
    }
}
