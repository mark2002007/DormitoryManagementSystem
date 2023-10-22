using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DormitoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class _20231022082200_Mics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Faculty_AssignedFacultyFacultyID",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Room_AssignedRoomRoomID",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Faculty_AssignedFacultyFacultyID",
                table: "Room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Room",
                table: "Room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Faculty",
                table: "Faculty");

            migrationBuilder.RenameTable(
                name: "Room",
                newName: "Rooms");

            migrationBuilder.RenameTable(
                name: "Faculty",
                newName: "Faculties");

            migrationBuilder.RenameIndex(
                name: "IX_Room_AssignedFacultyFacultyID",
                table: "Rooms",
                newName: "IX_Rooms_AssignedFacultyFacultyID");

            migrationBuilder.AddColumn<int>(
                name: "DormitoryID",
                table: "Rooms",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "RoomID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faculties",
                table: "Faculties",
                column: "FacultyID");

            migrationBuilder.CreateTable(
                name: "Dormitories",
                columns: table => new
                {
                    DormitoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DormitoryNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dormitories", x => x.DormitoryID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_DormitoryID",
                table: "Rooms",
                column: "DormitoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Faculties_AssignedFacultyFacultyID",
                table: "Residents",
                column: "AssignedFacultyFacultyID",
                principalTable: "Faculties",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Rooms_AssignedRoomRoomID",
                table: "Residents",
                column: "AssignedRoomRoomID",
                principalTable: "Rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Dormitories_DormitoryID",
                table: "Rooms",
                column: "DormitoryID",
                principalTable: "Dormitories",
                principalColumn: "DormitoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Faculties_AssignedFacultyFacultyID",
                table: "Rooms",
                column: "AssignedFacultyFacultyID",
                principalTable: "Faculties",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Faculties_AssignedFacultyFacultyID",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Rooms_AssignedRoomRoomID",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Dormitories_DormitoryID",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Faculties_AssignedFacultyFacultyID",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "Dormitories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_DormitoryID",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Faculties",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "DormitoryID",
                table: "Rooms");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "Room");

            migrationBuilder.RenameTable(
                name: "Faculties",
                newName: "Faculty");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_AssignedFacultyFacultyID",
                table: "Room",
                newName: "IX_Room_AssignedFacultyFacultyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Room",
                table: "Room",
                column: "RoomID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faculty",
                table: "Faculty",
                column: "FacultyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Faculty_AssignedFacultyFacultyID",
                table: "Residents",
                column: "AssignedFacultyFacultyID",
                principalTable: "Faculty",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Room_AssignedRoomRoomID",
                table: "Residents",
                column: "AssignedRoomRoomID",
                principalTable: "Room",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Faculty_AssignedFacultyFacultyID",
                table: "Room",
                column: "AssignedFacultyFacultyID",
                principalTable: "Faculty",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
