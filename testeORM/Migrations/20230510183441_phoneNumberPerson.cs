using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testeORM.Migrations
{
    /// <inheritdoc />
    public partial class phoneNumberPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "phoneNumber",
                table: "Pessoas",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phoneNumber",
                table: "Pessoas");
        }
    }
}
