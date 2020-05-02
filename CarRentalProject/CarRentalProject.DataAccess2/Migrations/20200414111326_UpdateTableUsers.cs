using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalProject.DataAccess2.Migrations
{
    public partial class UpdateTableUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Booking_BookingId",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_BookingId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Car");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "User",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CarsId",
                table: "Booking",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Admin",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CarsId",
                table: "Booking",
                column: "CarsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Car_CarsId",
                table: "Booking",
                column: "CarsId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Car_CarsId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_CarsId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CarsId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Admin");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BookingId",
                table: "Car",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Car_BookingId",
                table: "Car",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Booking_BookingId",
                table: "Car",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
