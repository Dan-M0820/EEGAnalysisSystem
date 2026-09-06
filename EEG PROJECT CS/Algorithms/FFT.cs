using System;
using System.Numerics;

namespace EEGAnalysisSystem.Algorithms
{
    public static class FFT
    {
        // Simple (inefficient) real-input FFT via DFT. Use for small buffers or prototyping.
        public static double[] RealFft(double[] input)
        {
            if (input == null) return Array.Empty<double>();
            int n = input.Length;
            var spectrum = new double[n/2];
            for (int k = 0; k < n/2; k++)
            {
                Complex sum = Complex.Zero;
                for (int t = 0; t < n; t++)
                {
                    var angle = -2.0 * Math.PI * t * k / n;
                    sum += new Complex(input[t], 0) * Complex.Exp(new Complex(0, angle));
                }
                spectrum[k] = sum.Magnitude;
            }
            return spectrum;
        }
    }
}
