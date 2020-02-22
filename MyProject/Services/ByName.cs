using MyProject.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services
{
    public class ByName : IPelumi
    {
        public void KnowMe()
        {
            Console.WriteLine("Pelumi Sapphire Adebayo");
        }
    }
}
