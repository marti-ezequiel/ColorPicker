namespace Desktop
{
    public class OrderByLuminosityTabView : BasicColorTabItemView
    {
        public OrderByLuminosityTabView() : base("By Luminosity")
        {
        }

        protected override void InitializeViewModel()
        {
            this.DataContext = new OrderByLuminosityTabViewModel();
        }
    }
}
