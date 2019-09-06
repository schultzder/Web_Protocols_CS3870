using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using StudentRegistraionDemo3.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentRegistraionDemo3.Controllers
{
    [Route("api/[controller]")]
    public class StudentDeleteController : Controller
    {
        [Route("student/remove/{regdNum}")]
        // DELETE: api/<controller>
        [HttpDelete]
        public IActionResult DeleteStudentRecord(String regdNum)
        {
            Console.WriteLine("In deleteStudentRecord");
            return Ok(StudentRegistration.getInstance().Remove(regdNum));
        }
    }
}
