using System.Linq;
using EEGAnalysisSystem.Models;

namespace EEGAnalysisSystem.Services
{
    public class BandPowerAnalyzer
    {
        // Compute simple band power by summing magnitudes in a frequency range
        public double ComputeBandPower(double[] spectrum, double sampleRate, double lowHz, double highHz)
        {
            if (spectrum == null || spectrum.Length == 0) return 0.0;
            var freqPerBin = sampleRate / (spectrum.Length * 2);
            var start = (int)(lowHz / freqPerBin);
            var end = (int)(highHz / freqPerBin);
            start = System.Math.Max(0, start);
            end = System.Math.Min(spectrum.Length - 1, end);
            return spectrum.Skip(start).Take(end - start + 1).Sum();
        }
    }
}
