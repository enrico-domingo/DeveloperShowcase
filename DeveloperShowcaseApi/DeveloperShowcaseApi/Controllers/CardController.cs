using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperShowcaseApi.Model;
using DeveloperShowcaseApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperShowcaseApi.Controllers
{
    [Route("api/v1/[controller]")]
    public class CardController : Controller
    {
        public readonly ICardServices _cardService;

       public CardController(ICardServices cardService)
        {
            _cardService = cardService;
        }

        [HttpGet("shufflecard")]
        public async Task<IEnumerable<CardModel>> ShuffleCard()
        {
            return await _cardService.ShuffleCards();
        }
    }
}