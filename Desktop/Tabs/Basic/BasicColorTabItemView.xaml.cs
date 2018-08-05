using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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

            int row = 0;

            foreach(var color in this.ViewModel.Colors)
            {
                var textBlock = new TextBlock()
                {
                    Background = color.Color
                };
                Grid.SetRow(textBlock, row++);

                Binding heightBinding = new Binding()
                {
                    Source = this.colorPanel,
                    Path = new PropertyPath("ElementsHeight"),
                    Mode = BindingMode.OneWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                };
                BindingOperations.SetBinding(textBlock, TextBlock.HeightProperty, heightBinding);
                
                this.colorPanel.RowDefinitions.Add(new RowDefinition());
                this.colorPanel.Children.Add(textBlock);
            }
        }

        protected abstract void InitializeViewModel();
    }
}