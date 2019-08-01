using System;

namespace PassTheCat
{
    class Program
    {
        Robot robot = new Robot();
        Human human = new Human();
        Bear bear = new Bear();
        Cat lerroy = new Cat()
        {
            Name = "Lerroy",
            Calories = 200
        };

        delegate void PassTheCat(string name, int calories);

        


        static void Main(string[] args)
        {
            PassTheCat DelRobot = new Pass

            
        }
    }
}
