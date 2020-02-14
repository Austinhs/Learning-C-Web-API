using Microsoft.EntityFrameworkCore.Migrations;

namespace Vavous.API.Migrations
{
    public partial class add_annotation_company : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companys",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companys",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
