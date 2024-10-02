using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fussball_Simulator
{
    public class Person
    {
        public static Random random = new Random();
        protected string _name;
        protected int _alter;
        public Person(string name, int alter)
        {
            _name = name;
            _alter = alter;
        }

        public int GetAlter()
        {
            return _alter;
        }

        public string GetName()
        { return _name; }
    }
}