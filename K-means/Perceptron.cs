using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yapay
{
    class Perceptron
    {
        private int attirubeCount;
        private int classCount;
        private int betweenW;
        private List<Object> allInfo;
        private double uniqueValue;
        private double[] w;
        public Perceptron(double uniqueValue, int betweenW, int attirubeCount, int classCount, List<Object> allInfo)
        {
            this.uniqueValue = uniqueValue;
            this.betweenW = betweenW;
            this.attirubeCount = attirubeCount;
            this.classCount = classCount;
            this.allInfo = allInfo;
            w = random_W();
        }

        public double [] getW()
        {
            return w;
        }
        private double[] random_W()
        {
            double[] w = new double[attirubeCount];
            Random random = new Random();
            for (int i = 0; i < attirubeCount; i++)
            {
                w[i] = random.Next(betweenW);
            }
            return w;
        }
        private void new_W(Object o, double cur)
        {
            double temp = uniqueValue * (o.getGroup() - cur);
            double [] tempArray = mulMatrix(o.getInfo(), temp);
            w = sumMatrix(tempArray, w);
        } 

        public void optimumW(int deep)
        {
            if (deep == 0) return;
            for (int i = 0; i < allInfo.Count; i++)
            {
                double net = mulMatrix(w, allInfo[i].getInfo());
                double group = sgn(net);
                if(group == allInfo[i].getGroup())
                {
                    allInfo[i].setVerified(true);
                } else
                {
                    allInfo[i].setVerified(false);
                    new_W(allInfo[i], group);
                }
            }

            for (int i = 0; i < allInfo.Count; i++)
            {
                if (allInfo[i].getVerifed() == false) optimumW(deep--);
            }
        }
        private double mulMatrix(double[] mat1, double[] mat2)
        {
            double result = 0;
            for (int i = 0; i < mat1.Length; i++)
            {
                result += mat1[i] * mat2[i];
            }
            return result;
        }
        private double[] mulMatrix(double[] mat1, double value)
        {
            for (int i = 0; i < mat1.Length; i++)
            {
                mat1[i] *= value;
            }
            return mat1;
        }
        private double[] sumMatrix(double[] mat1, double[] mat2) {
            for (int i = 0; i < mat1.Length; i++)
            {
                mat1[i] += mat2[i];
            }
            return mat1;
        }
        private double sgn(double v)
        {
            return v > 0 ? 1 : -1;
        }
    }
}
