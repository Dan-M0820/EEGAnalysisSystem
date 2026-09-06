using System.Linq;

namespace EEGAnalysisSystem.Algorithms
{
    public static class Filtering
    {
        // Very basic moving-average low-pass filter
        public static double[] MovingAverage(double[] data, int windowSize)
        {
            if (data == null || data.Length == 0) return data;
            if (windowSize <= 1) return data;
            var outArr = new double[data.Length];
            double sum = 0;
            int w = windowSize;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
                if (i >= w) sum -= data[i - w];
                outArr[i] = sum / System.Math.Min(w, i + 1);
            }
            return outArr;
        }
    }
}
