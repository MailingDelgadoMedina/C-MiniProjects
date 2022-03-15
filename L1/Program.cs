using System;
namespace L1
{

class Program
{
    static void Main(string[] args)
    {
/*
Here you can add your code
*/
            bool isSunny = false;
            string wear = "Wear sunglasses!";
            string dontWear = "You don't need to wear sunglasses.";

            bool atBeach = true;
            string sunblock = "Sunblock is a good idea.";
            string noSunblock = "Sunblock isn't needed.";

            bool goTomorrow = true;
            string going = "Awesome! Glad you don't mind clouds!";
            string nextTime = "No worries! Hopefully next time we will have some sun!";

            if (isSunny)
            {
                Console.WriteLine(wear);
                if (atBeach)
                {
                Console.WriteLine(sunblock);
                }
                else
                {
                Console.WriteLine(noSunblock);
                }
            }
            else
            {
                Console.WriteLine(dontWear);
                if (goTomorrow)
                {
                Console.WriteLine(going);
                }
                else
                {
                Console.WriteLine(nextTime);
                }
            }





    }
}

}






