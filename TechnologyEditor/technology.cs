using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyEditor
{
    class Technology
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
        //Если открывает юнит
        private bool isEnableSubunits;

        //Список открываемой экипировки 
        private string[] enable_equipments;
        //Список открываемых юнитовыва
        private string[] enable_subunits;
        //Стоимость исследования
        private float researchCost;

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

        //Желание ИИ 
        private AiWillDo ai;

        //Эффекты по завершении исследования
        private OnResearchComplete researchCompleteEffects;


        public string TechName { get => techName; set => techName = value; }
        public bool IsDoctrine { get => isDoctrine; set => isDoctrine = value; }
        public bool IsEnableBuildings { get => isEnableBuildings; set => isEnableBuildings = value; }
        public bool IsEnableEquipment { get => isEnableEquipment; set => isEnableEquipment = value; }
        public string[] Enable_equipments { get => enable_equipments; set => enable_equipments = value; }
        public bool IsEnableSubunits { get => isEnableSubunits; set => isEnableSubunits = value; }
        public string[] Enable_subunits { get => enable_subunits; set => enable_subunits = value; }
        public float ResearchCost { get => researchCost; set => researchCost = value; }
        internal Leads_to_tech[] Path { get => path; set => path = value; }
        public string[] Sub_technologiesName { get => sub_technologiesName; set => sub_technologiesName = value; }
        public string[] TechXOR { get => techXOR; set => techXOR = value; }
        public int Start_year { get => start_year; set => start_year = value; }
        public string FolderName { get => folderName; set => folderName = value; }
        internal Position OnTreePos { get => onTreePos; set => onTreePos = value; }
        internal AiWillDo Ai { get => ai; set => ai = value; }
        internal OnResearchComplete ResearchCompleteEffects { get => researchCompleteEffects; set => researchCompleteEffects = value; }
    }




}
