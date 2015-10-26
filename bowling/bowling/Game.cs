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
            for (int i = 0; i < 18;i+=1)
            {
                if( round[i]==10)
                {
                    int time = 2;
                    int tmp = i;
                    while(time>0)
                    {                   
                        if(round[tmp+1]!=0)
                        {
                            total += round[tmp + 1];
                            tmp += 1;
                            time-=1;
                        }
                        else
                        {
                            tmp += 1;
                        }
                    }
                }
                else if(i%2==1 && round[i-1]+round[i]==10)
                {
                    int time = 1;
                    int tmp = i;
                    while (time > 0)
                    {
                        if (round[tmp + 1] != 0)
                        {
                            total += round[tmp + 1];
                            tmp += 1;
                            time -= 1;
                        }
                        else
                        {
                            tmp += 1;
                        }
                    }
                }
                total += round[i];
            }
            for (int i = 18; i < round.Count();i++ )
            {
                total += round[i];
            }
                return total;    
        }
    }
}
