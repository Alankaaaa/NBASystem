using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBASystem.Model
{
    public partial class Matchup
    {
        public string StatusName
        {
            get 
            {
                if (Status == 1)
                {
                    return "Finished";
                }
                else
                {
                    return "Not Stat";
                }
            }
        }
    }
}
