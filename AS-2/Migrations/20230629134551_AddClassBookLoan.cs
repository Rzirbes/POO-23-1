using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AS_2.Migrations
{
    /// <inheritdoc />
    public partial class AddClassBookLoan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookLoanId",
                table: "DbSetBook",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DbSetBookLoan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsReturned = table.Column<bool>(type: "INTEGER", nullable: false),
                    FineAmount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbSetBookLoan", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DbSetBook_BookLoanId",
                table: "DbSetBook",
                column: "BookLoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetBook_DbSetBookLoan_BookLoanId",
                table: "DbSetBook",
                column: "BookLoanId",
                principalTable: "DbSetBookLoan",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbSetBook_DbSetBookLoan_BookLoanId",
                table: "DbSetBook");

            migrationBuilder.DropTable(
                name: "DbSetBookLoan");

            migrationBuilder.DropIndex(
                name: "IX_DbSetBook_BookLoanId",
                table: "DbSetBook");

            migrationBuilder.DropColumn(
                name: "BookLoanId",
                table: "DbSetBook");
        }
    }
}
