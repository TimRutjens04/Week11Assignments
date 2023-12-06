using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    internal class Lottery
    {
        int[] ballsDrawn;
        int lastBallDrawnIndex;
        List<int> possibleNumbers;
        Random random;

        public Lottery(int maxValue, int nrOfBalls) 
        {
            ballsDrawn = new int[nrOfBalls];
            lastBallDrawnIndex = 0;
            possibleNumbers = new List<int>();
            for (int i = 0; i < nrOfBalls; i++) 
            {
                possibleNumbers.Add(i);
            }
            random = new Random();
        }

        public int DrawNextNumber() 
        {
            int newDraw = possibleNumbers[random.Next(possibleNumbers.Count)];
            possibleNumbers.Remove(newDraw);
            ballsDrawn[lastBallDrawnIndex] = newDraw;
            lastBallDrawnIndex++;
            return newDraw;
        }

        public int[] DrawAllNumbers() 
        {
            while (ballsDrawn.Contains(0)) 
            {
                _ = DrawNextNumber();
            }
            return ballsDrawn;
        }




    }
}
