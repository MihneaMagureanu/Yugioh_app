using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardsAPI.DbContexts;
using CardsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CardsAPI.Controllers
{
    [Route("[Controller]")]
    public class CardController : Controller
    {
        private Context _context;
        public CardController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Card> GetCards()
        {
            return _context.Cards.ToArray();
        }
        [HttpPost]
        [Route("post")]
        public void PostCards(List<Card> cards)
        {
            foreach(var card in cards)
            {
                _context.Cards.Add(card);
            }
            _context.SaveChanges();
            return;
        }
    }
}