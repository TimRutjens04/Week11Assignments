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
        public bool IsValid;

        public Lottery(int maxValue, int nrOfBalls) 
        {

            if (maxValue < nrOfBalls) 
            {
                IsValid = false;
                return;
            }

            IsValid = true;
            ballsDrawn = new int[nrOfBalls];
            lastBallDrawnIndex = 0;
            possibleNumbers = new List<int>();
            for (int i = 0; i < maxValue; i++) 
            {
                possibleNumbers.Add(i);
            }
            random = new Random();
        }

        public int DrawNextNumber()
        {
            if (possibleNumbers.Count > 0)
            {
                int randomIndex = random.Next(possibleNumbers.Count);
                int newDraw = possibleNumbers[randomIndex];
                possibleNumbers.RemoveAt(randomIndex);
                ballsDrawn[lastBallDrawnIndex] = newDraw;
                lastBallDrawnIndex++;
                return newDraw;
            }
            else { return -1; }
           
           
             
           
        }


        public int[] DrawAllNumbers()
        {
            for (int i = 0; i < ballsDrawn.Length; i++)
            {
                DrawNextNumber();
            }
            return ballsDrawn;
        }





    }
}
