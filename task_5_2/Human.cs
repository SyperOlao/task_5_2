using System;
using System.Collections.Generic;
using System.Text;

namespace task_5_2
{
    public abstract class Human
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public int Weight { get; set; }
        public int Accumulation { get { return accumulation; } }
        protected int accumulation;

        public Human(string name)
        {
            Name = name;
        }

        abstract public void Income();
    }
}
