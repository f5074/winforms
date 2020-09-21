using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Common.Model
{
    public class ZoomComponent
    {
        private bool _Required;
        private Control _Component;

        public ZoomComponent()
        {
            this._Required = false;
            this._Component = (Control)null;
        }

        [Category("Constraints")]
        [DisplayName("Required")]
        [Description("Required")]
        [DefaultValue(false)]
        [Browsable(true)]
        public bool Required
        {
            get
            {
                return this._Required;
            }
            set
            {
                this._Required = value;
            }
        }

        [Category("Data")]
        [DisplayName("Component")]
        [Description("Component")]
        [DefaultValue(null)]
        [Browsable(true)]
        public Control Component
        {
            get
            {
                return this._Component;
            }
            set
            {
                this._Component = value;
            }
        }
    }
}
