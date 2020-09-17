using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.UI.ViewModel
{
    public class ViewTestModel : INotifyPropertyChanged
    {
        public string _status;
        public string _flag;

        public event PropertyChangedEventHandler PropertyChanged;

        public string status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnpropertyChanged("status");
            }
        }

        private void OnpropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
