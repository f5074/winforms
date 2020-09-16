using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Common.Controls
{
    public partial class ZoomControl : UserControl, INotifyPropertyChanged
    {
        public ZoomControl()
        {
            InitializeComponent();
            this.trackBar1.Minimum = 0;
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Value = 1000;
            this.trackBar1.ValueChanged += TrackBar1_ValueChanged;
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            OnZoomValueChanged();
            if (this.ZoomChart != null)
            {
                this.baseButton1.Text = string.Format("{0}%", trackBar1.Value);
            }
        }
        public void OnZoomValueChanged()
        {
            OnPropertyChanged("ZoomValue");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public BaseChart _ZoomChart;

        [Category("_Extension")]
        [Browsable(true)]
        [DisplayName("ZoomChart")]
        [Description("ZoomChart")]
        public BaseChart ZoomChart
        {
            get
            {
                return _ZoomChart;
            }
            set
            {
                this._ZoomChart = value;
                if (this._ZoomChart != null)
                {
                    this.DataBindings.Add(new Binding("ZoomValue", value, "Width")
                    {
                        DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged
                    });
                }
            }
        }

        public int ZoomValue
        {
            get
            {
                return this.trackBar1.Value;
            }
            set
            {
                if (this.ZoomChart != null)
                {
                    this.ZoomChart.Width =  Convert.ToInt32(value);
                }

            }
        }

    }
}
