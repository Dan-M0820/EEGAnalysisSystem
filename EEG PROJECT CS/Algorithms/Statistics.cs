using System.Linq;

namespace EEGAnalysisSystem.Algorithms
{
    public static class Statistics
    {
        public static double Mean(double[] data) => data == null || data.Length == 0 ? 0 : data.Average();
        public static double StdDev(double[] data)
        {
            if (data == null || data.Length == 0) return 0;
            var mean = Mean(data);
            var varSum = data.Select(d => (d - mean) * (d - mean)).Sum();
            return System.Math.Sqrt(varSum / data.Length);
        }
    }
}
