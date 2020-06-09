using CsvHelper;
using HospitalsBlz.Data;
using HospitalsBlz.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HospitalsBlz.Data
{
    public class DataSeeder
    {
//        private readonly UserManager<ApplicationUser> userManager;
  //      private readonly RoleManager<IdentityRole> roleManager;

        //public DataSeeder(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        //{
        //    this.userManager = userManager;
        //    this.roleManager = roleManager;
        //}
        public static void SeedCountries(ApplicationDbContext context)
        {
            try
            {
                if (!context.Hospitals.Any())
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    string resourceName = "HospitalsBlz.Data.ipu.csv";
                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                    {
                        using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                        {
                            CsvReader csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
                            //csvReader.Configuration.HeaderValidated = false;
                            var departments = csvReader.GetRecords<Hospitals>().ToArray();
                            //context.Departments.AddOrUpdate(c => c.Code, countries);
                            foreach (Hospitals record in departments)
                            {
                                context.Hospitals.Add(record);
                            }
                            context.SaveChanges();
                        }
                    }

                    //context.Departments.Add(new Departments { Address = "", Contacts = "", Name = "IT", Phone = "XXX" });
                    //context.SaveChanges();
                }

                //if (!context.DictCountry.Any())
                //{
                //    var resourceName = "AisMKIT.Data.Countries.xml";
                //    var assembly = Assembly.GetExecutingAssembly();
                //    var stream = assembly.GetManifestResourceStream(resourceName);
                //    var xml = XDocument.Load(stream);
                //    var countries = xml.Element("countries")
                //                    .Elements("country")
                //                    .Select(x => new DictCountry
                //                    {
                //                        Name = (string)x.Element("name"),
                //                        FullName = (string)x.Element("fullname"),
                //                        Alpha2 = (string)x.Element("alpha2"),
                //                        Alpha3 = (string)x.Element("alpha3"),
                //                        English = (string)x.Element("english"),
                //                        ISO = (string)x.Element("iso"),
                //                        Location = (string)x.Element("location"),
                //                        LocationPrecise = (string)x.Element("location-precise"),
                //                    }).ToArray();
                //    context.DictCountry.AddRange(countries); // AddOrUpdate(c => c.Name, countries);

                //    context.SaveChanges();
                //}


            }
            catch (Exception exp){
                var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder
                        .AddFilter("Microsoft", LogLevel.Warning)
                        .AddFilter("System", LogLevel.Warning)
                        .AddFilter("LoggingConsoleApp.Program", LogLevel.Debug)
                        .AddConsole()
                        .AddEventLog();
                });
               // ILogger logger = loggerFactory.CreateLogger<Program>();
                //logger.LogInformation("Example log message : "+exp.Message);
            }

            //if (!context.Users.Any())
            //{
            //    string user1 = "editor1@example.com";
            //    ApplicationUser editor1 = new ApplicationUser { Email = user1, UserName = user1 }; ;

            //    IdentityResult result = userManager.CreateAsync(editor1, "ASDfgh1!");

            //    if (result.Succeeded)
            //    {
            //        userManager.AddToRoleAsync(editor1, "АДМИНИСТРАТОР");
            //    }
            //}


            //if (!context.DictMediaControlResult.Any())
            //{
            //    context.DictMediaControlResult.Add(new DictMediaControlResult() { NameKyrg = "", NameRus = "", DictStatusId = 1, CreateDate = DateTime.Now });
            //    context.DictMediaControlResult.Add(new DictMediaControlResult() { NameKyrg = "", NameRus = "", DictStatusId = 1, CreateDate = DateTime.Now });
            //}


        }
    }
}
