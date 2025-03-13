using DAL.Context;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using BLL.Helper;

namespace Fast_Availability.Controllers
{
    [ApiController]
    //[Route("{controller=ControllerName}/")]
    public class BoxController : ControllerBase
    {
        private readonly BoxHelper _boxHelper;
        public BoxController(BoxHelper _boxHelper)
        {
            this._boxHelper = _boxHelper;
        }

        [HttpGet("GetAllBox")]
        public ICollection<Box> GetAllBox()
        {
            return _boxHelper.GetAll();
        }
    }
}
