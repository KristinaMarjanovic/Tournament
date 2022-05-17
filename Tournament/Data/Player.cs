using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament.Data
{
    public class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public PlayerScore Score { get; set; }
        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }
    }
}
