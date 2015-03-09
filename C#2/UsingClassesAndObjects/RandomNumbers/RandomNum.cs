using System;
using System.Linq;
class RandomNum
{
    static void Main()
    {
        Random generator = new Random();
        for (int i = 0; i < 10; i++)
	    {
            Console.Write("{0}, ", generator.Next(100, 200));
		}
        
    }
}
