using System;

namespace EFCoreSQLiteDemo
{
    public class Room
    {
        public int RoomID { get; set; }
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public ICollection<Resident> Residents { get; set; } = new List<Resident>();
        public int CurrentOccupancy
        {
            get { return Residents?.Count ?? 0; }
        }
        public Faculty? AssignedFaculty { get; set; }
    }
}
