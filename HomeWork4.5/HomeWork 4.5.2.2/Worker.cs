using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    public abstract class Worker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int WorkDay { get; set; }
        public Worker(string name)
        {
            Name = name;
        }
        public void Call()
        {

        }
        public void WriteCode()
        {

        }
        public void Relax()
        {

        }
        public abstract void FillWorkDay();

    }
}
