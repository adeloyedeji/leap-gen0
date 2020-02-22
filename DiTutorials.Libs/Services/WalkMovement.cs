using DiTutorials.Libs.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiTutorials.Libs.Services
{
    public class WalkMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("I am walking");
        }
    }

    public class FlyMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("I am flying");
        }
    }


    public class RunMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("I am running");
        }
    }
}
