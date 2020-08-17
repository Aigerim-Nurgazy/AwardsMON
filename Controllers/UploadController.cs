//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Localization;
//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace BlzMON.Controllers
//{
//    [DisableRequestSizeLimit]
//    public class UploadController : Controller
//    {
//        private readonly IWebHostEnvironment _environment;
//        public UploadController(IWebHostEnvironment environment)
//        {
//            _environment = environment;
//        }

//        // to upload several files 
//        [HttpPost("InitializerPage/MultipleA")]
//        public IActionResult Multiple(string filesA, IFormFile[] files)
//        {
//            PrintObj(files[0] + "!!!");
//            Debug.Print(filesA + "!!!");

//            try
//            {
//                foreach (var file in files)
//                {
//                    UploadFile(file);
//                }

//                return StatusCode(500);
                
//            }
//            catch(Exception ex)
//            {
//                return StatusCode(500, ex.Message);
//            }
//        }

//        // to save file
//        private async Task UploadFile(IFormFile file)
//        {
//            if(file != null && file.Length>0)
//            {
//                var imagePath = @"/Upload";
//                var UploadPath = _environment.WebRootPath + imagePath;
//                if (!Directory.Exists(UploadPath))
//                {
//                    Directory.CreateDirectory(UploadPath);

//                }
//                var fullPath = Path.Combine(UploadPath, file.FileName);
//                using (FileStream fileStream = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
//                {
//                    await file.CopyToAsync(fileStream);
//                }
//            } 
//        }

//        private void PrintObj(object obj)
//        {
//            Type t = obj.GetType(); // Where obj is object whose properties you need.
//            PropertyInfo[] pi = t.GetProperties();
//            foreach (PropertyInfo p in pi)
//            {
//                Debug.Print(p.Name + " : " + p.GetType());
//            }
//        }


//        // GET: api/values
//        [HttpGet]
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET api/values/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/values
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }

//        // PUT api/values/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/values/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
