using DormitoryManagementSystem.Enums;

namespace DormitoryManagementSystem.Models;

public class Rector : User
{
    public int RectorID { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required Gender Gender { get; set; }
    public required string ContactNumber { get; set; }
}