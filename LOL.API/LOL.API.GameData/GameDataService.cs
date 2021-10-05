using LOL.API.GameData.Entidades;
using RiotSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LOL.API.GameData
{
    public class GameDataService
    {
        public List<Champion> GetChampions()
        {
            var ChampionList = new List<Champion>();

            ChampionList.Add(new Champion
            {
                Name = "Zed",
                DataCompra = DateTimeOffset.Now
            });
            ChampionList.Add(new Champion
            {
                Name = "Yasuo",
                DataCompra = DateTimeOffset.Now
            });
            return ChampionList;
        }
        public async Task<Summoner> GetSummonerData(string SummonerNickname)
        {
            var api = RiotApi.GetDevelopmentInstance("RGAPI-d402b666-abf1-406d-b001-02cc8a5e1da8");
            var Riotsummoner = await api.Summoner.GetSummonerByNameAsync(RiotSharp.Misc.Region.Br, SummonerNickname);
            var summoner = new Summoner
            {
                AccountID = Riotsummoner.AccountId,
                Level = Riotsummoner.Level,
                Name = Riotsummoner.Name,
                Id = Riotsummoner.Id,
                ProfileIconId = Riotsummoner.ProfileIconId,
                Puuid = Riotsummoner.Puuid,
                Region = Riotsummoner.Region,
                RevisionDate = Riotsummoner.RevisionDate,
            };
            return summoner;
        }
    }
}
