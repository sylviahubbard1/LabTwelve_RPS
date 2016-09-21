using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelve_RPS
{
    abstract class Player
    {
        private string _name = "";
        private RoshamboEnum _roshambo;
        abstract public RoshamboEnum generateRoshambo();
       
        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }
       
        public RoshamboEnum Roshambo
        {
            get { return _roshambo; }
            set { this._roshambo = value; }
        }

    }
}
