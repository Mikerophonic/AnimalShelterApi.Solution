using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class SeedMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                columns: new[] { "Age", "Name", "Species" },
                values: new object[] { 2, "Luna", "Cat" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Age", "Name", "Species" },
                values: new object[] { 3, "Rocky", "Dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Age", "Name", "Species" },
                values: new object[] { 1, "Sparkle", "Rabbit" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Age", "Name", "Species" },
                values: new object[] { 5, "Ziggy", "Parrot" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                columns: new[] { "Age", "Name" },
                values: new object[] { 1, "Whiskers" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Name", "Species" },
                values: new object[,]
                {
                    { 6, 4, "Shadow", "Snake" },
                    { 7, 2, "Mochi", "Guinea Pig" },
                    { 8, 2, "Tinker", "Ferret" },
                    { 9, 1, "Nala", "Fish" },
                    { 10, 1, "Blizzard", "Hedgehog" },
                    { 11, 2, "Milo", "Dog" },
                    { 12, 1, "Daisy", "Dog" },
                    { 13, 3, "Simba", "Cat" },
                    { 14, 4, "Cooper", "Dog" },
                    { 15, 2, "Lily", "Cat" },
                    { 16, 3, "Riley", "Dog" },
                    { 17, 1, "Sasha", "Cat" },
                    { 18, 2, "Teddy", "Dog" },
                    { 19, 4, "Cleo", "Cat" },
                    { 20, 1, "Bentley", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                columns: new[] { "Age", "Name", "Species" },
                values: new object[] { 7, "Matilda", "Dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Age", "Name", "Species" },
                values: new object[] { 10, "Rexie", "Cat" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Age", "Name", "Species" },
                values: new object[] { 2, "Matilda", "Dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Age", "Name", "Species" },
                values: new object[] { 4, "Pip", "Cat" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                columns: new[] { "Age", "Name" },
                values: new object[] { 22, "Bartholomew" });
        }
    }
}
