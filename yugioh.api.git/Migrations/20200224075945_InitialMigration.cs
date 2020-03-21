using Microsoft.EntityFrameworkCore.Migrations;

namespace CardsAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 400, nullable: false),
                    Text = table.Column<string>(maxLength: 1500, nullable: false),
                    Ot = table.Column<int>(nullable: false),
                    Alias = table.Column<long>(nullable: false),
                    Setcode = table.Column<long>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Atk = table.Column<int>(nullable: false),
                    Def = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Race = table.Column<int>(nullable: false),
                    Attribute = table.Column<int>(nullable: false),
                    Category = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
