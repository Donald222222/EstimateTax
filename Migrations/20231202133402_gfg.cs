using Microsoft.EntityFrameworkCore.Migrations;

namespace EstimateTax.Migrations
{
    public partial class gfg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlatRate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flatrate_Per_Income = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlatRate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlatValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlatValue_Per_Income = table.Column<int>(type: "int", nullable: false),
                    FixRate_Per_Income = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlatValue", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlatRate");

            migrationBuilder.DropTable(
                name: "FlatValue");
        }
    }
}
