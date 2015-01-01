using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_in_Grading_App
{
    class Result
    {
        public double physics;
        public double chemistry;
        public double math;
        public double avg;
        

        public double Avarage()
        {
              return avg = (physics + chemistry + math)/3;
        }

        public string GetGrade()
        {
            double avarageValu = Avarage();
            if (avarageValu >= 80)
            {
                return "A+";
            }
            else if (avarageValu>=70)
            {
                return "A";
            }
            else
            {
                return "F";
            }
           
        }
    }
}
