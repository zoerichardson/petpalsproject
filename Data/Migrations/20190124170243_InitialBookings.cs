using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetPals.Data.Migrations
{
    public partial class InitialBookings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TotalCost = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                   // ServiceID = table.Column<int>(nullable: false),
                    SitterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Booking_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    //table.ForeignKey(
                    //    name: "FK_Booking_Service_ServiceID",
                    //    column: x => x.ServiceID,
                    //    principalTable: "Service",
                    //    principalColumn: "ServiceID",
                    //    onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Sitter_SitterID",
                        column: x => x.SitterID,
                        principalTable: "Sitter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CustomerID",
                table: "Booking",
                column: "CustomerID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Booking_ServiceID",
            //    table: "Booking",
            //    column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_SitterID",
                table: "Booking",
                column: "SitterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");
        }
    }
}
