using Microsoft.AspNetCore.Mvc;
using HospitalManagementSystem.Data;
using Microsoft.EntityFrameworkCore;


namespace HospitalManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
        protected readonly ILogger<BaseController> _logger;

        protected BaseController(ILogger<BaseController> logger)
        {
            _logger = logger;
        }
    }

}
