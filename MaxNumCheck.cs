using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPro13
{
    public class MaxNumCheck
    {
        public int Computemax(int firstnumber, int secondnumber, int thirdnumber)
        {
            if (firstnumber.CompareTo(secondnumber) > 0 && firstnumber.CompareTo(thirdnumber) > 0)
            {
                return firstnumber;
            }
            if (secondnumber.CompareTo(firstnumber) > 0 && secondnumber.CompareTo(thirdnumber) > 0)
            {
                return secondnumber;
            }
            else
            {
                return thirdnumber;
            }
        }
    }
}
