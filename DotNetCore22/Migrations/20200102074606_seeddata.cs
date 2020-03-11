using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCore22.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "id", "Name", "Salary" },
                values: new object[] { 101, "Neeraj Chouhan", 30000 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "id", "Name", "Salary" },
                values: new object[] { 201, "Ratnesh kushwaha", 5000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(nullable: false),
                    fname = table.Column<string>(nullable: false),
                    gender = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    uname = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });
        }
    }
}
