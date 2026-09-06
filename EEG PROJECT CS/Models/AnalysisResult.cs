using System.Collections.Generic;

namespace EEGAnalysisSystem.Models
{
    public class AnalysisResult
    {
        public Dictionary<string, double> BandPowers { get; set; } = new Dictionary<string, double>();
        public string Summary { get; set; }
    }
}
