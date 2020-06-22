using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyEditor
{
    class OnResearchComplete
    {
        //Условия выполнения скрытых эффектов
        private Limit[] limit;
        //Список скрытых эффектов
        private HiddenEffect[] HiddenEffects;
        //Кастомный ???
        private string[] custom_effect_tooltip;

        //Свойства
        public string[] Custom_effect_tooltip { get => custom_effect_tooltip; set => custom_effect_tooltip = value; }
        internal Limit[] Limit { get => limit; set => limit = value; }
        internal HiddenEffect[] HiddenEffects1 { get => HiddenEffects; set => HiddenEffects = value; }
    }


    //Ограничения
    class Limit
    {
        //Логическое НЕ
        private bool isNot;
        //Если условие - true/false
        private bool isBool;
        //Условие
        private string modifier;
        //Значение
        private string modifierValue;

        public bool IsNot { get => isNot; set => isNot = value; }
        public bool IsBool { get => isBool; set => isBool = value; }
        public string Modifier { get => modifier; set => modifier = value; }
        public string ModifierValue { get => modifierValue; set => modifierValue = value; }
    }

    class HiddenEffect
    {
        private Limit limit;
        private string oob_Name;

        public string Oob_Name { get => oob_Name; set => oob_Name = value; }
        internal Limit Limit { get => limit; set => limit = value; }
    }
}
