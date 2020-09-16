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
            this.baseChart1 = new F5074.Common.Controls.BaseChart();
            this.formStatusBar1 = new F5074.Common.Controls.FormStatusBar();
            this.basePanel1 = new F5074.Common.Controls.BasePanel();
            ((System.ComponentModel.ISupportInitialize)(this.baseChart1)).BeginInit();
            this.basePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseChart1
            // 
            chartArea1.Name = "ChartArea1";
            this.baseChart1.ChartAreas.Add(chartArea1);
            this.baseChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.baseChart1.Legends.Add(legend1);
            this.baseChart1.Location = new System.Drawing.Point(0, 0);
            this.baseChart1.Name = "baseChart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.baseChart1.Series.Add(series1);
            this.baseChart1.Size = new System.Drawing.Size(702, 226);
            this.baseChart1.TabIndex = 0;
            this.baseChart1.Text = "baseChart1";
            // 
            // formStatusBar1
            // 
            this.formStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formStatusBar1.Location = new System.Drawing.Point(0, 292);
            this.formStatusBar1.Name = "formStatusBar1";
            this.formStatusBar1.Size = new System.Drawing.Size(838, 32);
            this.formStatusBar1.TabIndex = 1;
            this.formStatusBar1.ZoomChart = null;
            // 
            // basePanel1
            // 
            this.basePanel1.Controls.Add(this.baseChart1);
            this.basePanel1.Location = new System.Drawing.Point(49, 33);
            this.basePanel1.Name = "basePanel1";
            this.basePanel1.Size = new System.Drawing.Size(702, 226);
            this.basePanel1.TabIndex = 2;
            // 
            // ZoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.basePanel1);
            this.Controls.Add(this.formStatusBar1);
            this.Name = "ZoomForm";
            this.Size = new System.Drawing.Size(838, 324);
            ((System.ComponentModel.ISupportInitialize)(this.baseChart1)).EndInit();
            this.basePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Controls.BaseChart baseChart1;
        private Common.Controls.FormStatusBar formStatusBar1;
        private Common.Controls.BasePanel basePanel1;
    }
}
