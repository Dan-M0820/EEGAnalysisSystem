using System;
using EEGAnalysisSystem.Models;
using EEGAnalysisSystem.Algorithms;

namespace EEGAnalysisSystem.Services
{
    public class FFTAnalyzer
    {
        public double[] ComputeChannelSpectrum(EEGChannel channel)
        {
            if (channel == null) throw new ArgumentNullException(nameof(channel));
            return FFT.RealFft(channel.Samples.ToArray());
        }
    }
}
