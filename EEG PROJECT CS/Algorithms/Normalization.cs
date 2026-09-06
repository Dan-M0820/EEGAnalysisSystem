using System.Linq;

namespace EEGAnalysisSystem.Algorithms
{
    public static class Normalization
    {
        public static double[] ZScore(double[] data)
        {
            if (data == null || data.Length == 0) return data;
            var mean = data.Average();
            var varSum = data.Select(d => (d - mean) * (d - mean)).Sum();
            var std = System.Math.Sqrt(varSum / data.Length);
            if (std == 0) return data.Select(d => 0.0).ToArray();
            return data.Select(d => (d - mean) / std).ToArray();
        }
    }
}
