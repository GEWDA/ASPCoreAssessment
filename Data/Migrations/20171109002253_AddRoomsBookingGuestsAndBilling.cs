using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASPCoreAssessment.Data.Migrations
{
    public partial class AddRoomsBookingGuestsAndBilling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "BLOB", nullable: false),
                    NumberDoubleBeds = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberExtraBeds = table.Column<int>(type: "INTEGER", nullable: true),
                    NumberSingleBeds = table.Column<int>(type: "INTEGER", nullable: false),
                    PriceDouble = table.Column<double>(type: "REAL", nullable: false),
                    PricePerExtra = table.Column<double>(type: "REAL", nullable: false),
                    PriceSingle = table.Column<double>(type: "REAL", nullable: false),
                    RoomNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "BLOB", nullable: false),
                    BookingFrom = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    BookingTo = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    HotelRoomId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomCost = table.Column<double>(type: "REAL", nullable: false),
                    RoomId = table.Column<Guid>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "BLOB", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    BookingDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    BookingId = table.Column<Guid>(type: "BLOB", nullable: true),
                    CheckIn = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CheckOut = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    HotelBookingId = table.Column<int>(type: "INTEGER", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    NumberOfGuests = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomBooked = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guests_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Billing",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "BLOB", nullable: false),
                    BarCharge = table.Column<double>(type: "REAL", nullable: true),
                    GuestId = table.Column<Guid>(type: "BLOB", nullable: true),
                    HotelGuestId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomCharge = table.Column<double>(type: "REAL", nullable: false),
                    TelephoneCharge = table.Column<double>(type: "REAL", nullable: true),
                    WiFiCharge = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Billing_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Billing_GuestId",
                table: "Billing",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RoomId",
                table: "Booking",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_BookingId",
                table: "Guests",
                column: "BookingId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //    table: "AspNetUserTokens",
            //    column: "UserId",
            //    principalTable: "AspNetUsers",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //    table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Billing");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
