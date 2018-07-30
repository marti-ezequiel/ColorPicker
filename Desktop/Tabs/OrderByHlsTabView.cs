namespace Desktop
{
    public class OrderByHlsTabView : BasicColorTabItemView
    {
        public OrderByHlsTabView() : base("By HLS")
        {
        }

        protected override void InitializeViewModel()
        {
            this.DataContext = new OrderByHlsTabViewModel();
        }
    }
}
