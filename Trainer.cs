using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fussball_Simulator
{
    public class Trainer : Person
    {
        private int _erfahrung;

        public Trainer(string name, int alter, int erfahrung):base(name,alter)
        {
            _erfahrung = erfahrung;
        }

        public int GetErfahrung()
        { return _erfahrung; }
    }
}