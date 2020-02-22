using MyProject.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services
{
    public class ByAge : IPelumi
    {
        public void KnowMe()
        {
            Console.WriteLine("Im am 24 yaers old");
        }
    }
}
