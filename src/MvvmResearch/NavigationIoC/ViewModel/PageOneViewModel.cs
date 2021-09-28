using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System.Windows.Input;

namespace WpfApp1
{
    public class PageOneViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        public ICommand GoBackCommand { get; set; }
        public ICommand GoToNextCommand { get; set; }
        public ICommand ChangeCommand { get; set; }
        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                Set(() => Title, ref _title, value);
            }
        }

        public PageOneViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Title = "Please Click me!";
            GoBackCommand = new RelayCommand(GoBack);
            GoToNextCommand = new RelayCommand(GotoNext);
            ChangeCommand = new RelayCommand(ChangeTitle);
        }
        private void ChangeTitle()
        {
            Title = "Hello MvvmLight!!!";
        }
        private void GoBack()
        {
            _navigationService.GoBack();
        }
        private void GotoNext()
        {
            var navigationService = ServiceLocator.Current.GetInstance<INavigationService>();
            navigationService.NavigateTo("PageTwo2");
        }
    }
}