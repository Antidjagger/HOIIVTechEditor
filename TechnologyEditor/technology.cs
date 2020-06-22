using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyEditor
{
    class technology
    {
        //Название технологии
        private string techName;
        //Модификаторы уровня страны
        public Dictionary<long, string> countrylevelModifiers;
        //Если доктрина
        private bool isDoctrine;
        //Если открывает постройку
        private bool isEnableBuildings;
        //Если открывает экипировку
        private bool isEnableEquipment;
        //Список открываемой экипировки
        private string []enable_equipments;
        //Если открывает юнит
        private bool isEnableSubunits;
        //Список открываемых юнитов
        private string enable_subunits;
        //Стоимость исследования
        private float ResearchCost;
        //Следующие технологии
        private Leads_to_tech[] path;
        //Саб-технологии
        private string[] sub_technologiesName;
        //Взаимоисключающие технологии
        private string[] techXOR;
        //Год, с которого перестают давать дебафф на стоимость
        private int start_year;
        //Папка технологии
        private string folderName;
        //Позиция на дереве
        private Position onTreePos;
    }

    class Leads_to_tech
    {
        private string techName;
        private float researchCoeff;
    }

    class Position
    {
        public int x, y;
    }
}
