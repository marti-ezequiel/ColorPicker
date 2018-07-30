namespace Desktop
{
    public class OrderByRgbTabView : BasicColorTabItemView
    {
        public OrderByRgbTabView() : base("By RGB")
        {
        }

        protected override void InitializeViewModel()
        {
            this.DataContext = new OrderByRgbTabViewModel();
        }
    }
}
