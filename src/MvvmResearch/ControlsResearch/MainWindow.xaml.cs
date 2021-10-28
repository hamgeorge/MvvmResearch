using ControlsResearch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlsResearch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TreeView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ModuleNode selectNode = (ModuleNode)this.Tree.SelectedItem;
            if (selectNode!=null)
            {
                selectNode.IsExpanded = true;
            }
            
        }

        private void Tree_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TreeViewItem SelectedfItem = new TreeViewItem();

            if (sender.GetType() == typeof(ToggleButton))
            {
                ToggleButton btn = (ToggleButton)sender;
                System.Windows.Controls.ContentPresenter CP = (System.Windows.Controls.ContentPresenter)btn.Tag;
                SelectedfItem = (TreeViewItem)CP.TemplatedParent;
            }
            else if (sender.GetType() == typeof(Border))
            {
                Border btn = (Border)sender;
                System.Windows.Controls.ContentPresenter CP = (System.Windows.Controls.ContentPresenter)btn.Tag;
                SelectedfItem = (TreeViewItem)CP.TemplatedParent;
            }
            else if (e.Source.GetType() == typeof(TreeViewItem))
            {
                SelectedfItem = (TreeViewItem)sender;
            }

            if (SelectedfItem == null )
            {
                SelectedfItem.IsExpanded = SelectedfItem.IsExpanded == true ? false : true;
            }

        }
    }
}
