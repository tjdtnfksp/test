namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_dataSelect = new System.Windows.Forms.Button();
            this.lb_path = new System.Windows.Forms.Label();
            this.tb_dataPath = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(376, 368);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_dataSelect
            // 
            this.btn_dataSelect.Location = new System.Drawing.Point(376, 51);
            this.btn_dataSelect.Name = "btn_dataSelect";
            this.btn_dataSelect.Size = new System.Drawing.Size(75, 23);
            this.btn_dataSelect.TabIndex = 10;
            this.btn_dataSelect.Text = "선택";
            this.btn_dataSelect.UseVisualStyleBackColor = true;
            this.btn_dataSelect.Click += new System.EventHandler(this.btn_dataSelect_Click);
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Location = new System.Drawing.Point(25, 23);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(65, 12);
            this.lb_path.TabIndex = 8;
            this.lb_path.Text = "파일 경로 :";
            // 
            // tb_dataPath
            // 
            this.tb_dataPath.BackColor = System.Drawing.Color.White;
            this.tb_dataPath.Location = new System.Drawing.Point(94, 20);
            this.tb_dataPath.Name = "tb_dataPath";
            this.tb_dataPath.ReadOnly = true;
            this.tb_dataPath.Size = new System.Drawing.Size(357, 21);
            this.tb_dataPath.TabIndex = 9;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(27, 98);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(424, 250);
            this.dataGridView.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 406);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_dataSelect);
            this.Controls.Add(this.lb_path);
            this.Controls.Add(this.tb_dataPath);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_dataSelect;
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.TextBox tb_dataPath;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

