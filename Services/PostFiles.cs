using BlazorInputFile;
using BlzMON.Data;
using BlzMON.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlzMON.Services
{
    public class PostFiles
    {
        private readonly IWebHostEnvironment environment;
        private readonly ApplicationDbContext db;
        private readonly IServiceProvider _serviceProvider;

        public PostFiles(IWebHostEnvironment environment, ILogger<PostFiles> logger, IServiceProvider serviceProvider)
        {
            this.environment = environment;

            // get database context for service
            _serviceProvider = serviceProvider;
            var scope = _serviceProvider.CreateScope();
            db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            
            /// https://entityframeworkcore.com/knowledge-base/57495333/asp-net-core---repository-dependency-injection-fails-on-singleton-injection
        }

        // to upload file 
        public async Task UploadAsync(IFileListEntry fileEntry, string filename, int initializatorId, string fileTypeName)
        {
            try
            {
                // create directory with initializator id 
                string directory = environment.WebRootPath + "\\Uploads\\Initializator_" + initializatorId;
                if (!Directory.Exists(directory))
                {
                    DirectoryInfo di = Directory.CreateDirectory(directory);
                }

                Debug.Print(directory);
                //directory = environment.WebRootPath + "\\uploads\\" + companyId + "\\" + spesId;
                //if (!Directory.Exists(directory))
                //{
                //    DirectoryInfo di = Directory.CreateDirectory(directory);
                //}
                
                // save file in initializator directory
                var path = Path.Combine("wwwroot", directory, filename);
                var ms = new MemoryStream();
                await fileEntry.Data.CopyToAsync(ms);
                using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    ms.WriteTo(file);
                }
                Debug.Print(path);

                // Add file names with ";" to parse later
                Initializers initializer = db.Initializers.Find(initializatorId);

                if (fileTypeName.Contains("заявление")) initializer.FilesNamesZayavleniye += filename + ";";
                if (fileTypeName.Contains("представление")) initializer.FilesNamesPredstavleniye += filename + ";";
                if (fileTypeName.Contains("трудовая")) initializer.FilesNamesTrudovaya += filename + ";";
                if (fileTypeName.Contains("награда")) initializer.FilesNamesNagrady += filename + ";";
                if (fileTypeName.Contains("выписка")) initializer.FilesNamesVypyska += filename + ";";

                Debug.Print(fileTypeName);
                Debug.Print(initializer.FilesNamesZayavleniye);
                Debug.Print(initializer.FilesNamesPredstavleniye);
                Debug.Print(initializer.FilesNamesTrudovaya);
                Debug.Print(initializer.FilesNamesNagrady);
                Debug.Print(initializer.FilesNamesVypyska);

                // Update Initializers files names
                db.Initializers.Update(initializer);
                
                await db.SaveChangesAsync();
            }
            catch(Exception exp)
            {
                Debug.Print(exp.Message);
            }
        }

    }
}
