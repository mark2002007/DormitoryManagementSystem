using DormitoryManagementSystem.Enums;

namespace DormitoryManagementSystem.Models;

public class Dean : User
{
    public int DeanID { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required Gender Gender { get; set; }
    public required string ContactNumber { get; set; }
    public required Faculty? Faculty { get; set; }
    public required int FacultyId { get; set; }
}