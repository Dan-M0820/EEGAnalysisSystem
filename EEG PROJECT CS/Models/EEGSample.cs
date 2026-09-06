using System;
using System.Collections.Generic;

namespace EEGAnalysisSystem.Models
{
    public class EEGSample
    {
        public DateTime Timestamp { get; set; }
        public double[] Values { get; set; }
    }
}
