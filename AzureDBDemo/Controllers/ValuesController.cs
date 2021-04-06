using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureDBDemo.OrgModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureDBDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        KaniniSampleDBContext db = new KaniniSampleDBContext();
        public IActionResult getEmployees()
        {
            return Ok(db.Employees.ToList());
        }
    }
}
