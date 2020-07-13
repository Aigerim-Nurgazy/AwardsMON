using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlzMON.Controllers
{
    [DisableRequestSizeLimit]
    public class UploadController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public UploadController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        [HttpPost("InitializerPage/Multiple")]
        public IActionResult Multiple(IFormFile[] files)
        {
            try
            {
                foreach (var file in files)
                {
                    UploadFile(file);
                    
                }
                return StatusCode(500);
                
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        public async Task UploadFile(IFormFile file)
        {
            if(file != null && file.Length>0)
            {
                var imagePath = @"|Upload";
                var UploadPath = _environment.WebRootPath + imagePath;
                if (!Directory.Exists(UploadPath))
                {
                    Directory.CreateDirectory(UploadPath);

                }
                var fullPath = Path.Combine(UploadPath, file.FileName);
                using (FileStream fileStream = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    await file.CopyToAsync(fileStream);
                }
            } 
        }




        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
