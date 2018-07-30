namespace Desktop
{
    public class OrderByLuminocityTabView : BasicColorTabItemView
    {
        public OrderByLuminocityTabView() : base("By Luminocity")
        {
        }

        protected override void InitializeViewModel()
        {
            this.DataContext = new OrderByLuminocityTabViewModel();
        }
    }
}
