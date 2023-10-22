using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DormitoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class _20231022123100_Misc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Rooms_AssignedRoomRoomID",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Faculties_AssignedFacultyFacultyID",
                table: "Rooms");

            migrationBuilder.AlterColumn<int>(
                name: "AssignedFacultyFacultyID",
                table: "Rooms",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "AssignedRoomRoomID",
                table: "Residents",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Rooms_AssignedRoomRoomID",
                table: "Residents",
                column: "AssignedRoomRoomID",
                principalTable: "Rooms",
                principalColumn: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Faculties_AssignedFacultyFacultyID",
                table: "Rooms",
                column: "AssignedFacultyFacultyID",
                principalTable: "Faculties",
                principalColumn: "FacultyID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Rooms_AssignedRoomRoomID",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Faculties_AssignedFacultyFacultyID",
                table: "Rooms");

            migrationBuilder.AlterColumn<int>(
                name: "AssignedFacultyFacultyID",
                table: "Rooms",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssignedRoomRoomID",
                table: "Residents",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Rooms_AssignedRoomRoomID",
                table: "Residents",
                column: "AssignedRoomRoomID",
                principalTable: "Rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Faculties_AssignedFacultyFacultyID",
                table: "Rooms",
                column: "AssignedFacultyFacultyID",
                principalTable: "Faculties",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
