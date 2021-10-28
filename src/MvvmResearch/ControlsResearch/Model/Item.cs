using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace ControlsResearch.Model
{
    public class Item:ViewModelBase
    {

        private string m_UUID;

        public string UUID
        {
            get { return m_UUID; }
            set {Set(()=>UUID,ref m_UUID , value); }
        }

        private string m_Name;

        public string Name
        {
            get { return m_Name; }
            set { Set(() => Name, ref m_Name, value); }
        }

        public Item()
        {
            UUID = Guid.NewGuid().ToString("B");
        }
    }
}
