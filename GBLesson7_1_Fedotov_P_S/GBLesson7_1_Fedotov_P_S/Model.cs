using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBLesson7_1_Fedotov_P_S
{
    class Model
    {
        int endGame;
        bool f;
        bool gameower = false;
        int number;
        int steps;
        public int Steps => steps;
        public int Number => number;
        public int EndGame => endGame;
        public bool Check => f;
        public bool CheckGameower => gameower;
        List<char> StepsAction = new List<char>();
        public Model(int endGame)
        {
            Reset();
            f = false;
            this.endGame = endGame;
        }
        public void Add()
        {
            if (f || gameower) return;
            if (StepsAction.Count > 20) FullSteps();
            StepsAction.Add('A');
            number++;
            steps++;
            f = number == endGame;
            gameower = number > endGame;
        }
        public void Mult()
        {
            if (f || gameower) return;
            if (StepsAction.Count > 20) FullSteps();
            StepsAction.Add('M');
            number *= 2;
            steps++;
            f = number == endGame;
            gameower = number > endGame;
        }
        public void Reset()
        {
            number = 0;
            steps = 0;
            gameower = false;
        }

        internal void BackStep()
        {
            if(StepsAction.Count>0)
            {
                steps--;
                if(StepsAction[StepsAction.Count - 1] == 'A') number--;
                if(StepsAction[StepsAction.Count - 1] == 'M') number /= 2;
                StepsAction.RemoveRange(StepsAction.Count - 1, 1);
            }
        }
        void FullSteps()
        {
            List<char> tempSteps = new List<char>();
            for(int i=1;i< StepsAction.Count;i++)
            {
                tempSteps.Add(StepsAction[i]);
            }
            StepsAction = tempSteps;
        }
    }
}
