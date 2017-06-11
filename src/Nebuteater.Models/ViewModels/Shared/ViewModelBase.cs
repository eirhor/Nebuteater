namespace Nebuteater.Models.ViewModels.Shared
{
    public abstract class ViewModelBase
    {
        protected ViewModelBase()
        {
            SetDefaultValues();
        }

        public string Title { get; set; }

        public void SetDefaultValues()
        {
        }
    }
}