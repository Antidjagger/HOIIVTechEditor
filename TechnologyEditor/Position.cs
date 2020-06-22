using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyEditor
{
    //Класс для позиционирования иконки технологий на дереве
    class Position
    {
        private int y;
        private int x;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
