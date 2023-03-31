using CSD.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace CSD.Web.Controllers;

public class CategoriesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    private readonly CSDContext _db;

    public CategoriesController(CSDContext db)
    {
        _db = db;
    }
}
