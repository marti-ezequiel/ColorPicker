namespace Desktop
{
    public class OrderByStepsTabView : BasicColorTabItemView
    {
        public OrderByStepsTabView() : base("By Steps")
        {
        }

        protected override void InitializeViewModel()
        {
            this.DataContext = new OrderByStepsTabViewModel();
        }
    }
}
