using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fussball_Simulator
{
    public class Spieler : Person
    {
        protected int _stärke;
        protected int _torschuss;
        protected int _motivation;
        protected int _tore;

        public Spieler(string name, int alter, int stärke, int torschuss, int motivation) : base (name, alter)
        {
            _stärke = stärke;
            _torschuss = torschuss;
            _motivation = motivation;
            


        }
        public void AddTor()
        {
            _tore++;
        }
    public int SchiesstAufTor()
    {
        _torschuss = Math.Max(1, Math.Min(10, _torschuss - random.Next(3)));
        int schussQualität = Math.Max(1, Math.Min(10, _torschuss + random.Next(3) - 1));
        return schussQualität;
    }

        public int GetMotivation()
        { return _motivation; }
        public int GetStärke()
        {
            return _stärke;
        }
        public int GetTore()
        { return _tore; }


    }
}