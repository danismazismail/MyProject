using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Context.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 120, nullable: false, defaultValue: 0),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Address", "Age", "CreatedDate", "DateOfBirth", "DeletedDate", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "123 Main St", 30, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9709), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "john.doe@example.com", "John", "Male", "Doe", "123-456-7890", 1, null },
                    { 2, "124 Main St", 28, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9727), new DateTime(1995, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jane.doe@example.com", "Jane", "Female", "Doe", "123-456-7891", 1, null },
                    { 3, "125 Main St", 35, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9729), new DateTime(1988, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "alice.smith@example.com", "Alice", "Female", "Smith", "123-456-7892", 1, null },
                    { 4, "126 Main St", 40, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9733), new DateTime(1983, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "bob.smith@example.com", "Bob", "Male", "Smith", "123-456-7893", 1, null },
                    { 5, "127 Main St", 25, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9735), new DateTime(1998, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "charlie.brown@example.com", "Charlie", "Male", "Brown", "123-456-7894", 1, null },
                    { 6, "128 Main St", 45, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9736), new DateTime(1978, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "david.johnson@example.com", "David", "Male", "Johnson", "123-456-7895", 1, null },
                    { 7, "129 Main St", 32, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9738), new DateTime(1991, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "eva.johnson@example.com", "Eva", "Female", "Johnson", "123-456-7896", 1, null },
                    { 8, "130 Main St", 50, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9740), new DateTime(1973, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "frank.miller@example.com", "Frank", "Male", "Miller", "123-456-7897", 1, null },
                    { 9, "131 Main St", 37, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9742), new DateTime(1986, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "grace.miller@example.com", "Grace", "Female", "Miller", "123-456-7898", 1, null },
                    { 10, "132 Main St", 55, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9749), new DateTime(1968, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "henry.adams@example.com", "Henry", "Male", "Adams", "123-456-7899", 1, null },
                    { 11, "133 Main St", 27, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9751), new DateTime(1996, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "isabella.adams@example.com", "Isabella", "Female", "Adams", "123-456-7900", 1, null },
                    { 12, "134 Main St", 38, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9753), new DateTime(1985, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jack.wilson@example.com", "Jack", "Male", "Wilson", "123-456-7901", 1, null },
                    { 13, "135 Main St", 42, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9755), new DateTime(1981, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "karen.wilson@example.com", "Karen", "Female", "Wilson", "123-456-7902", 1, null },
                    { 14, "136 Main St", 33, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9756), new DateTime(1990, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "larry.martinez@example.com", "Larry", "Male", "Martinez", "123-456-7903", 1, null },
                    { 15, "137 Main St", 29, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9758), new DateTime(1994, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "megan.martinez@example.com", "Megan", "Female", "Martinez", "123-456-7904", 1, null },
                    { 16, "138 Main St", 46, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9760), new DateTime(1977, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "nancy.garcia@example.com", "Nancy", "Female", "Garcia", "123-456-7905", 1, null },
                    { 17, "139 Main St", 52, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9762), new DateTime(1971, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "oscar.garcia@example.com", "Oscar", "Male", "Garcia", "123-456-7906", 1, null },
                    { 18, "140 Main St", 31, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9763), new DateTime(1992, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "patricia.rodriguez@example.com", "Patricia", "Female", "Rodriguez", "123-456-7907", 1, null },
                    { 19, "141 Main St", 27, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9765), new DateTime(1996, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "quentin.clark@example.com", "Quentin", "Male", "Clark", "123-456-7908", 1, null },
                    { 20, "142 Main St", 35, new DateTime(2024, 7, 8, 16, 11, 44, 756, DateTimeKind.Local).AddTicks(9767), new DateTime(1988, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "rachel.clark@example.com", "Rachel", "Female", "Clark", "123-456-7909", 1, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
