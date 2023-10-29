namespace DormitoryManagementSystem.Models;

public class User
{
    public int UserID { get; set; }
    public required string Login { get; set; }
    public required string PasswordHash { get; set; }
}