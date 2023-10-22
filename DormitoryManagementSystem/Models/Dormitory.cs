using System.Collections.Generic;

namespace EFCoreSQLiteDemo
{
    public class Dormitory
    {
        public int DormitoryID { get; set; }
        public int DormitoryNumber { get; set; }
        public string Location { get; set; }
        public int TotalRooms
        {
            get { return Rooms?.Count ?? 0; }
        }
        public ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}