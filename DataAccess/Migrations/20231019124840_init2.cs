using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarImages_CarImageId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Colors_ColorId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Rentals_RentalId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Customers_CustormerId",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Customers_CustomerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CustomerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_CustormerId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Cars_BrandId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CarImageId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ColorId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_RentalId",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RentDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 19, 15, 48, 40, 602, DateTimeKind.Local).AddTicks(8260), new DateTime(2023, 10, 19, 15, 48, 40, 602, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RentDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 19, 15, 48, 40, 602, DateTimeKind.Local).AddTicks(8272), new DateTime(2023, 10, 19, 15, 48, 40, 602, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RentDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 19, 15, 48, 40, 602, DateTimeKind.Local).AddTicks(8274), new DateTime(2023, 10, 19, 15, 48, 40, 602, DateTimeKind.Local).AddTicks(8274) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RentDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 19, 15, 29, 4, 596, DateTimeKind.Local).AddTicks(4362), new DateTime(2023, 10, 19, 15, 29, 4, 596, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RentDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 19, 15, 29, 4, 596, DateTimeKind.Local).AddTicks(4374), new DateTime(2023, 10, 19, 15, 29, 4, 596, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RentDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 19, 15, 29, 4, 596, DateTimeKind.Local).AddTicks(4376), new DateTime(2023, 10, 19, 15, 29, 4, 596, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CustomerId",
                table: "Users",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CustormerId",
                table: "Rentals",
                column: "CustormerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarImageId",
                table: "Cars",
                column: "CarImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_RentalId",
                table: "Cars",
                column: "RentalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarImages_CarImageId",
                table: "Cars",
                column: "CarImageId",
                principalTable: "CarImages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Colors_ColorId",
                table: "Cars",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Rentals_RentalId",
                table: "Cars",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Customers_CustormerId",
                table: "Rentals",
                column: "CustormerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Customers_CustomerId",
                table: "Users",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
