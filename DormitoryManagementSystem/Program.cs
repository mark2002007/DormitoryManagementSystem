using System;
using System.Linq;

namespace EFCoreSQLiteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new DormitoryContext())
            {

                var newDormitory = new Dormitory
                {
                    DormitoryNumber = 7,
                    Location = "Lviv, Stusa 12 St."
                };
                // dbContext.Dormitories.Add(newDormitory);

                var newFaculty = new Faculty
                {
                    FacultyName = "Faculty Of Applied Mathematics And Informathics"
                };
                // dbContext.Faculties.Add(newFaculty);

                var newResident = new Resident
                {
                    FirstName = "John",
                    LastName = "Doe",
                    ContactNumber = "123-456-7890",
                    AssignedFaculty = newFaculty
                };
                // dbContext.Residents.Add(newResident);

                var newRoom = new Room
                {
                    RoomNumber = 101,
                    Capacity = 3,
                    AssignedFaculty = newFaculty
                };
                // dbContext.Rooms.Add(newRoom);
            }
        }
    }
}
