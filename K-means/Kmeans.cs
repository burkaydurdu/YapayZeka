using K_means;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yapay
{
    class Kmeans
    {
        private List<Point> points;
        private int classCount;
        private List<Point> centerPoints;
        private List<KmeanObject> groupPoints;
        public Kmeans(List<Point> points, List<Point> centerPoints)
        {
            this.points = points;
            this.centerPoints = centerPoints;
            groupPoints = new List<KmeanObject>();
        }      
        public List<Point> start()
        {
            divide(10);
            return centerPoints;
        }
        private double twoPointDistance(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
        private Point centerOfGravity(int groupInf)
        {
            int x = 0;
            int y = 0;
            int elementCount = 0;
            for(int i = 0; i< groupPoints.Count; i++)
            {
                if (groupPoints[i].Group == groupInf)
                {
                    x += groupPoints[i].Point.X;
                    y += groupPoints[i].Point.Y;
                    elementCount++;
                }
            }
            return new Point(x / elementCount, y / elementCount);
        }
        private void divide(int deep)
        {
            if (deep == 0) return;
            if (groupPoints.Count != 0) groupPoints.Clear();
            int rec = 0;
            int ind = -1;
            for(int i = 0; i < points.Count; i++)
            {
                double temp = 10000;
                for (int j = 0; j < centerPoints.Count; j++)
                {
                    double dist = twoPointDistance(points[i], centerPoints[j]);
                    if (temp > dist) {
                        temp = dist;
                        ind = j;
                    }
                }
               
                groupPoints.Add(new KmeanObject(points[i], ind));
            }
            for (int i = 0; i < centerPoints.Count; i++)
            {
                Point last = centerPoints[i];
                Point current =  centerOfGravity(i);
                double dist = twoPointDistance(last, current);
                if (dist > 1)
                {
                    centerPoints[i] = current;
                    rec++;
                }
            }
            if(rec ==  centerPoints.Count) divide(--deep);
        }
    }
}
