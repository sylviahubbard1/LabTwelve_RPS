using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelve_RPS
{
    class Player1 : Player
    {


        public override RoshamboEnum generateRoshambo()
        {
            return RoshamboEnum.ROCK;
        }
    }
}
