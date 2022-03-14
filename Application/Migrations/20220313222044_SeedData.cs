using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("ea5028d1-3bdb-41b2-9141-fc6329d89a8b"), "Canal dedidaco a dot net", "DotNetCore" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("da2109e3-df69-4bd3-9b1f-eab157f77052"), "Canal dedidaco a Minecraft", "Minecraft" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("14cf2484-45c3-4981-8144-b400e31b377d"), "Canal dedidaco a React Js", "React Js" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("14cf2484-45c3-4981-8144-b400e31b377d"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("da2109e3-df69-4bd3-9b1f-eab157f77052"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("ea5028d1-3bdb-41b2-9141-fc6329d89a8b"));
        }
    }
}
