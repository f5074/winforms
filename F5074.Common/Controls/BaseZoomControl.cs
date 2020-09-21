using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.Common.Model;

namespace F5074.Common.Controls
{
    public partial class BaseZoomControl : UserControl, INotifyPropertyChanged
    {
        public BaseZoomControl()
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
            this.baseButton1.Text = string.Format("{0}%", trackBar1.Value);
        }
        public void OnZoomValueChanged()
        {
            OnPropertyChanged("ZoomValue");
            SyncControls();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void SyncControls()
        {
            if(ZoomControls != null)
            {
                for (int rowIdx = 0; rowIdx < ZoomControls.Count; rowIdx++)
                {
                    if (ZoomControls[rowIdx].Component.Parent.GetType().Name != "Panel")
                    {
                        Panel panel = new Panel();
                        panel.AutoScroll = true;
                        panel.Dock = DockStyle.Fill;
                        ZoomControls[rowIdx].Component.Parent.Controls.Add(panel);
                        panel.Controls.Add(ZoomControls[rowIdx].Component);
                    }

                    setControlsWidth(ZoomControls[rowIdx].Component);
                }
            }
        }

        public void setControlsWidth(Control _control)
        {
            _control.Dock = DockStyle.Fill;
            int originWidth = _control.Width;
            _control.Dock = DockStyle.Left;
            _control.Width = trackBar1.Value;
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

        public List<ZoomComponent> _ZoomControls;

        [Category("_Extension")]
        [Browsable(true)]
        [DisplayName("ZoomControls")]
        [Description("ZoomControls")]
        public List<ZoomComponent> ZoomControls
        {
            get
            {
                return _ZoomControls;
            }
            set
            {
                this._ZoomControls = value;
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
