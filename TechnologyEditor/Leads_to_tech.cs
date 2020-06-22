﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyEditor
{
    //Класс для сохранения пути к следующей технологии
    class Leads_to_tech
    {
        //Название следующей технологии
        private string techName;
        private float researchCoeff;

        public string TechName { get => techName; set => techName = value; }
        public float ResearchCoeff { get => researchCoeff; set => researchCoeff = value; }
    }
}
