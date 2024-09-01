using Homework_19_2.Models;
using Homework_19_2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Homework_19_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContactService _contactService;

        public HomeController(ContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            //var model = new List<Contact> 
            //{
            //    new Contact { ID = 1, LastName = "Мурзин", FirstName = "Алексей", MiddleName = "Валерьевич", PhoneNumber = "334-456", Address = "г. Тюмень", Description = "Я" },
            //    new Contact { ID = 2, LastName = "Друшляк", FirstName = "Илья", MiddleName = "Петрович", PhoneNumber = "758-664", Address = "г. Тюмень", Description = "Друг" },
            //    new Contact { ID = 3, LastName = "Карпов", FirstName = "Даниил", MiddleName = "Васильевич", PhoneNumber = "558-156", Address = "г. Тюмень", Description = "Коллега" },
            //    new Contact { ID = 4, LastName = "Кондратьев", FirstName = "Николай", MiddleName = "Ильич", PhoneNumber = "123-547", Address = "г. Тюмень", Description = "Коллега" },
            //    new Contact { ID = 5, LastName = "Рагозин", FirstName = "Василий", MiddleName = "Викторович", PhoneNumber = "455-665", Address = "г. Тюмень", Description = "Друг" },
            //};
            //return View(model);            
            List<Contact> contacts = _contactService.GetContacts();
            return View(contacts);
        }

        public IActionResult Details(int id)
        {
            var contact = _contactService.GetContacts().FirstOrDefault(c => c.ID == id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }
    }
}
