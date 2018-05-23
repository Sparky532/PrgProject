using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //Animals
     delegate int AnimalRandom();

    delegate string DetermineMateState(int age, string gender);

    delegate double DetermineEatingTime(double baseEatingTime,int age);


}
