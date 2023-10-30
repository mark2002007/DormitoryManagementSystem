using DormitoryManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ApplicationDbContext>();
    context.Database.EnsureDeleted();

    string dbFilePath = context.Database.GetDbConnection().ConnectionString.Split('=')[1];
    string shmFilePath = dbFilePath + "-shm";
    string walFilePath = dbFilePath + "-wal";
    if (File.Exists(shmFilePath))
        File.Delete(shmFilePath);
    if (File.Exists(walFilePath))
        File.Delete(walFilePath);
        
    context.Database.EnsureCreated();
    DbInitializer.Initialize(context);
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();


// using System;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;

// namespace DormitoryManagementSystem
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             using (var dbContext = new DormitoryContext())
//             {
//                 dbContext.Database.EnsureDeletedAsync();
//                 dbContext.Database.EnsureCreatedAsync();

//                 var newDormitory = new Dormitory
//                 {
//                     DormitoryNumber = 7,
//                     Location = "Lviv, Stusa 12 St."
//                 };
//                 dbContext.Dormitories.Add(newDormitory);

//                 var newFaculty = new Faculty
//                 {
//                     FacultyName = "Faculty Of Applied Mathematics And Informathics"
//                 };
//                 dbContext.Faculties.Add(newFaculty);

//                 var newResident = new Resident
//                 {
//                     FirstName = "John",
//                     LastName = "Doe",
//                     ContactNumber = "123-456-7890",
//                     AssignedFaculty = newFaculty,
//                     Gender = Gender.Male
//                 };
//                 dbContext.Residents.Add(newResident);

//                 var newRoom = new Room
//                 {
//                     RoomNumber = 101,
//                     Capacity = 3,
//                     AssignedFaculty = newFaculty
//                 };
//                 // newRoom.Residents.Add(newResident);
//                 dbContext.Rooms.Add(newRoom);

//                 dbContext.SaveChanges();
//                 Console.WriteLine(dbContext.Rooms.First().CurrentOccupancy);
//             }
//         }
//     }
// }
