using System;
using System.IO;
using System.Linq;
using EEGAnalysisSystem.Models;

namespace EEGAnalysisSystem.Services
{
    public class EEGDataLoader
    {
        // Simple CSV loader: first row may contain headers, each column is a channel
        public EEGRecording LoadFromCsv(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));
            var rec = new EEGRecording();
            var lines = File.ReadAllLines(path).Where(l => !string.IsNullOrWhiteSpace(l)).ToArray();
            if (lines.Length == 0) return rec;

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                for (int i = 0; i < parts.Length; i++)
                {
                    if (rec.Channels.Count <= i)
                        rec.Channels.Add(new EEGChannel { Name = $"Ch{i}", Index = i });

                    if (double.TryParse(parts[i], out var v))
                        rec.Channels[i].Samples.Add(v);
                }
            }

            return rec;
        }
    }
}
