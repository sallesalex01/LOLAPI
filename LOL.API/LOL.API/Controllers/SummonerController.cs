using LOL.API.GameData;
using LOL.API.GameData.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LOL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummonerController : ControllerBase
    {
        private readonly GameDataService _gameDataService;
        public SummonerController(GameDataService gameDataService)
        {
            _gameDataService = gameDataService;
        }

        [HttpGet("{summonerNickname}")]
        public async Task<Summoner> GetAsync(string summonerNickname)
        {
            return await _gameDataService.GetSummonerData(summonerNickname);
        }
    }
}
