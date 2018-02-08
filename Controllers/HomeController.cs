using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TamagotchiLand.Model;
using System;

namespace TamagotchiLand.Controllers
{
    public class HomeController : Controller
    {
      Tamagotchi myTam = new Tamagotchi ("Weeder", 55, 55, 55);

        [Route("/Tam")]
        [Route("/")]
        public ActionResult Tam()
        {
          return View();
        }

        [HttpGet("/Tam")]
        public ActionResult Form()
        {
          // Tamagotchi myTam = new Tamagotchi ("Weeder", 55, 55, 55);
            return View();
        }

        // [HttpPost("/Tam")]
        // public ActionResult Create()
        // {
        //   // Item newItem = new Item (Request.Form["new-item"]);
        //   // newItem.Save();
        //   // List<Item> allItems = Item.GetAll();
        //   // return View("Index", allItems);
        //   // return View("Items", newItem);
        //   return View();
        // }

        [HttpGet("/Feed")]
        public ActionResult Feed()
        {
          // string x = (Request.Query["Feed"]);
          Console.WriteLine("Feed that Tam!");
          myTam.setFood(myTam.getFood()+1);
          return View("Tam", myTam);
          // return View("Items", newItem);
        }




        // [Route("/greeting_card")]
        // public ActionResult GreetingCard()
        // {
        //     LetterVariable myLetterVariable = new LetterVariable();
        //     myLetterVariable.SetRecipient(Request.Query["recipient"]);
        //     myLetterVariable.SetSender(Request.Query["sender"]);
        //     return View("Letter", myLetterVariable);
        // }
    }
}
