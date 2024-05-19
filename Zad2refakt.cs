using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_PREIMENOVANJE
{
    internal class Zad2refakt
    {
        class Average
        {
            List<double> CreateAverageList(List<double[]> arrays)
            {
                List<double> averages = new List<double>();

                foreach (double[] array in arrays)
                {



                    averages.Add(CalculateAverage(array));
                }
                return averages;
            }
            public double CalculateAverage(double[] array)
            {
                double sum = 0; ;

                for (int i = 0; i < array.Length; i++) sum += array[i];
                return sum / array.Length;
            }
        }
    }
}
