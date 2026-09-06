using System;
using System.Collections.Generic;

namespace EEGAnalysisSystem.Models
{
    public class EEGRecording
    {
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public List<EEGChannel> Channels { get; set; } = new List<EEGChannel>();
    }
}
