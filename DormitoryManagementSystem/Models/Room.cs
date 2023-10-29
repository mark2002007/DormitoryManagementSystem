using DormitoryManagementSystem.Enums;

namespace DormitoryManagementSystem.Models;

public class Room
{
    public int RoomID { get; set; }
    public required string RoomNumber { get; set; }
    public required Dormitory AssignedDormitory { get; set; }
    public Faculty? AssignedFaculty { get; set; }
    public required int Capacity { get; set; }
    public ICollection<Resident> Residents { get; set; } = new List<Resident>();
    public int CurrentOccupancy => Residents?.Count ?? 0;
    public Gender? Gender => Residents?.FirstOrDefault()?.Gender;
}