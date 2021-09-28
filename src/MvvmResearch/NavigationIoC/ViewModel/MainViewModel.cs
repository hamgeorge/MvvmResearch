using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System.Windows.Input;
using WpfApp1.Model;
using GalaSoft.MvvmLight.Command;

namespace WpfApp1.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public ICommand NextCommand { get; private set; }
        public ICommand BackCommand { get; private set; }
        private Context Context;
        private INavigationService NavigationService;
        public MainViewModel(Context context, INavigationService navigationService)
        {
            Context = context;
            NavigationService = navigationService;
            KBTest = Context.Name;
            NextCommand = new RelayCommand(Next);
            BackCommand = new RelayCommand(Back);
        }

        private void Back()
        {
            NavigationService.GoBack();
        }

        private void Next()
        {
            NavigationService.NavigateTo("PageTwo1");
        }

        private string m_KBTest;

        public string KBTest
        {
            get { return m_KBTest; }
            set {Set(()=>KBTest,ref m_KBTest,value); }
        }

    }
}