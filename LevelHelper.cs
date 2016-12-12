using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management
{
    
    public static class LevelHelper
    {

        private static Dictionary<int, Bound[]> law;

        static LevelHelper()
        {
            double[][] dict = new double[5][];
            dict[0] = new double[] { 1.0 / 3.0, 1.0 / 3.0, 1.0 / 6.0, 1.0 / 12.0, 1.0 / 12.0 };
            dict[1] = new double[] { 1.0 / 4.0, 1.0 / 3.0, 1.0 / 4.0, 1.0 / 12.0, 1.0 / 12.0 };
            dict[2] = new double[] { 1.0 / 12.0, 1.0 / 4.0, 1.0 / 3.0, 1.0 / 4.0, 1.0 / 12.0 };
            dict[3] = new double[] { 1.0 / 12.0, 1.0 / 12.0, 1.0 / 4.0, 1.0 / 3.0, 1.0 / 4.0 };
            dict[4] = new double[] { 1.0 / 12.0, 1.0 / 12.0, 1.0 / 6.0, 1.0 / 3.0, 1.0 / 3.0 };

            law = new Dictionary<int, Bound[]>();
            setLaw(dict);
        }
        public static Dictionary<int, Bound[]> Law()
        {
            //LevelHelper();
            return law;
        }

        private static Bound[] getLevelBounds(double[] data)
        {
            var bounds = new Bound[5];
            var curr = 0.0;
            for (int i = 0; i < bounds.Length; i++)
            {
                bounds[i] = new Bound(curr, curr + data[i]);
                curr = bounds[i].Max;
            }
            bounds[4].Max = 1.0;

            return bounds;
        }
        private static void setLaw(double[][] dict)
        {
            for (int i = 0; i < dict.Length; i++)
            {
                law.Add(i + 1, getLevelBounds(dict[i]));
            }
        }
    }
}
