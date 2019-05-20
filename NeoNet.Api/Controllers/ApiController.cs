using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoNet.Api.Controllers
{
    public class ApiController : ControllerBase
    {

        protected void NotifyModelStateErrors()
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var error in errors)
            {
                var erroMsg = error.Exception == null ? error.ErrorMessage : error.Exception.Message;
                //NotifyError(string.Empty, erroMsg);
            }
        }
       
        protected new IActionResult Response(object result = null)
        {
            return Ok(new
            {
                success = true,
                data = result
            });
        }
    }
}
