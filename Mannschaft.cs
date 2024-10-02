using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fussball_Simulator
{
    public class Mannschaft
    {
        private string _name;
        private Trainer _trainer;
        private Spieler[] _spieler;
        private Torwart _torwart;

        public Mannschaft(string name,Trainer trainer, Torwart torwart, Spieler[] spieler)
        {
            _name = name;
            _trainer = trainer;
            _spieler = spieler;
            _torwart = torwart;
        }

        public string GetName()
        {
            return _name;
        }

        public Spieler[] getSpieler()
        {
            return _spieler;
        }

        public Torwart GetTorwart()
        {
            return _torwart;
        }

        public Trainer GetTrainer()
        {
            return _trainer;
        }

        public int GetStärke()
        {
            int summe = 0;
            foreach(Spieler s in _spieler)
            {
                summe += s.GetStärke();
            }
            return summe;
        }

        public int GetMotivation()
        {
            int summe = 0;
            foreach (Spieler s in _spieler)
            {
                summe += s.GetMotivation();
            }
            return summe;
        }

        public Spieler[] GetKader()
        {
            return _spieler;
        }
    }
}