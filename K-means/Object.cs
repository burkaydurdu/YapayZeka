using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yapay
{
    class Object
    {
        private double group;
        private double [] info;
        private Boolean verified;
        public Object(double group, double [] info)
        {
            this.group = group;
            this.info = info;
            verified = false;
        }
        
        public Boolean getVerifed()
        {
            return verified;
        }
        public void setVerified(Boolean verified)
        {
            this.verified = verified;
        }
        public double getGroup()
        {
            return group;
        }
        public void setGrroup(double group)
        {
            this.group = group;
        }
        public double [] getInfo()
        {
            return info;
        }
        public void setInfo(double [] info)
        {
            this.info = info;
        }

    }
}
