using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Media;

namespace Desktop
{
    public class MainWindowViewModel : ViewModel
    {
        public ObservableCollection<TabItem> TabItems { get; set; }

        public MainWindowViewModel()
        {
            this.TabItems = new ObservableCollection<TabItem>()
            {
                new OrderByNameTabView(),
                new OrderByRgbTabView(),
                new OrderByHsvTabView(),
                new OrderByHlsTabView(),
                new OrderByLuminocityTabView(),
                new OrderByStepsTabView()
            };

            this.RaisePropertyChange("TabItems");
        }
    }
}