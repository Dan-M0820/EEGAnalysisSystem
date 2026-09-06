using System.Collections.Generic;

namespace EEGAnalysisSystem.Models
{
    public class EEGChannel
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public List<double> Samples { get; set; } = new List<double>();
    }
}
