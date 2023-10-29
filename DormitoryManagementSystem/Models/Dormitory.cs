namespace DormitoryManagementSystem.Models;

public class Dormitory
{
    public int DormitoryID { get; set; }
    public required int DormitoryNumber { get; set; }
    public required string Location { get; set; }
    public int TotalRooms
    {
        get { return Rooms?.Count ?? 0; }
    }
    public ICollection<Room> Rooms { get; set; } = new List<Room>();
}