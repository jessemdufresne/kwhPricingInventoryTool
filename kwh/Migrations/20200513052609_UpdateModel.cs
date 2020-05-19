using Microsoft.EntityFrameworkCore.Migrations;

namespace kwh.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Component",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40) CHARACTER SET utf8mb4",
                oldMaxLength: 40,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Component",
                type: "varchar(40) CHARACTER SET utf8mb4",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
