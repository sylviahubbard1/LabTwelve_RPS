using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelve_RPS
{
    class Player2 : Player
    {
        public override RoshamboEnum generateRoshambo()
        {
            Random rdn = new Random();
            int randomNumber = rdn.Next(0, 3);
            if (randomNumber == 0)
            {
                return RoshamboEnum.ROCK;

            }
            if (randomNumber == 1)
            {
                return RoshamboEnum.PAPER;
            }
            return RoshamboEnum.SCISSORS;
        }
    }
    }

