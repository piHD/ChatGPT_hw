namespace ChatGPT_hw
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRece = new System.Windows.Forms.Label();
            this.lblSend = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtRece = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(36, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "主題";
            // 
            // lblRece
            // 
            this.lblRece.AutoSize = true;
            this.lblRece.Location = new System.Drawing.Point(36, 65);
            this.lblRece.Name = "lblRece";
            this.lblRece.Size = new System.Drawing.Size(72, 25);
            this.lblRece.TabIndex = 1;
            this.lblRece.Text = "收件人";
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(36, 106);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(72, 25);
            this.lblSend.TabIndex = 2;
            this.lblSend.Text = "寄件人";
            // 
            // txtTitle
            // 
            this.txtTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTitle.Location = new System.Drawing.Point(117, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(229, 34);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Text = "請輸入信件主題";
            // 
            // txtRece
            // 
            this.txtRece.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRece.Location = new System.Drawing.Point(117, 62);
            this.txtRece.Name = "txtRece";
            this.txtRece.Size = new System.Drawing.Size(229, 34);
            this.txtRece.TabIndex = 4;
            this.txtRece.Text = "請輸入收件人姓名與稱謂";
            // 
            // txtSend
            // 
            this.txtSend.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSend.Location = new System.Drawing.Point(117, 103);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(229, 34);
            this.txtSend.TabIndex = 5;
            this.txtSend.Text = "請輸入你的姓名";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(36, 155);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(92, 25);
            this.lblContent.TabIndex = 6;
            this.lblContent.Text = "信件內容";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(41, 193);
            this.txtContent.MinimumSize = new System.Drawing.Size(500, 100);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(594, 233);
            this.txtContent.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(405, 103);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(107, 34);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "產生內容";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(529, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "儲存結果";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(400, 22);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(112, 25);
            this.lblChange.TabIndex = 10;
            this.lblChange.Text = "須變更內容";
            this.lblChange.Visible = false;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(405, 56);
            this.txtChange.Name = "txtChange";
            this.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChange.Size = new System.Drawing.Size(229, 34);
            this.txtChange.TabIndex = 11;
            this.txtChange.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtRece);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.lblRece);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "寄信助理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRece;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtRece;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
    }
}

