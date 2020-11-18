namespace F5074.UI.View.E_DataTable
{
    partial class DataTable03
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
            this.baseDataGridView1 = new F5074.Common.Controls.BaseDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // baseDataGridView1
            // 
            this.baseDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baseDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.baseDataGridView1.Name = "baseDataGridView1";
            this.baseDataGridView1.RowTemplate.Height = 23;
            this.baseDataGridView1.Size = new System.Drawing.Size(797, 498);
            this.baseDataGridView1.TabIndex = 0;
            // 
            // DataTable03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.baseDataGridView1);
            this.Name = "DataTable03";
            this.Size = new System.Drawing.Size(797, 498);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Controls.BaseDataGridView baseDataGridView1;
    }
}
