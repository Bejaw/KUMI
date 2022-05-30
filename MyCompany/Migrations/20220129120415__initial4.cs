using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class _initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"));

            migrationBuilder.CreateTable(
                name: "ProtocolsItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TitleImagesPath = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Subtitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    DocPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtocolsItems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "5b7edd31-950d-44a4-bed0-5d91ecafa4f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80467c3c-151b-4321-bbf3-86fae130669c", "AQAAAAEAACcQAAAAEPro558DctsAoqFsl2b8PCfs9Gu/uET/uPR1DBVXs0CKD2+SCioJCodpXb0RmJAMvA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("0643705b-db8f-43a3-98de-359df2f5b6f7"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 29, 12, 4, 15, 29, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("0bc287e6-f3a3-4444-88cf-94cc5049c275"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 29, 12, 4, 15, 29, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("15a11537-7471-48df-86db-4fec77f492c4"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 29, 12, 4, 15, 29, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 29, 12, 4, 15, 29, DateTimeKind.Utc).AddTicks(5216));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProtocolsItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "6e25627b-419d-497c-b777-5f81712c70a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c39c8dfa-134b-49e1-83d7-710366910b5c", "AQAAAAEAACcQAAAAEP7jhnnqQqJtH0wOcFguFiLX6USMsdrMbj2aN2eVEaChE4E3ClOOHPR5swwTZ9cf8A==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("0643705b-db8f-43a3-98de-359df2f5b6f7"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 29, 10, 9, 57, 449, DateTimeKind.Utc).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("0bc287e6-f3a3-4444-88cf-94cc5049c275"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 29, 10, 9, 57, 449, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("15a11537-7471-48df-86db-4fec77f492c4"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 29, 10, 9, 57, 449, DateTimeKind.Utc).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 1, 29, 10, 9, 57, 449, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagesPath" },
                values: new object[] { new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"), "PageMessages", new DateTime(2022, 1, 29, 10, 9, 57, 449, DateTimeKind.Utc).AddTicks(2265), null, null, null, null, "Содержание заполняется администратором", "Информационные сообщения", null });
        }
    }
}
