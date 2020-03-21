using Microsoft.EntityFrameworkCore.Migrations;

namespace CardsAPI.Migrations
{
    public partial class Redo_str : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Setcode",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Race",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Ot",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Level",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Def",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Attribute",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Atk",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Alias",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Type",
                table: "Cards",
                type: "float",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<double>(
                name: "Setcode",
                table: "Cards",
                type: "float",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<double>(
                name: "Race",
                table: "Cards",
                type: "float",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<double>(
                name: "Ot",
                table: "Cards",
                type: "float",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<double>(
                name: "Level",
                table: "Cards",
                type: "float",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<double>(
                name: "Def",
                table: "Cards",
                type: "float",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<double>(
                name: "Category",
                table: "Cards",
                type: "float",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<double>(
                name: "Attribute",
                table: "Cards",
                type: "float",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<double>(
                name: "Atk",
                table: "Cards",
                type: "float",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<double>(
                name: "Alias",
                table: "Cards",
                type: "float",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
