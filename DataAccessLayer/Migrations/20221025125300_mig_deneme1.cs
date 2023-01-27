using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_deneme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoList",
                table: "ToDoList");

            migrationBuilder.RenameTable(
                name: "ToDoList",
                newName: "ToDoLists");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoLists",
                table: "ToDoLists",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Test1s",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test1s", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Test1s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoLists",
                table: "ToDoLists");

            migrationBuilder.RenameTable(
                name: "ToDoLists",
                newName: "ToDoList");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoList",
                table: "ToDoList",
                column: "ID");
        }
    }
}
