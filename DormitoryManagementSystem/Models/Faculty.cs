namespace DormitoryManagementSystem.Models;

public class Faculty
{
    public int FacultyID { get; set; }
    public required string FacultyName { get; set; }
    public ICollection<Room> AssignedRooms { get; set; } = new List<Room>();
}