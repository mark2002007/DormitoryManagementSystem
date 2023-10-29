using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;



namespace DormitoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new DormitoryContext())
            {
                dbContext.Database.EnsureDeletedAsync();
                dbContext.Database.EnsureCreatedAsync();

                var newDormitory = new Dormitory
                {
                    DormitoryNumber = 7,
                    Location = "Lviv, Stusa 12 St."
                };
                dbContext.Dormitories.Add(newDormitory);

                var newFaculty = new Faculty
                {
                    FacultyName = "Faculty Of Applied Mathematics And Informathics"
                };
                dbContext.Faculties.Add(newFaculty);

                var newResident = new Resident
                {
                    FirstName = "John",
                    LastName = "Doe",
                    ContactNumber = "123-456-7890",
                    AssignedFaculty = newFaculty,
                    Gender = Gender.Male
                };
                dbContext.Residents.Add(newResident);

                var newRoom = new Room
                {
                    RoomNumber = 101,
                    Capacity = 3,
                    AssignedFaculty = newFaculty
                };
                // newRoom.Residents.Add(newResident);
                dbContext.Rooms.Add(newRoom);

                dbContext.SaveChanges();
                Console.WriteLine(dbContext.Rooms.First().CurrentOccupancy);
            }
        }
    }
}
