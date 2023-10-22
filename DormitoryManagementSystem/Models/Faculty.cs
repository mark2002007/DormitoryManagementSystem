using System.Collections.Generic;

namespace EFCoreSQLiteDemo
{
    public class Faculty
    {
        public int FacultyID { get; set; }
        public string FacultyName { get; set; }
        public ICollection<Room> AssignedRooms { get; set; } = new List<Room>();
    }
}