using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dyrmyshi.leo._5h.ECommerce.Models;

namespace dyrmyshi.leo._5h.ECommerce.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _context = new CreateDbContext();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Shop()
    {
        return View();
    }

    [HttpGet]
    public ActionResult Registrati
    ()
    {
        return View();
    }
    private readonly CreateDbContext _context; 

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Registrati(Utente model)
    {
        if (ModelState.IsValid)
        {
            var newUser = new Utente
            {
                Username = model.Username,
                Email = model.Email,
                Password = model.Password 
            };

            _context.Utenti.Add(newUser);

            _context.SaveChanges();
            return RedirectToAction("Shop", "Home");
        }

        
        return View(model);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Logout()
    {
        // Effettua il logout eliminando l'identità dell'utente
        Utente.Registrati();

        // Reindirizza l'utente alla pagina di login
        return RedirectToAction("Index", "Home");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }



    
}
