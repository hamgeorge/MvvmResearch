using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using GalaSoft.MvvmLight;
namespace ControlsResearch.Model
{
    public class TreeNode<T>:Item
    {

        private bool m_IsExpanded;

        public bool IsExpanded
        {
            get { return m_IsExpanded; }
            set {Set(()=> IsExpanded,ref m_IsExpanded ,value); }
        }

        private ObservableCollection<TreeNode<T>> m_Children;

        public ObservableCollection<TreeNode<T>> Chidren
        {
            get { return m_Children; }
            set { Set(()=>Chidren,ref m_Children,value); }
        }


        public ImageSource Icon { get; set; }

        public TreeNode()
        {
            Chidren = new ObservableCollection<TreeNode<T>>();
            IsExpanded = true;
        }

        
    }
}
