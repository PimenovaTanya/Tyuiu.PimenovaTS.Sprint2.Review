using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PimenovaTS.Sprint2.TaskReview.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (x >= 0)
            {
                if (y <= Math.Pow(x,2) && y <= 2 - x)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
                return res;
            }
            else
            {
                if (y <= Math.Pow(x, 2) && y >= 2 - x)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
                return res;
            }
        }
    }
}
