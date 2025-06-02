using Microsoft.AspNetCore.Mvc;
using HelloWorldWebApp.Data;
using HelloWorldWebApp.Models;

namespace HelloWorldWebApp.Controllers;

public class MessagesController : Controller
{
    private readonly AppDbContext _context;

    public MessagesController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var messages = _context.Messages.ToList();
        return View(messages);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Message message)
    {
        if (ModelState.IsValid)
        {
            _context.Messages.Add(message);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(message);
    }
}