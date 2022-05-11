using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class GuessingGameModel
    {
        private static int randomNumber;
        private Random random = new Random();

        public GuessingGameModel()
        {
            randomNumber = random.Next(1, 101);
        }
        public int GetNumber()
        {
            return randomNumber;
        }

    }
}
