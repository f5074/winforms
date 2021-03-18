using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.Common.Reference;
using F5074.Common.Controls;

namespace F5074.UI.View.F_TypeExtension
{
    public partial class TypeExtension01 : UserControl
    {
        TypeExtender _typeExtender;
        BaseTextBox baseTextBox;
        BaseButton baseButton;

        public TypeExtension01()
        {
            InitializeComponent();
            Init();
            this.Dock = DockStyle.Fill;
        }

        public void Init()
        {
            baseTextBox = new BaseTextBox() { Size = new Size(100, 20), Location = new Point(10, 0) };
            this.Controls.Add(baseTextBox);
            baseButton = new BaseButton() { Size = new Size(100, 20) , Location =  new Point(200, 0), Text = "Test"};
            this.Controls.Add(baseButton);
            baseButton.Click += BaseButton_Click;
        }

        /// <summary>
        /// BaseButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseButton_Click(object sender, EventArgs e)
        {
            AddType();
        }

        public void AddType()
        {
            var className = "MES.Client.Core.Model.ClientEntityBase";
            _typeExtender = new TypeExtender(className);
            _typeExtender.AddProperty("IsAdded", typeof(bool));
            //_typeExtender.AddProperty("IsEnabled", typeof(bool), true);
            //_typeExtender.AddProperty<double>("Length");
            //_typeExtender.AddProperty<double>("Width", true);

            //Act
            var returnedClass = _typeExtender.FetchType();
            var isAddedProperty = returnedClass.GetProperty("IsAdded");
            var isEnabledProperty = returnedClass.GetProperty("IsEnabled");
            var lengthProperty = returnedClass.GetProperty("Length");
            var widthProperty = returnedClass.GetProperty("Width");

            baseTextBox.Text = isAddedProperty.ToString();
        }
    }
}
