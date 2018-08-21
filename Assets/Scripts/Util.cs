using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Util
{
    private static Random random = new Random();

    public Util()
    {
    }

    public static int getRandom(int min, int max)
    {
        return random.Next(min, max);
    }
}
