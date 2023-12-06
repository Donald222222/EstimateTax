using Microsoft.EntityFrameworkCore.Migrations;

namespace EstimateTax.Migrations
{
    public partial class Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Progressive");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxInfo",
                table: "TaxInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlatValue",
                table: "FlatValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlatRate",
                table: "FlatRate");

            migrationBuilder.DropColumn(
                name: "FixRate_Per_Income",
                table: "FlatValue");

            migrationBuilder.RenameTable(
                name: "TaxInfo",
                newName: "TaxInfos");

            migrationBuilder.RenameTable(
                name: "FlatValue",
                newName: "FlatValues");

            migrationBuilder.RenameTable(
                name: "FlatRate",
                newName: "FlatRates");

            migrationBuilder.RenameColumn(
                name: "Flatrate_Per_Income",
                table: "FlatRates",
                newName: "FlatRate_Per_Income");

            migrationBuilder.AlterColumn<double>(
                name: "FlatValue_Per_Income",
                table: "FlatValues",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "Fix_Flatate_per_Income",
                table: "FlatValues",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "FlatRate_Per_Income",
                table: "FlatRates",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxInfos",
                table: "TaxInfos",
                column: "TaxId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlatValues",
                table: "FlatValues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlatRates",
                table: "FlatRates",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Progressives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    From = table.Column<double>(type: "float", nullable: false),
                    To = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progressives", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Progressives");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxInfos",
                table: "TaxInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlatValues",
                table: "FlatValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlatRates",
                table: "FlatRates");

            migrationBuilder.DropColumn(
                name: "Fix_Flatate_per_Income",
                table: "FlatValues");

            migrationBuilder.RenameTable(
                name: "TaxInfos",
                newName: "TaxInfo");

            migrationBuilder.RenameTable(
                name: "FlatValues",
                newName: "FlatValue");

            migrationBuilder.RenameTable(
                name: "FlatRates",
                newName: "FlatRate");

            migrationBuilder.RenameColumn(
                name: "FlatRate_Per_Income",
                table: "FlatRate",
                newName: "Flatrate_Per_Income");

            migrationBuilder.AlterColumn<int>(
                name: "FlatValue_Per_Income",
                table: "FlatValue",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "FixRate_Per_Income",
                table: "FlatValue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Flatrate_Per_Income",
                table: "FlatRate",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxInfo",
                table: "TaxInfo",
                column: "TaxId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlatValue",
                table: "FlatValue",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlatRate",
                table: "FlatRate",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Progressive",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    To = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progressive", x => x.Id);
                });
        }
    }
}
