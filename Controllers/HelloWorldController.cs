//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace MvcMovie.Controllers
//{
//    public class HelloWorldController : Controller
//    {
//        // GET: /<controller>/
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace MvcMovie.Controllers;

// Every public method in a controller is callable as an HTTP endpoint. In the sample below, both methods return a string.
// Note the comments preceding each method.
// The default URL routing logic used by MVC, uses a format like this to determine what code to invoke:
// /[Controller]/[ActionName]/[Parameters] -> you can customize the routing format in Program.cs pattern: _____

public class HelloWorldController : Controller
{

    public IActionResult Index()
    {
        // when /HelloWorld/ is access, Index() is invoked and returns a View(), which specified that the method should use a view template file to render a reponse to the browser
        // a view template file name wasnt specified so MVC defauled to using the default view file
        // the default view has the same name as the action method, so here the view template at /Views/HelloWorld/index.cshtml was used
        return View();
    }

    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome(string name, int numTimes = 1)
    {
        // HtmlEncoder.Default.Encode used protect the app from malicious input, such as through JavaScript.
        // interpolated strings are like print(f"strings") in python

        // The URL segment Parameters isn't used.
        // The name and numTimes parameters are passed in the query string.
        // The ? (question mark) in the above URL is a separator, and the query string follows.
        // The & character separates field-value pairs.
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is {numTimes}");
    }

    // GET: /HelloWorld/Welcome2/
    // if we type in the url with /HelloWorld/Welcome2/3?name=andres
    // here, the third segment matches the route parameter id
    // The Welcome method contains a parameter id that matched the URL template in the MapControllerRout method.
    // The trailing ? starts the query string.
    public string Welcome2(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
    // stopped at https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-7.0&tabs=visual-studio-code#passing-data-from-the-controller-to-the-view
}


