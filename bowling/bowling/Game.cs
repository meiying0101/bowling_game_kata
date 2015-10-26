using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowling
{
    class Game
    {
        int[] round = new int[22];
        int number=0;
        int total = 0;
        internal void SetPins(int p)
        {
            round[number++]=p;
        }

        internal int GetFinalScore()
        {
            for (int i = 0; i < round.Count();i+=1)
            {
              /*  if(i%2==1 && round[i-1]+round[i]==10)
                {

                }*/
                total += round[i];
            }
            return total;    
        }
    }
}
