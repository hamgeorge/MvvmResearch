using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.ViewModel;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<Context>(()=>new Context { Name="KB",CurrentPage="Main"});
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<PageOneViewModel>();
            SimpleIoc.Default.Register<PageTwoViewModel>();
            SimpleIoc.Default.Register<PageThreeViewModel>();
            SimpleIoc.Default.Register<PageFourViewModel>();

            var navigationService = this.CreateNavigationService();
            SimpleIoc.Default.Register<INavigationService>(() => navigationService);
        }
        private INavigationService CreateNavigationService()
        {
            var nav = new NavigationService();

            var navigationService = new NavigationService();
            navigationService.Configure("PageTwo1", new Uri("/WpfApp1;component/Views/Pages/PageTwo1.xaml", UriKind.Relative));
            navigationService.Configure("PageTwo2", new Uri("/WpfApp1;component/Views/Pages/PageTwo2.xaml", UriKind.Relative));
            navigationService.Configure("PageTwo3", new Uri("/WpfApp1;component/Views/Pages/PageTwo3.xaml", UriKind.Relative));
            navigationService.Configure("PageTwo4", new Uri("/WpfApp1;component/Views/Pages/PageTwo4.xaml", UriKind.Relative));
            return navigationService;
        }
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public PageOneViewModel PageOne
        {
            get
            {
                return ServiceLocator.Current.GetInstance<PageOneViewModel>();
            }
        }
        public PageTwoViewModel PageTwo
        {
            get
            {
                return ServiceLocator.Current.GetInstance<PageTwoViewModel>();
            }
        }
        public PageThreeViewModel PageThree
        {
            get
            {
                return ServiceLocator.Current.GetInstance<PageThreeViewModel>();
            }
        }
        public PageFourViewModel PageFour
        {
            get
            {
                return ServiceLocator.Current.GetInstance<PageFourViewModel>();
            }
        }
        public static void Cleanup()
        {
        }
    }
}
