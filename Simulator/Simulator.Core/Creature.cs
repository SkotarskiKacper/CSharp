using System;
using System.Collections.Generic;
using System.Text;

namespace Simulator.Core
{
    internal class Creature
    {
        public string Name = "Unknown";
        public int Level;

        public Creature()
        {
            return;
        }

        public Creature(string name, int level = 1)
        {
            Name = name;
            Level = level;

            return;
        }

        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {Name}, my level is {Level}.");
            return;
        }

    }




}
