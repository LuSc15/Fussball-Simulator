using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fussball_Simulator
{
    public class Spiel
    {
        Random random = new Random();
        private string _nameHeimMannschaft;
        private string _nameGastMannschaft;
        private int _punkteHeim;
        private int _punkteGast;

        public Spiel()
        {
        }
        public string GetHeimMannschaft()
        {
            return _nameHeimMannschaft;
        }
        public string GetGastMannschaft()
        {
            return _nameGastMannschaft;
        }
        public int GetHeimPunkte()
        {
            return _punkteHeim;
        }
        public int GetGastPunkte()
        {
            return _punkteGast;
        }
        public string GetErgebnisText()
        {
            return $"{_nameHeimMannschaft} {_punkteHeim}:{_punkteGast} {_nameGastMannschaft}";
        }

        public void StarteSpiel(Mannschaft m1, Mannschaft m2)
        {
            _nameHeimMannschaft = m1.GetName();
            _nameGastMannschaft = m2.GetName();
            _punkteHeim = 0;
            _punkteGast = 0;

            // jetzt starten wir das Spiel und erzeugen für die 90 Minuten
            // Spiel plus Nachspielzeit die verschiedenen Aktionen
            // (wahrscheinlichkeitsbedingt) für das Spiel
            bool spielläuft = true;
            int spieldauer = 90 + random.Next(5);
            int zeit = 1;
            int nächsteAktion;

            // solange das Spiel läuft, koennen Torchancen entstehen...
            while (spielläuft)
            {
                nächsteAktion = random.Next(15) + 1;

                // Ist das Spiel schon zu Ende?
                if ((zeit + nächsteAktion > spieldauer) || (zeit > spieldauer))
                {
                    spielläuft = false;
                    break;
                }
                // **********************************************************
                // Eine neue Aktion findet statt...
                zeit = zeit + nächsteAktion;

                // Einfluss der Motivation auf die Stärke:
                float stärke_1 = (m1.GetStärke() / 2.0f) + ((m1.GetStärke() / 2.0f) * (m1.GetMotivation() / 10.0f));
                float stärke_2 = (m2.GetStärke() / 2.0f) + ((m2.GetStärke() / 2.0f) * (m2.GetMotivation() / 10.0f));

                // Einfluss des Trainers auf die Stärke:
                int abweichung = random.Next(2);
                if (stärke_1 > m1.GetTrainer().GetErfahrung())
                {
                    abweichung = -abweichung;
                }
                stärke_1 = Math.Max(1, Math.Min(10, stärke_1 + abweichung));
                abweichung = random.Next(2);
                if (stärke_2 > m2.GetTrainer().GetErfahrung())
                {
                    abweichung = -abweichung;
                }
                stärke_2 = Math.Max(1, Math.Min(10, stärke_2 + abweichung));

                // Wähle zufällig einen Spieler aus dieser Mannschaft, 
                // berechne den Torschuss und gib dem Torwart der anderen 
                // Mannschaft die Möglichkeit, diesen Ball zu halten.
                int schuetze = random.Next(10);
                if ((random.Next((int)Math.Round(stärke_1 + stärke_2)) - stärke_1) <= 0)
                {
                    Spieler s = m1.GetKader()[schuetze];
                    Torwart t = m2.GetTorwart();
                    int torschuss = s.SchiesstAufTor();
                    // hält er den Schuss?
                    bool tor = !t.HältDenSchuss(torschuss);

                    Console.WriteLine();
                    Console.WriteLine(zeit + ".Minute: ");
                    Console.WriteLine(" Chance fuer " + m1.GetName() + " ...");
                    Console.WriteLine(" " + s.GetName() + " zieht ab");
                    if (tor)
                    {
                        _punkteHeim++;
                        s.AddTor();
                        Console.WriteLine(" TOR!!! " + _punkteHeim + ":" + _punkteGast + " " + s.GetName() + "(" + s.GetTore() + ")");
                    }
                    else
                    {
                        Console.WriteLine(" " + m2.GetTorwart().GetName() + " pariert glanzvoll.");
                    }
                }
                else
                {
                    Spieler s = m2.GetKader()[schuetze];
                    Torwart t = m1.GetTorwart();
                    int torschuss = s.SchiesstAufTor();
                    bool tor = !t.HältDenSchuss(torschuss);

                    Console.WriteLine();
                    Console.WriteLine(zeit + ".Minute: ");
                    Console.WriteLine(" Chance fuer " + m2.GetName() + " ...");
                    Console.WriteLine(" " + s.GetName() + " zieht ab");

                    if (tor)
                    {
                        _punkteGast++;
                        s.AddTor();
                        Console.WriteLine(" TOR!!! " + _punkteHeim + ":" + _punkteGast + " " + s.GetName() + "(" + s.GetTore() + ")");
                    }
                    else
                    {
                        Console.WriteLine(" " + m1.GetTorwart().GetName() + " pariert glanzvoll.");
                    }
                }
            }
        }

    }
}