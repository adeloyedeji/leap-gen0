using MyProject.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services
{
    public class ByWorkplace : IPelumi
    { 
        public void KnowMe()
        {
            Console.WriteLine("Wragby");
        }
    }

    public class LastTwoYearWorkPlace : IPelumi
    {
        public void KnowMe()
        {
            Console.WriteLine("TechAdvance");
        }
    }

    public class LastOneYearWorkPlace : IPelumi
    {
        public void KnowMe()
        {
            Console.WriteLine("AiiBurtel");
        }
    }
    public class IntendingWorkPlace : IPelumi
    {
        public void KnowMe()
        {
            Console.WriteLine("Microsoft");
        }
    }
}
