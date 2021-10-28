using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsResearch.Model
{
    public class ModuleNode :Item
    {
        private bool m_IsExpanded;

        public bool IsExpanded
        {
            get { return m_IsExpanded; }
            set { Set(() => IsExpanded, ref m_IsExpanded, value); }
        }

        private ObservableCollection<ModuleNode> m_Children;

        public ObservableCollection<ModuleNode> Chidren
        {
            get { return m_Children; }
            set { Set(() => Chidren, ref m_Children, value); }
        }
        public ModuleNode()
        {
            Chidren = new ObservableCollection<ModuleNode>();
            IsExpanded = true;
        }
    }
}
