using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DeveloperShowcaseWeb.Models;
using DeveloperShowcaseWeb.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperShowcaseWeb.Controllers
{
    public class CardController : Controller
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        // GET: Card
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("card/shufflecard")]
        public async Task<ActionResult> ShuffleCard()
        {
            var result = await _cardService.ShuffleCard();
            return View(result);
        }
    }
}