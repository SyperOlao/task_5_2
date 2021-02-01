using System;
using System.Collections.Generic;
using System.Text;

namespace task_5_2
{
    class Serviceman : Human
    {
        public string Rank { get; set; }

        public Serviceman(string name, string rank) : base(name)
        {
            Rank = rank; 
        }
        public int Salary { get; set; }
        private int allowance;

        public void SetAllowance()
        {
            if (Rank.Equals("Капрал")) allowance = 20000;
        }

        public int GetAllowance()
        {
            return allowance;
        }

        override public void Income()
        {
            SetAllowance();
            accumulation += Salary + allowance;
        }

    }
}
