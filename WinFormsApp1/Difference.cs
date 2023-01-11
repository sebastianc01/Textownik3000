using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Difference
    {
        long index1;
        long size1;
        long index2;
        long size2;
        bool difference1;
        public Difference(long index1, long size1, long index2, long size2, bool difference1)
        {
            this.index1 = index1;
            this.size1 = size1;
            this.index2 = index2;
            this.size2 = size2;
            this.difference1 = difference1;
        }
        public long getIndex1()
        {
            return index1;
        }
        public long getIndex2()
        {
            return index2;
        }
        public long getSize2()
        {
            return size2;
        }
        public long getSize1()
        {
            return size1;
        }
        public bool getDifference1()
        {
            return difference1;
        }
        public void setDifference1(bool choice)
        {
            difference1 = choice;
        }
    }
}
