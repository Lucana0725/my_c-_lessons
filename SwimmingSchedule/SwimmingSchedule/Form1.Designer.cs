namespace SwimmingSchedule
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.labelLessonDate = new System.Windows.Forms.Label();
            this.labelLessonStartTime = new System.Windows.Forms.Label();
            this.labelLessonFee = new System.Windows.Forms.Label();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(34, 32);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 19);
            this.numericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "月";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(171, 32);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(77, 19);
            this.numericUpDown2.TabIndex = 2;
            // 
            // labelLessonDate
            // 
            this.labelLessonDate.AutoSize = true;
            this.labelLessonDate.Location = new System.Drawing.Point(34, 76);
            this.labelLessonDate.Name = "labelLessonDate";
            this.labelLessonDate.Size = new System.Drawing.Size(35, 12);
            this.labelLessonDate.TabIndex = 4;
            this.labelLessonDate.Text = "label3";
            // 
            // labelLessonStartTime
            // 
            this.labelLessonStartTime.AutoSize = true;
            this.labelLessonStartTime.Location = new System.Drawing.Point(34, 116);
            this.labelLessonStartTime.Name = "labelLessonStartTime";
            this.labelLessonStartTime.Size = new System.Drawing.Size(35, 12);
            this.labelLessonStartTime.TabIndex = 5;
            this.labelLessonStartTime.Text = "label4";
            // 
            // labelLessonFee
            // 
            this.labelLessonFee.AutoSize = true;
            this.labelLessonFee.Location = new System.Drawing.Point(34, 160);
            this.labelLessonFee.Name = "labelLessonFee";
            this.labelLessonFee.Size = new System.Drawing.Size(35, 12);
            this.labelLessonFee.TabIndex = 6;
            this.labelLessonFee.Text = "label5";
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 12;
            this.listBoxMenu.Location = new System.Drawing.Point(316, 32);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(120, 88);
            this.listBoxMenu.TabIndex = 7;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(34, 197);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(402, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "表示";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 250);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.labelLessonFee);
            this.Controls.Add(this.labelLessonStartTime);
            this.Controls.Add(this.labelLessonDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "CSスイミングスクール";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label labelLessonDate;
        private System.Windows.Forms.Label labelLessonStartTime;
        private System.Windows.Forms.Label labelLessonFee;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Button buttonOK;
    }
}

