using ControlsResearch.Model;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace ControlsResearch.ViewModel
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
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            var  Root = new ModuleNode();
            Root.Name = "Root";
            Root.IsExpanded = true;
            var c1 = new ModuleNode { Name = "Test1" };
            var d1 = new ModuleNode { Name = "Test2" };
            var e1 = new ModuleNode { Name = "Test3" };
            d1.Chidren.Add(e1);
            c1.Chidren.Add(d1);

            Root.Chidren.Add(c1);
            Modules = new ObservableCollection<ModuleNode>();
            Modules.Add(Root);
        }


        private ObservableCollection<ModuleNode> m_Modules;

        public ObservableCollection<ModuleNode> Modules
        {
            get { return m_Modules; }
            set { Set(()=> Modules,ref m_Modules , value); }
        }

        private ModuleNode m_ModuleNode;

        public ModuleNode ModuleNode
        {
            get { return m_ModuleNode; }
            set { Set(()=> ModuleNode,ref m_ModuleNode ,value); }
        }


    }
}