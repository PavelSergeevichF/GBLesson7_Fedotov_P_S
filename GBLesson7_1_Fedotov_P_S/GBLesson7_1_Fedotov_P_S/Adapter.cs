using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBLesson7_1_Fedotov_P_S
{
    class Adapter
    {
        Model model;
        IView view;
        IInfo info;

        public Adapter(Model model, IView view, IInfo Info)
        {
            this.model = model;
            this.view = view;
            this.info = Info;
            Reset();
            ShowStartInfo();
        }
        public void AddClick()
        {
            model.Add();
            view.Number = $"{model.Number}";
            ShowInfo();
            if (model.CheckGameower) ShowGameOwer(); 
        }

        public void GeminationClick()
        {
            model.Mult();
            view.Number = $"{model.Number}";
            ShowInfo();
            if (model.CheckGameower) ShowGameOwer();
        }
        public void Reset()
        {
            model.Reset();
            view.Number = $"{model.Number}";
            info.Info = "Результат";
        }
        public void BackStep()
        {
            model.BackStep();
            view.Number = $"{model.Number}";
            ShowInfo();
        }
        void ShowStartInfo()
        {
            info.Task = $"Вы должны набрать {model.EndGame}";
        }
        void ShowInfo()
        {
            info.Info = $"Шаг {model.Steps}";
        }
        void ShowGameOwer()
        {
            info.Info = "Результат больше чем нужно!";
            info.Task = "Нажмите сброс.";
        }
    }
}
