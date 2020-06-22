using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyEditor
{
    class Modifiers
    {
        public Dictionary<long, string> modifiers;
        Modifiers()
        {

        }
    }

    class AiModifier
    {
        //Исходный фактор
        private double factor;

        //Следующие условия выбираются по принципу "Только одно из", все остальные - обнуляются
        //После определённой даты
        private string dateAfter;
        //Если страна-мажор
        private bool isMajor;

        public double Factor { get => factor; set => factor = value; }
        public string DateAfter 
        { 
            get => dateAfter; 
            set {
                //Нужно записать проверку на соответствие формату даты от пароходов с вызовом кода ошибки при случае
                dateAfter = value;    
            } 
        }
        public bool IsMajor { get => isMajor; set => isMajor = value; }
    }
}
