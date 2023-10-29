using DormitoryManagementSystem.Enums;

namespace DormitoryManagementSystem.Models;

public class Warden : User
{
    public int WardenID { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required Gender Gender { get; set; }
    public required string ContactNumber { get; set; }
    public required Faculty AssignedDormitory { get; set; }
}