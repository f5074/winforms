namespace F5074.UI.View.QueryExecutor
{
    partial class QueryExecutor
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
            this.components = new System.ComponentModel.Container();
            this.baseButton1 = new F5074.Common.Controls.BaseButton();
            this.baseTextBox1 = new F5074.Common.Controls.BaseTextBox();
            this.baseTabControl1 = new F5074.Common.Controls.BaseTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.baseTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseButton1
            // 
            this.baseButton1.Location = new System.Drawing.Point(942, 18);
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.Size = new System.Drawing.Size(75, 23);
            this.baseButton1.TabIndex = 0;
            this.baseButton1.Text = "baseButton1";
            this.baseButton1.UseVisualStyleBackColor = true;
            // 
            // baseTextBox1
            // 
            this.baseTextBox1.Location = new System.Drawing.Point(343, 82);
            this.baseTextBox1.Name = "baseTextBox1";
            this.baseTextBox1.Size = new System.Drawing.Size(100, 21);
            this.baseTextBox1.TabIndex = 1;
            // 
            // baseTabControl1
            // 
            this.baseTabControl1.Controls.Add(this.tabPage1);
            this.baseTabControl1.Controls.Add(this.tabPage2);
            this.baseTabControl1.Location = new System.Drawing.Point(94, 249);
            this.baseTabControl1.Name = "baseTabControl1";
            this.baseTabControl1.SelectedIndex = 0;
            this.baseTabControl1.Size = new System.Drawing.Size(909, 300);
            this.baseTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // QueryExecutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.baseTabControl1);
            this.Controls.Add(this.baseTextBox1);
            this.Controls.Add(this.baseButton1);
            this.Name = "QueryExecutor";
            this.Size = new System.Drawing.Size(1041, 575);
            this.baseTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.Controls.BaseButton baseButton1;
        private Common.Controls.BaseTextBox baseTextBox1;
        private Common.Controls.BaseTabControl baseTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
