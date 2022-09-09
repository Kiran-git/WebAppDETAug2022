using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Services;

public class PizzaController : Controller
{
    public IActionResult Index()
    {
        List<Pizza> pizzas = PizzaServices.GetAll();
        return View(pizzas);
    }
    public IActionResult Detail(int id)
    {
        Pizza p = PizzaServices.Get(id);
        return View(p);
    }
    public IActionResult List()
    {
        List<Pizza> pizzas = PizzaServices.GetAll();
        return View(pizzas);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]

    public IActionResult Create(Pizza p)
    {
        PizzaServices.Add(p);
        return RedirectToAction("List");
    }



}