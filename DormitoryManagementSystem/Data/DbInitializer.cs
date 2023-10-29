using System.Net.Mime;
using System.Security.Cryptography.Xml;
using DormitoryManagementSystem.Data;
using DormitoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace DormitoryManagementSystem.Data;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        if (context.Rooms.Any())
        {
            return;   // DB has been seeded
        } 

        // Dormitory
        var dorm2  = new Dormitory(){DormitoryNumber = 2, Location=""};
        var dorm3  = new Dormitory(){DormitoryNumber = 3, Location=""};
        var dorm4  = new Dormitory(){DormitoryNumber = 4, Location=""};
        var dorm5  = new Dormitory(){DormitoryNumber = 5, Location=""};
        var dorm6  = new Dormitory(){DormitoryNumber = 6, Location=""};
        var dorm7  = new Dormitory(){DormitoryNumber = 7, Location=""};
        var dorm8  = new Dormitory(){DormitoryNumber = 8, Location=""};
        var dorm9  = new Dormitory(){DormitoryNumber = 9, Location=""};
        var dorm10 = new Dormitory(){DormitoryNumber = 10, Location=""};
        var dorm11 = new Dormitory(){DormitoryNumber = 11, Location=""};
        var dorm12 = new Dormitory(){DormitoryNumber = 12, Location=""};
        var dormitories = new List<Dormitory>{dorm2, dorm3, dorm4, dorm5, dorm6, dorm7, dorm8, dorm9, dorm10, dorm11, dorm12};
        context.Dormitories.AddRange(dormitories);

        // Faculty
        var geo_fac        = new Faculty(){FacultyName = "Геологічний факультет"};
        var eco_fac        = new Faculty(){FacultyName = "Економічний факультет"};
        var comp_fac       = new Faculty(){FacultyName = "Факультет електроніки та комп'ютерних технологій"};
        var jour_fac       = new Faculty(){FacultyName = "Факультет журналістики"};
        var fore_fac       = new Faculty(){FacultyName = "Факультет іноземних мов"};
        var hist_fac       = new Faculty(){FacultyName = "Історичний факультет"};
        var cult_fac       = new Faculty(){FacultyName = "Факультет культури і мистецтв"};
        var mech_fac       = new Faculty(){FacultyName = "Механіко-математичний факультет"};
        var frel_fac       = new Faculty(){FacultyName = "Факультет міжнародних відносин"};
        var math_fac       = new Faculty(){FacultyName = "Факультет прикладної математики та інформатики"};
        var phys_fac       = new Faculty(){FacultyName = "Фізичний факультет"};
        var philology_fac  = new Faculty(){FacultyName = "Філологічний факультет"};
        var philosophy_fac = new Faculty(){FacultyName = "Філософський факультет"};
        var chem_fac       = new Faculty(){FacultyName = "Хімічний факультет"};
        var law_fac        = new Faculty(){FacultyName = "Юридичний факультет"};
        var pada_fac       = new Faculty(){FacultyName = "Факультет педагогічної освіти"};
        var mana_fac       = new Faculty(){FacultyName = "Факультет управління фінансами та бізнесу"};
        var faculties = new List<Faculty>{
            geo_fac,    
            eco_fac,     
            comp_fac,      
            jour_fac,     
            fore_fac,     
            hist_fac,     
            cult_fac,      
            mech_fac,      
            frel_fac,      
            math_fac,      
            phys_fac,      
            philology_fac, 
            philosophy_fac,
            chem_fac,      
            law_fac,       
            pada_fac,      
            mana_fac,     
            // new Faculty(){FacultyName = "Інститут післядипломної освіти та доуніверситетської підготовки"},
            // new Faculty(){FacultyName = "Педагогічний фаховий коледж"},
            // new Faculty(){FacultyName = "Місця для аспірантів"},
            // new Faculty(){FacultyName = "Відділ міжнародних зв'язків"},
            // new Faculty(){FacultyName = "Закріпити під ізолятори"},
            // new Faculty(){FacultyName = "Закріпити під адміністративні та службові приміщення"},
            // new Faculty(){FacultyName = "Закріпити під кімнати поліпшеного типу для приїжджих"},
            // new Faculty(){FacultyName = "Кімната для занять студентів"},
        };
        context.Faculties.AddRange(faculties);

        // Room
        var dorm2_rooms = new List<Room>{
            //
            ////Геологічний
            //
            new Room(){RoomNumber =  "1024", AssignedDormitory = dorm2, AssignedFaculty = geo_fac, Capacity = 0},  
            //
            ////Економічний
            //
            new Room(){RoomNumber =   "415", AssignedDormitory = dorm2, AssignedFaculty = eco_fac, Capacity = 0},  
            new Room(){RoomNumber =  "128a", AssignedDormitory = dorm2, AssignedFaculty = eco_fac, Capacity = 0},  
            //
            ////Історичний
            //
            new Room(){RoomNumber =  "801a", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "801", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "802", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "803", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "804", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "805", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "806", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "807", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "808", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "809", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "810", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "811", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "812", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "813", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "814", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "814a", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0}, 
            new Room(){RoomNumber =  "901a", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "901", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "902", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "903", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "904", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "905", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "906", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "907", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "908", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "909", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "910", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "911", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "912", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "913", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =   "914", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "914a", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},
            new Room(){RoomNumber =  "1001", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1002", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1003", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1004", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1005", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1006", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1007", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1008", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1009", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1010", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1011", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1012", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1013", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1014", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber = "1014a", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber = "1015a", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber = "1101a", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1101", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1102", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1103", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1104", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1105", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1106", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1107", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1108", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1109", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1110", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1111", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1112", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1113", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1114", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber = "1114a", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1201", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1202", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1203", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1204", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1205", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1206", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1207", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1208", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1209", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1210", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1211", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1212", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1213", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1214", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1215", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0}, 
            new Room(){RoomNumber = "1201a", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0}, 
            new Room(){RoomNumber = "1214a", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0}, 
            new Room(){RoomNumber =  "1217", AssignedDormitory = dorm2, AssignedFaculty = hist_fac, Capacity = 0}, 
            //
            ////Журналістський
            //
            new Room(){RoomNumber =   "311", AssignedDormitory = dorm2, AssignedFaculty = jour_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "312", AssignedDormitory = dorm2, AssignedFaculty = jour_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "313", AssignedDormitory = dorm2, AssignedFaculty = jour_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "314", AssignedDormitory = dorm2, AssignedFaculty = jour_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "318", AssignedDormitory = dorm2, AssignedFaculty = jour_fac, Capacity = 0}, 
            new Room(){RoomNumber =  "314a", AssignedDormitory = dorm2, AssignedFaculty = jour_fac, Capacity = 0}, 
            //
            ////Іноземний
            //
            new Room(){RoomNumber =   "102", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "108", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "109", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "110", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "118", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "119", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "120", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "121", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "201", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "202", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "203", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "204", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "205", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "206", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "207", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =  "201a", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber = "1215a", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            new Room(){RoomNumber =  "1216", AssignedDormitory = dorm2, AssignedFaculty = fore_fac, Capacity = 0}, 
            //
            ////Хімічний
            //
            new Room(){RoomNumber =   "401", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "402", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "403", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "404", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "405", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "406", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "407", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "408", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "409", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "410", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "411", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "412", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "413", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "414", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "501", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "502", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "503", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "504", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "505", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "506", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "507", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "508", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "509", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "510", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "511", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "512", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "513", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "514", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "601", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "602", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "603", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "604", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "605", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "606", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "607", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "608", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "609", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "610", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "611", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "612", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "613", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "614", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "701", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "702", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "703", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "704", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "705", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "706", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "707", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "708", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "709", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "710", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "711", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "712", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "713", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =   "714", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =  "401a", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =  "414a", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =  "501a", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =  "514a", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =  "601a", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            new Room(){RoomNumber =  "701a", AssignedDormitory = dorm2, AssignedFaculty = chem_fac, Capacity = 0},  
            //
            ////Юридичний
            //
            new Room(){RoomNumber =   "101", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "211", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "215", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "216", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "217", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "226", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "326", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "327", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "615", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "616", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "617", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "618", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "619", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "620", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "621", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "622", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "623", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "624", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "625", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "626", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "627", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "628", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "715", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "716", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "717", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "718", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "719", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "720", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "721", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "722", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "723", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "724", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "725", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "726", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "727", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "728", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0}, 
            new Room(){RoomNumber =   "815", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "816", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "817", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "818", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "819", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "820", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "821", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "822", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "823", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "824", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "825", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "826", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "827", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "828", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "915", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "916", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "917", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "918", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "919", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "920", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "921", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "922", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "923", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "924", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "925", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "926", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "927", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =   "928", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0}, 
            new Room(){RoomNumber =  "1015", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1016", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1017", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1018", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1019", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1020", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1021", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1115", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1116", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1117", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1122", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1123", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1124", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1125", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1126", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1127", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1128", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1218", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1219", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1220", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1221", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1222", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1223", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "1224", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "214a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "328a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "615a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "628a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "715a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "728a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "815a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "828a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "915a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber =  "928a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber = "1028a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber = "1115a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber = "1128a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            new Room(){RoomNumber = "1228a", AssignedDormitory = dorm2, AssignedFaculty = law_fac, Capacity = 0},  
            //
            ////Ізолятори
            //
            new Room(){RoomNumber =   "113", AssignedDormitory = dorm2, Capacity = 0}, 
            new Room(){RoomNumber =   "114", AssignedDormitory = dorm2, Capacity = 0}, 
            //
            ////Адміністративні та службові
            //
            new Room(){RoomNumber =   "103", AssignedDormitory = dorm2, Capacity = 0}, 
            new Room(){RoomNumber =   "104", AssignedDormitory = dorm2, Capacity = 0}, 
            new Room(){RoomNumber =   "111", AssignedDormitory = dorm2, Capacity = 0}, 
            new Room(){RoomNumber =   "112", AssignedDormitory = dorm2, Capacity = 0}, 
            new Room(){RoomNumber =  "105a", AssignedDormitory = dorm2, Capacity = 0}, 
            new Room(){RoomNumber =  "112a", AssignedDormitory = dorm2, Capacity = 0}, 
            new Room(){RoomNumber =  "301a", AssignedDormitory = dorm2, Capacity = 0}, 
            new Room(){RoomNumber = "1001a", AssignedDormitory = dorm2, Capacity = 0}, 
        };
        // var dorm3_rooms = new List<Room>{...};

        context.Rooms.AddRange(dorm2_rooms);
        // context.Rooms.AddRange(dorm3_rooms);

        // Resident
        var residents = new List<Resident>{
            // new Resident(){}
        };
        context.Residents.AddRange(residents);
        context.SaveChanges();
    }
}