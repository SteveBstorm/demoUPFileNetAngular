using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DemoUpload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UploadImage()
        {
            HttpRequest req = HttpContext.Request;
            Guid newName = Guid.NewGuid();
            string fileName = newName.ToString()+req.Form.Files[0].FileName;

            //Creer le dossier de réception si inéxistant
            if (!Directory.Exists("upload")) Directory.CreateDirectory("upload");

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "upload/", fileName);

            string path = Directory.GetCurrentDirectory() + "upload/" + fileName;

            //if(System.IO.File.Exists(filePath))
            //{
            //    System.IO.File.Delete(filePath);
            //}

            using(FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                await req.Form.Files[0].CopyToAsync(fs);

                //return this.StatusCode(200, "http://localhost:54266/upload/" + fileName);
                return this.StatusCode(200, "https://localhost:44375/upload/" + fileName);

            }
        }
    }
}
