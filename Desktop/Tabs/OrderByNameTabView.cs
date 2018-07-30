namespace Desktop
{
    public class OrderByNameTabView : BasicColorTabItemView
    {
        public OrderByNameTabView() : base("By Name")
        {
        }

        protected override void InitializeViewModel()
        {
            this.DataContext = new OrderByNameTabViewModel();
        }
    }
}
