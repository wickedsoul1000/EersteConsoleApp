using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class opdracht8
    {
        public void Start()
        {
            List<player> players = new List<player>() {
                new player("wicked", 5, 9),
                new player("soul", 15, 3),
                new player("fafnir", 95, 93),
            };

            foreach (player plr in players) {
                plr.ShowStats();


            }
        }
    }
}
