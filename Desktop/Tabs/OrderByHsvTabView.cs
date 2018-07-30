namespace Desktop
{
    public class OrderByHsvTabView : BasicColorTabItemView
    {
        public OrderByHsvTabView() : base("By HSV")
        {
        }

        protected override void InitializeViewModel()
        {
            this.DataContext = new OrderByHsvTabViewModel();
        }
    }
}
