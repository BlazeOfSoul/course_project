using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Controllers
{
    public class BaseController : Controller
    {
        public int GetUserId
        {
            get
            {
                var userId = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimsIdentity.DefaultNameClaimType)?.Value;
                if (userId == null) return 1;
                return int.Parse(userId);
            }
        }
        
    }
}
