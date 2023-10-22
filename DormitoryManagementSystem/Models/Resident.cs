using System;

namespace EFCoreSQLiteDemo
{
    public class Resident
    {
        public int ResidentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public Faculty AssignedFaculty { get; set; }
        public Room? AssignedRoom { get; set; }
    }
}
