using Microsoft.EntityFrameworkCore.Migrations;

namespace CardsAPI.Migrations
{
    public partial class No_lvl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Cards",
                maxLength: 1500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1500)",
                oldMaxLength: 1500);

            migrationBuilder.AlterColumn<string>(
                name: "Level",
                table: "Cards",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Cards",
                type: "nvarchar(1500)",
                maxLength: 1500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Level",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
