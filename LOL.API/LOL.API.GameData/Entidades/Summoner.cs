using RiotSharp.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL.API.GameData.Entidades
{
    public class Summoner
    {
        public string Name { get; set; }
        public string AccountID { get; set; }
        public long Level { get; set; }
        public Region Region { get; set; }
        public string Id { get; set; }
        public string Puuid { get; set; }
        public int ProfileIconId { get; set; }
        public DateTime RevisionDate { get; set; }
    }
}
