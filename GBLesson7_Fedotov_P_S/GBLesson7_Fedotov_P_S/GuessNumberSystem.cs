using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBLesson7_Fedotov_P_S
{
    class GuessNumberSystem
    {
        int num=0;
        int tryUsor = 0;
        public GuessNumberSystem()
        {
            GetNum();
        }
        Random r = new Random();
        void GetNum()
        {
            num = r.Next(1, 100);
        }
        public string GetNumUser(string  str)
        {
            int n;
            if (!int.TryParse(str,out n))
            {
                return "Вводить можно только числа";
            }
            
            if (num == n) { return $"Вы угадали с {tryUsor++} попытки."; tryUsor = 0; GetNum(); }
            else 
            {
                tryUsor++;
                if (tryUsor == 50) { return "Может стоит взять паузу?"; }
                if (n > num) { return $"Число меньше {n}"; }
                else return $"Число больше {n}";
            }
        }
    }
}
