using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AddingStuffAndChecking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MonsterHunterController : Controller
    {
        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public HttpResponseMessage Add(MonsterHunter hunter)
        {
            //if (!ModelState.IsValid)
            //{

            //}

            return new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("OK")
            };
        }

        [HttpGet]
        public MonsterHunter Get()
        {
            MonsterHunter mh = new MonsterHunter();

            mh.Title = "Aloha Katora";
            mh.Age = 100;
            mh.Magic = 5;
            mh.Type = HeroType.Mage;
            mh.Strenght = 1;
            mh.Life = 3;
            mh.DefeatedMonsters = new List<Monster>()
            {
                new Monster()
                { FightType = FightType.Magic , Name = "Ghost", Power = 4}
            };

            return mh;
        }
    }
}


