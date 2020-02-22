using DiTutorials.Libs.Contracts;
using MyProject.Contract;

namespace DiTutorials.Libs.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public void Movement(IMovement movement)
        {
            movement.Move();
        }

        public void Pelumi(IPelumi pelumi)
        {
            pelumi.KnowMe();
        }
    }
}
