using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManagment.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgeCustomer = table.Column<int>(type: "int", nullable: false),
                    CustomerStatusId = table.Column<int>(type: "int", nullable: false),
                    NIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    REGON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActiv = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
