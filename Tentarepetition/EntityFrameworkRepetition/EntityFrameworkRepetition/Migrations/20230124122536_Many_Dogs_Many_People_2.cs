using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkRepetition.Migrations
{
    /// <inheritdoc />
    public partial class ManyDogsManyPeople2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_People_PersonId",
                table: "Pet");

            migrationBuilder.DropIndex(
                name: "IX_Pet_PersonId",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Pet");

            migrationBuilder.CreateTable(
                name: "PersonPet",
                columns: table => new
                {
                    OwnersId = table.Column<int>(type: "int", nullable: false),
                    PetsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPet", x => new { x.OwnersId, x.PetsId });
                    table.ForeignKey(
                        name: "FK_PersonPet_People_OwnersId",
                        column: x => x.OwnersId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonPet_Pet_PetsId",
                        column: x => x.PetsId,
                        principalTable: "Pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonPet_PetsId",
                table: "PersonPet",
                column: "PetsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonPet");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Pet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pet_PersonId",
                table: "Pet",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_People_PersonId",
                table: "Pet",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }
    }
}
