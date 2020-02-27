using System.Collections.ObjectModel;

namespace TabDataGridError
{
    public class MainWindowViewModel
    {
        public ObservableCollection<ITab> Tabs { get; set; } = new ObservableCollection<ITab>();
        public MainWindowViewModel()
        {
            Tabs.Add(new ChildViewModel("Tab1"));
            Tabs.Add(new ChildViewModel("Tab2"));
        }
    }
}
