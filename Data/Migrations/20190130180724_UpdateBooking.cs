using Microsoft.EntityFrameworkCore.Migrations;

namespace PetPals.Data.Migrations
{
    public partial class UpdateBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Booking_Service_ServiceID",
            //    table: "Booking");

            //migrationBuilder.DropIndex(
            //    name: "IX_Booking_ServiceID",
            //    table: "Booking");

            //migrationBuilder.DropColumn(
            //    name: "ServiceID",
            //    table: "Booking");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Booking",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Service",
                table: "Booking",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Booking",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Service",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Booking");

            //migrationBuilder.AddColumn<int>(
            //    name: "ServiceID",
            //    table: "Booking",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Booking_ServiceID",
            //    table: "Booking",
            //    column: "ServiceID");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Booking_Service_ServiceID",
            //    table: "Booking",
            //    column: "ServiceID",
            //    principalTable: "Service",
            //    principalColumn: "ServiceID",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
