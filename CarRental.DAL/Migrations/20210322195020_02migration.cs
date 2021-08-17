using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.DAL.Migrations
{
    public partial class _02migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Cars",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 1, 1 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 22, 22, 50, 17, 732, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 2, 2 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 22, 22, 50, 17, 733, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 3, 3 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 22, 22, 50, 17, 733, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 4, 4 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 22, 22, 50, 17, 733, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 5, 5 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 22, 22, 50, 17, 733, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 6, 5 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 22, 22, 50, 17, 733, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 7, 5 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 22, 22, 50, 17, 733, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 8, 6 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 22, 22, 50, 17, 733, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 9, 6 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 22, 22, 50, 17, 733, DateTimeKind.Local).AddTicks(2994));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 1, 1 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 10, 16, 15, 58, 245, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 2, 2 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 10, 16, 15, 58, 246, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 3, 3 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 10, 16, 15, 58, 246, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 4, 4 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 10, 16, 15, 58, 246, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 5, 5 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 10, 16, 15, 58, 246, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 6, 5 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 10, 16, 15, 58, 246, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 7, 5 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 10, 16, 15, 58, 246, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 8, 6 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 10, 16, 15, 58, 246, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "ReservationDetails",
                keyColumns: new[] { "CarID", "ReservationID" },
                keyValues: new object[] { 9, 6 },
                column: "DeliveryDate",
                value: new DateTime(2021, 3, 10, 16, 15, 58, 246, DateTimeKind.Local).AddTicks(3842));
        }
    }
}
