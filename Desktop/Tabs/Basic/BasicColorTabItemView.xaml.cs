using System;
using System.Windows.Controls;

namespace Desktop
{
    public abstract partial class BasicColorTabItemView : TabItem
    {
        protected BasicColorTabItemViewModel ViewModel
        {
            get
            {
                return (BasicColorTabItemViewModel)this.DataContext;
            }
        }

        public BasicColorTabItemView(String header)
        {
            InitializeComponent();

            InitializeViewModel();

            this.Header = header;

            foreach(var color in this.ViewModel.Colors)
            {
                var textBlock = new TextBlock()
                {
                    Background = color.Color,
                    Height = 1
                };

                this.colorPanel.Children.Add(textBlock);
            }
        }

        protected abstract void InitializeViewModel();
    }
}