using System;

namespace PassTheCat
{
    class Program
    {
        

        delegate void PassTheCat(string name, int calories);

        


        static void Main(string[] args)
        {

            Robot robot = new Robot();
            Human human = new Human();
            Bear bear = new Bear();
            Cat lerroy = new Cat()
            {
                Name = "Lerroy",
                Calories = 200
            };


            PassTheCat delHuman = new PassTheCat(DoSomethingWithCat);


            
        }
        public static void DoSomethingWithCat(Delegate passTheCat)
        {
            Console.WriteLine("the human pets " + );
        }
    }
}
