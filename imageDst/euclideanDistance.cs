using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imageDst
{
    public class euclideanDistance : IDistance
    {
        public double Between(int[] pixels1, int[] pixels2)
        {
            if (pixels1.Length != pixels2.Length)
            {
                throw new ArgumentException("Inconsistent image sizes.");
            }
            var length = pixels1.Length;
            var distance = 0;
            for (int i = 0; i < length; i++)
            {
                //distance += (int)Math.Sqrt((Math.Pow((int)(pixels1[i]), 2.0)
                 //   - Math.Pow((int)(pixels2[i]), 2.0)));
                distance += (int) Math.Sqrt(Math.Pow(pixels1[i] - pixels2[i], 2) + Math.Pow(pixels1[i] - pixels2[i], 2));
            }
            return distance;
        }
    }
}
