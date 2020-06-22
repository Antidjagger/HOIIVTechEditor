using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyEditor
{
    //Класс для названия и изображения технологий
    class TechLocalisation
    {
        //Эти 3 списка синхронизируются и отвечают за перевод к каждому языку. По умолчанию стоит русский и английский
        private List<string> localisationList;
        private List<string> techNameL;
        private List<string> techDescL;

        //дефолтное изображение - проработать
        private string wayToTechImage;
        private string wayToTechImageSmall;
        private string wayToTechImageTiny;

        TechLocalisation()
        {
            LocalisationList.Add("English");
            LocalisationList.Add("Russian");
            TechNameL.Add("Name on english");
            TechNameL.Add("Название на русском");
            TechDescL.Add("RUS_Desc");
            TechDescL.Add("ENG_Desc");
        }
        TechLocalisation(string TechName)
        {
            LocalisationList.Add("English");
            LocalisationList.Add("Russian");
            TechNameL.Add(TechName + "_ENG");
            TechNameL.Add(TechName + "_RUS");
            TechDescL.Add(TechName + "_Desc");
            TechDescL.Add(TechName + "_Desc");
        }

        public List<string> LocalisationList { get => localisationList; set => localisationList = value; }
        public List<string> TechNameL { get => techNameL; set => techNameL = value; }
        public List<string> TechDescL { get => techDescL; set => techDescL = value; }
        public string WayToTechImage { get => wayToTechImage; set => wayToTechImage = value; }
        public string WayToTechImageSmall { get => wayToTechImageSmall; set => wayToTechImageSmall = value; }
        public string WayToTechImageTiny { get => wayToTechImageTiny; set => wayToTechImageTiny = value; }
    }

}
