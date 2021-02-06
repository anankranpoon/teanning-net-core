using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.HTTP.Request;
using WebApplication1.HTTP.Response;

namespace WebApplication1.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        [Route("getNewsList")]
        IActionResult getNewsList() {
            return Ok(new
            {
                Data = "success"
            });
        }

        [Route("getCalcurate")]
        IActionResult calcurateter([FromBody] CalcurateRequest cal ) {
           
            int result = cal.number * 2;
            if (result < 0) {
                return BadRequest(new {
                    data = result
                });
            }


            return Ok(new CalcurateResponse
            {
                data =result
            });
        }
    }


}