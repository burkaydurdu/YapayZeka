using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_means
{
    class KmeanObject
    {

        private Point point;
        private int group;
        public KmeanObject(Point point, int group)
        {
            this.point = point;
            this.group = group;
        }

        public Point Point { get => point; set => point = value; }
        public int Group { get => group; set => group = value; }
    }
}
