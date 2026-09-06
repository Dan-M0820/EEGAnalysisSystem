using EEGAnalysisSystem.Models;
using System.Collections.ObjectModel;

namespace EEGAnalysisSystem.ViewModels
{
    public class AnalysisViewModel : MainViewModel
    {
        public ObservableCollection<AnalysisResult> Results { get; } = new ObservableCollection<AnalysisResult>();
    }
}
