using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index() //Calls the controllers View method and generates a HTMLresponse.
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    //public string Welcome(string name)
    //{
    //    return "Hi " + name;
    //}
    //public string Welcome(string name, int numTimes = 1)
    //{
    //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    //}
    //public string Welcome(string name, int ID = 1) //Post verfication can be seen below. HTMLEncoder prevents JS attacks.
    //{
    //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    //}
    //Usage: https://localhost:7080/HelloWorld/Welcome/3?name=Raza

    public IActionResult Welcome(string name, int numTimes = 1) //
    {
        ViewData["Message"] = "Hello " + name; //The ViewData dictionary object contains data that will be passed to the view.
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}