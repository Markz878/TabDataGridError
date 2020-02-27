using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TabDataGridError
{
    public class ChildViewModel : ITab
    {
        public ObservableCollection<ItemModel> Items { get; set; } = new ObservableCollection<ItemModel>();
        public string Name { get; set; }
        public ChildViewModel(string name)
        {
            Items.Add(new ItemModel());
            Name = name;
        }
    }
}
