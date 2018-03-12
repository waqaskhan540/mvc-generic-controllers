using genericcontroller.Conventions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace genericcontroller.Controllers
{
    [GenericControllerNameConvention]
    public class GenericController<T>:Controller
    {
        public IActionResult Index()
        {
            return Content($"Hello from a generic {typeof(T).Name} controller.");
        }
    }
}
