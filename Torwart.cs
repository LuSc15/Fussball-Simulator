using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fussball_Simulator
{
    public class Torwart : Spieler
    {
       
        private int _reaktion;

        public Torwart(string name, int alter, int stärke, int torschuss,
        int motivation, int reaktion) : base(name,alter,stärke,torschuss,motivation)
        {
            _reaktion = reaktion;
        }
        public bool HältDenSchuss(int schussQualität)
        {
            int halteQualität = Math.Max(1, Math.Min(10, _reaktion + random.Next(3) - 1));
            if (halteQualität >= schussQualität)
            {
                return true; // gehalten
            }
            else
            {
                return false; // TOR!!!
            }
        }
        public int getReaktion()
        {
            return _reaktion;
        }
    }


}