using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetPals.Data.Migrations
{
    public partial class CustomerSitterUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           // migrationBuilder.DropColumn(
                //name: "Price",
                //table: "Sitter");

            //migrationBuilder.AddColumn<int>(
                //name: "CustomerID",
                //table: "Pet",
                ///nullable: false,
                //defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ServiceType = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: true),
                    SitterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceID);
                    table.ForeignKey(
                        name: "FK_Service_Sitter_SitterID",
                        column: x => x.SitterID,
                        principalTable: "Sitter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

           // migrationBuilder.CreateIndex(
             //   name: "IX_Pet_CustomerID",
             //   table: "Pet",
              //  column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_SitterID",
                table: "Service",
                column: "SitterID");

            //migrationBuilder.AddForeignKey(
           //     name: "FK_Pet_Customer_CustomerID",
            //    table: "Pet",
            //    column: "CustomerID",
            //    principalTable: "Customer",
             //   principalColumn: "ID",
             //   onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           // migrationBuilder.DropForeignKey(
             //   name: "FK_Pet_Customer_CustomerID",
              //  table: "Pet");

            migrationBuilder.DropTable(
                name: "Service");

           // migrationBuilder.DropIndex(
             //   name: "IX_Pet_CustomerID",
             //   table: "Pet");

           // migrationBuilder.DropColumn(
            //    name: "CustomerID",
             //   table: "Pet");

            //migrationBuilder.AddColumn<decimal>(
              //  name: "Price",
                //table: "Sitter",
                //type: "money",
                //nullable: false,
                //defaultValue: 0m);
        }
    }
}
