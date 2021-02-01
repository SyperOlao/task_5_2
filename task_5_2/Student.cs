using System;
using System.Collections.Generic;
using System.Text;

namespace task_5_2
{
    class Student : Human
    {
        public int Cours { get; set; }
        public int Group { get; set; }
        private int[] marks;
        private int scholarship;
        public byte AmountOfSubject { set { marks = new int[value]; }}

        public int GetScholarship()
        {
            return scholarship; 
        }


        public Student(string name, int cours) : base(name)
        {
            Cours = cours;
            AmountOfSubject = 3;
            SetRandomMarks();
        }

        public void SetRandomMarks()
        {
            Random random = new Random();
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = random.Next(2,5);
            }
        }

        public void SetMark(int mark, int numberOfSubj)
        {
            marks[numberOfSubj] = mark; 
        }

        override public void Income()
        {
            AmountScholarship(); 
            accumulation += scholarship;
        }

        public void AmountScholarship()
        {
            int minMark = 5;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < minMark) minMark = marks[i];
            }
            switch (minMark)
            {
                case 5: scholarship = 3500;
                    break;
                case 4: scholarship = 2500;
                    break;
                default: scholarship = 0;
                    break;
            }
        }

    }
}
