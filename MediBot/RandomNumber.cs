using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediBot
{
    public static class RandomNumber
    {
        static Random random = new Random();
        static public int randomNumber = random.Next(1000, 9999);
    }
}
