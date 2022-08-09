using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webAPI.Infra.Data.Migrations
{
    public partial class intialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "buildings",
                columns: table => new
                {
                    BuildingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Safe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buildings", x => x.BuildingID);
                });

            migrationBuilder.CreateTable(
                name: "flats",
                columns: table => new
                {
                    FlatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingID = table.Column<int>(type: "int", nullable: false),
                    Safe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flats", x => x.FlatID);
                    table.ForeignKey(
                        name: "FK_flats_buildings_BuildingID",
                        column: x => x.BuildingID,
                        principalTable: "buildings",
                        principalColumn: "BuildingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "debts",
                columns: table => new
                {
                    DebtID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlatID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    IsDue = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debts", x => x.DebtID);
                    table.ForeignKey(
                        name: "FK_debts_flats_FlatID",
                        column: x => x.FlatID,
                        principalTable: "flats",
                        principalColumn: "FlatID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transactions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dept_or_Payment = table.Column<bool>(type: "bit", nullable: false),
                    FlatID = table.Column<int>(type: "int", nullable: true),
                    DebtID = table.Column<int>(type: "int", nullable: true),
                    BuildingID = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_transactions_buildings_BuildingID",
                        column: x => x.BuildingID,
                        principalTable: "buildings",
                        principalColumn: "BuildingID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_transactions_debts_DebtID",
                        column: x => x.DebtID,
                        principalTable: "debts",
                        principalColumn: "DebtID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactions_flats_FlatID",
                        column: x => x.FlatID,
                        principalTable: "flats",
                        principalColumn: "FlatID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_debts_FlatID",
                table: "debts",
                column: "FlatID");

            migrationBuilder.CreateIndex(
                name: "IX_flats_BuildingID",
                table: "flats",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_BuildingID",
                table: "transactions",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_DebtID",
                table: "transactions",
                column: "DebtID");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_FlatID",
                table: "transactions",
                column: "FlatID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transactions");

            migrationBuilder.DropTable(
                name: "debts");

            migrationBuilder.DropTable(
                name: "flats");

            migrationBuilder.DropTable(
                name: "buildings");
        }
    }
}
