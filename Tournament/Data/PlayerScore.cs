using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament.Data
{
    public class PlayerScore
    {
        //public string PlayerName { get; set; }
        public int GameFirstSet { get; set; }
        public int GameSecondSet { get; set; }
        public int GameThirdSet { get; set; }
        public int Set { get; set; }
        public PlayerScore(int gameFirstSet, int gameSecondSet, int gameThirdSet, int set)
        {
            this.GameFirstSet = gameFirstSet;
            this.GameSecondSet = gameSecondSet;
            this.GameThirdSet = gameThirdSet;
            this.Set = set;
        }
    }
}
