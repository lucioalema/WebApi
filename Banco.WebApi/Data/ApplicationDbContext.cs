using Banco.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.WebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Cliente>().HasData(SeedClientes());

            builder.Entity<Cuenta>().HasData
            (
                new Cuenta()
                {
                    Id = 1,
                    Numero = new Random().Next(1000, 9999),
                    ClienteId = 1000
                },
                new Cuenta()
                {
                    Id = 2,
                    Numero = new Random().Next(1000, 9999),
                    ClienteId = 1001
                }
            );
        }
        private IEnumerable<Cliente> SeedClientes()
        {
            var data = new Cliente[] {
                new Cliente { Id = 1000, Apellido = "Sheppard", Nombre = "Rebekah", FechaNacimiento = DateTime.ParseExact("12/11/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1001, Apellido = "Schultz", Nombre = "Nigel", FechaNacimiento = DateTime.ParseExact("10/06/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1002, Apellido = "Robertson", Nombre = "Victoria", FechaNacimiento = DateTime.ParseExact("07/06/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1003, Apellido = "Coleman", Nombre = "Cole", FechaNacimiento = DateTime.ParseExact("29/05/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1004, Apellido = "Herring", Nombre = "Ria", FechaNacimiento = DateTime.ParseExact("18/07/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1005, Apellido = "Hernandez", Nombre = "Camilla", FechaNacimiento = DateTime.ParseExact("28/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1006, Apellido = "Hart", Nombre = "Mara", FechaNacimiento = DateTime.ParseExact("01/10/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1007, Apellido = "Gonzalez", Nombre = "Merrill", FechaNacimiento = DateTime.ParseExact("15/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1008, Apellido = "Larsen", Nombre = "Alfreda", FechaNacimiento = DateTime.ParseExact("21/02/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1009, Apellido = "Rasmussen", Nombre = "Tallulah", FechaNacimiento = DateTime.ParseExact("14/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1010, Apellido = "Pacheco", Nombre = "Abel", FechaNacimiento = DateTime.ParseExact("06/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1011, Apellido = "Lancaster", Nombre = "Wing", FechaNacimiento = DateTime.ParseExact("06/09/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1012, Apellido = "Todd", Nombre = "Ezra", FechaNacimiento = DateTime.ParseExact("19/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1013, Apellido = "Strong", Nombre = "Samantha", FechaNacimiento = DateTime.ParseExact("01/12/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1014, Apellido = "Farmer", Nombre = "Harlan", FechaNacimiento = DateTime.ParseExact("24/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1015, Apellido = "Castillo", Nombre = "MacKensie", FechaNacimiento = DateTime.ParseExact("24/07/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1016, Apellido = "Wilkinson", Nombre = "Kimberley", FechaNacimiento = DateTime.ParseExact("13/12/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1017, Apellido = "Morton", Nombre = "Conan", FechaNacimiento = DateTime.ParseExact("26/06/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1018, Apellido = "Velazquez", Nombre = "Carson", FechaNacimiento = DateTime.ParseExact("02/09/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1019, Apellido = "Gay", Nombre = "Ainsley", FechaNacimiento = DateTime.ParseExact("18/09/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1020, Apellido = "Mccall", Nombre = "Kitra", FechaNacimiento = DateTime.ParseExact("27/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1021, Apellido = "Nash", Nombre = "Mason", FechaNacimiento = DateTime.ParseExact("04/05/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1022, Apellido = "Flores", Nombre = "Caleb", FechaNacimiento = DateTime.ParseExact("21/12/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1023, Apellido = "Carr", Nombre = "Nevada", FechaNacimiento = DateTime.ParseExact("02/07/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1024, Apellido = "Rivas", Nombre = "Scott", FechaNacimiento = DateTime.ParseExact("02/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1025, Apellido = "Hayes", Nombre = "Wallace", FechaNacimiento = DateTime.ParseExact("03/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1026, Apellido = "Mcdowell", Nombre = "Ima", FechaNacimiento = DateTime.ParseExact("02/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1027, Apellido = "Griffith", Nombre = "Katelyn", FechaNacimiento = DateTime.ParseExact("26/09/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1028, Apellido = "Rich", Nombre = "Theodore", FechaNacimiento = DateTime.ParseExact("27/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1029, Apellido = "Fulton", Nombre = "Darrel", FechaNacimiento = DateTime.ParseExact("15/07/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1030, Apellido = "Gibbs", Nombre = "Kelly", FechaNacimiento = DateTime.ParseExact("05/11/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1031, Apellido = "Fuller", Nombre = "Marah", FechaNacimiento = DateTime.ParseExact("01/05/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1032, Apellido = "Petty", Nombre = "Arthur", FechaNacimiento = DateTime.ParseExact("09/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1033, Apellido = "Morris", Nombre = "Grant", FechaNacimiento = DateTime.ParseExact("21/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1034, Apellido = "Griffin", Nombre = "Fitzgerald", FechaNacimiento = DateTime.ParseExact("06/10/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1035, Apellido = "Knapp", Nombre = "Melanie", FechaNacimiento = DateTime.ParseExact("10/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1036, Apellido = "Paul", Nombre = "Harlan", FechaNacimiento = DateTime.ParseExact("23/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1037, Apellido = "Gonzales", Nombre = "Valentine", FechaNacimiento = DateTime.ParseExact("05/02/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1038, Apellido = "Acosta", Nombre = "Bianca", FechaNacimiento = DateTime.ParseExact("27/10/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1039, Apellido = "Morin", Nombre = "Kelsey", FechaNacimiento = DateTime.ParseExact("22/06/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1040, Apellido = "Harrington", Nombre = "Brett", FechaNacimiento = DateTime.ParseExact("31/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1041, Apellido = "Maxwell", Nombre = "Whoopi", FechaNacimiento = DateTime.ParseExact("09/06/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1042, Apellido = "Fletcher", Nombre = "Kirby", FechaNacimiento = DateTime.ParseExact("07/12/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1043, Apellido = "English", Nombre = "Quintessa", FechaNacimiento = DateTime.ParseExact("17/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1044, Apellido = "Mckenzie", Nombre = "Tarik", FechaNacimiento = DateTime.ParseExact("02/05/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1045, Apellido = "Dawson", Nombre = "Darryl", FechaNacimiento = DateTime.ParseExact("12/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1046, Apellido = "Marks", Nombre = "Colleen", FechaNacimiento = DateTime.ParseExact("11/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1047, Apellido = "Wilcox", Nombre = "Martin", FechaNacimiento = DateTime.ParseExact("24/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1048, Apellido = "Mullins", Nombre = "Nathan", FechaNacimiento = DateTime.ParseExact("11/01/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1049, Apellido = "Combs", Nombre = "Yeo", FechaNacimiento = DateTime.ParseExact("06/04/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1050, Apellido = "Parsons", Nombre = "Mark", FechaNacimiento = DateTime.ParseExact("29/04/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1051, Apellido = "Haney", Nombre = "Fiona", FechaNacimiento = DateTime.ParseExact("15/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1052, Apellido = "Davidson", Nombre = "Jemima", FechaNacimiento = DateTime.ParseExact("07/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1053, Apellido = "Gibbs", Nombre = "Skyler", FechaNacimiento = DateTime.ParseExact("30/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1054, Apellido = "Nash", Nombre = "Jorden", FechaNacimiento = DateTime.ParseExact("08/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1055, Apellido = "Mcintyre", Nombre = "Peter", FechaNacimiento = DateTime.ParseExact("16/06/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1056, Apellido = "Lopez", Nombre = "Damian", FechaNacimiento = DateTime.ParseExact("28/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1057, Apellido = "Porter", Nombre = "Brent", FechaNacimiento = DateTime.ParseExact("18/05/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1058, Apellido = "Hull", Nombre = "Hannah", FechaNacimiento = DateTime.ParseExact("27/12/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1059, Apellido = "Stafford", Nombre = "Lael", FechaNacimiento = DateTime.ParseExact("17/01/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1060, Apellido = "Church", Nombre = "Desirae", FechaNacimiento = DateTime.ParseExact("10/05/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1061, Apellido = "Martinez", Nombre = "Brent", FechaNacimiento = DateTime.ParseExact("12/12/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1062, Apellido = "Sharpe", Nombre = "Iris", FechaNacimiento = DateTime.ParseExact("19/08/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1063, Apellido = "Bender", Nombre = "Tamara", FechaNacimiento = DateTime.ParseExact("27/06/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1064, Apellido = "Matthews", Nombre = "Susan", FechaNacimiento = DateTime.ParseExact("23/12/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1065, Apellido = "Wells", Nombre = "Elaine", FechaNacimiento = DateTime.ParseExact("27/02/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1066, Apellido = "Harris", Nombre = "Stacey", FechaNacimiento = DateTime.ParseExact("12/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1067, Apellido = "Johns", Nombre = "Caesar", FechaNacimiento = DateTime.ParseExact("11/10/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1068, Apellido = "David", Nombre = "Logan", FechaNacimiento = DateTime.ParseExact("18/04/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1069, Apellido = "Harper", Nombre = "Anne", FechaNacimiento = DateTime.ParseExact("02/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1070, Apellido = "Jones", Nombre = "Demetria", FechaNacimiento = DateTime.ParseExact("06/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1071, Apellido = "Bowman", Nombre = "Elliott", FechaNacimiento = DateTime.ParseExact("29/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1072, Apellido = "Leonard", Nombre = "Akeem", FechaNacimiento = DateTime.ParseExact("21/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1073, Apellido = "Buckley", Nombre = "Dominique", FechaNacimiento = DateTime.ParseExact("21/10/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1074, Apellido = "Dickson", Nombre = "Murphy", FechaNacimiento = DateTime.ParseExact("23/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1075, Apellido = "Sanchez", Nombre = "Hoyt", FechaNacimiento = DateTime.ParseExact("18/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1076, Apellido = "Knight", Nombre = "Hamish", FechaNacimiento = DateTime.ParseExact("25/12/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1077, Apellido = "Puckett", Nombre = "Damian", FechaNacimiento = DateTime.ParseExact("20/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1078, Apellido = "Medina", Nombre = "Petra", FechaNacimiento = DateTime.ParseExact("03/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1079, Apellido = "Baird", Nombre = "Hamilton", FechaNacimiento = DateTime.ParseExact("06/01/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1080, Apellido = "Jensen", Nombre = "Rudyard", FechaNacimiento = DateTime.ParseExact("04/12/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1081, Apellido = "Hooper", Nombre = "Connor", FechaNacimiento = DateTime.ParseExact("21/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1082, Apellido = "Santos", Nombre = "Kay", FechaNacimiento = DateTime.ParseExact("02/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1083, Apellido = "Anthony", Nombre = "Kasper", FechaNacimiento = DateTime.ParseExact("19/08/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1084, Apellido = "Leblanc", Nombre = "Magee", FechaNacimiento = DateTime.ParseExact("02/06/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1085, Apellido = "Vaughan", Nombre = "Cyrus", FechaNacimiento = DateTime.ParseExact("28/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1086, Apellido = "Steele", Nombre = "Jasper", FechaNacimiento = DateTime.ParseExact("19/12/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1087, Apellido = "Cotton", Nombre = "Patrick", FechaNacimiento = DateTime.ParseExact("19/04/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1088, Apellido = "Delacruz", Nombre = "Thaddeus", FechaNacimiento = DateTime.ParseExact("24/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1089, Apellido = "Clements", Nombre = "Ava", FechaNacimiento = DateTime.ParseExact("03/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1090, Apellido = "Montgomery", Nombre = "Amos", FechaNacimiento = DateTime.ParseExact("31/10/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1091, Apellido = "Erickson", Nombre = "Hammett", FechaNacimiento = DateTime.ParseExact("15/04/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1092, Apellido = "Dudley", Nombre = "Keefe", FechaNacimiento = DateTime.ParseExact("28/12/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1093, Apellido = "Hancock", Nombre = "Idola", FechaNacimiento = DateTime.ParseExact("02/12/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1094, Apellido = "Gates", Nombre = "William", FechaNacimiento = DateTime.ParseExact("10/12/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1095, Apellido = "Spencer", Nombre = "Felix", FechaNacimiento = DateTime.ParseExact("12/05/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1096, Apellido = "Gillespie", Nombre = "Maxwell", FechaNacimiento = DateTime.ParseExact("19/04/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1097, Apellido = "Grimes", Nombre = "Sophia", FechaNacimiento = DateTime.ParseExact("14/05/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1098, Apellido = "Hicks", Nombre = "Oren", FechaNacimiento = DateTime.ParseExact("23/11/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Cliente { Id = 1099, Apellido = "Hanson", Nombre = "Reuben", FechaNacimiento = DateTime.ParseExact("21/02/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) }
            };
            return data;
        }
    }
}
