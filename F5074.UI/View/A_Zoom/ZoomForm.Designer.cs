namespace F5074.UI.View.A_Zoom
{
    partial class ZoomForm
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            F5074.Common.Model.ZoomComponent zoomComponent1 = new F5074.Common.Model.ZoomComponent();
            F5074.Common.Model.ZoomComponent zoomComponent2 = new F5074.Common.Model.ZoomComponent();
            this.baseTableLayoutPanel1 = new F5074.Common.Controls.BaseTableLayoutPanel();
            this.baseChart1 = new F5074.Common.Controls.BaseChart();
            this.baseChart2 = new F5074.Common.Controls.BaseChart();
            this.baseStatusBar1 = new F5074.Common.Controls.BaseStatusBar();
            this.baseTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseChart2)).BeginInit();
            this.SuspendLayout();
            // 
            // baseTableLayoutPanel1
            // 
            this.baseTableLayoutPanel1.ColumnCount = 2;
            this.baseTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.baseTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.baseTableLayoutPanel1.Controls.Add(this.baseChart1, 0, 0);
            this.baseTableLayoutPanel1.Controls.Add(this.baseChart2, 1, 0);
            this.baseTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.baseTableLayoutPanel1.Name = "baseTableLayoutPanel1";
            this.baseTableLayoutPanel1.RowCount = 2;
            this.baseTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.baseTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.baseTableLayoutPanel1.Size = new System.Drawing.Size(1358, 618);
            this.baseTableLayoutPanel1.TabIndex = 0;
            // 
            // baseChart1
            // 
            chartArea1.Name = "ChartArea1";
            this.baseChart1.ChartAreas.Add(chartArea1);
            this.baseChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.baseChart1.Legends.Add(legend1);
            this.baseChart1.Location = new System.Drawing.Point(3, 3);
            this.baseChart1.Name = "baseChart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.baseChart1.Series.Add(series1);
            this.baseChart1.Size = new System.Drawing.Size(673, 303);
            this.baseChart1.TabIndex = 0;
            this.baseChart1.Text = "baseChart1";
            // 
            // baseChart2
            // 
            chartArea2.Name = "ChartArea1";
            this.baseChart2.ChartAreas.Add(chartArea2);
            this.baseChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.baseChart2.Legends.Add(legend2);
            this.baseChart2.Location = new System.Drawing.Point(682, 3);
            this.baseChart2.Name = "baseChart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.baseChart2.Series.Add(series2);
            this.baseChart2.Size = new System.Drawing.Size(673, 303);
            this.baseChart2.TabIndex = 1;
            this.baseChart2.Text = "baseChart2";
            // 
            // baseStatusBar1
            // 
            this.baseStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.baseStatusBar1.Location = new System.Drawing.Point(0, 618);
            this.baseStatusBar1.Name = "baseStatusBar1";
            this.baseStatusBar1.Size = new System.Drawing.Size(1358, 32);
            this.baseStatusBar1.TabIndex = 0;
            this.baseStatusBar1.ZoomChart = null;
            zoomComponent1.Component = this.baseChart1;
            zoomComponent2.Component = this.baseChart2;
            this.baseStatusBar1.ZoomControls.Add(zoomComponent1);
            this.baseStatusBar1.ZoomControls.Add(zoomComponent2);
            // 
            // ZoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.baseTableLayoutPanel1);
            this.Controls.Add(this.baseStatusBar1);
            this.Name = "ZoomForm";
            this.Size = new System.Drawing.Size(1358, 650);
            this.baseTableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseChart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Controls.BaseTableLayoutPanel baseTableLayoutPanel1;
        private Common.Controls.BaseStatusBar baseStatusBar1;
        private Common.Controls.BaseChart baseChart2;
        private Common.Controls.BaseChart baseChart1;
    }
}
