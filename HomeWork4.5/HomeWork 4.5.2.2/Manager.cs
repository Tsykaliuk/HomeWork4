using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    internal class Manager : Worker
    {
        private Random random = new Random();
        public Manager(string position) : base(position)
        {
            Position = "Manager";
        }
        public override void FillWorkDay()
        {
            int callCounter = random.Next(1, 11);
            for (int i = 0; i < callCounter; i++) 
            {
                Call();
            }

            Relax();

            callCounter = random.Next(1, 6);
            for (int i = 0; i < callCounter; i++)
            {
                Call();
            }
        }
    }
}
