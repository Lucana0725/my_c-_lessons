namespace MultiAlarm
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
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.checkBoxTimer1 = new System.Windows.Forms.CheckBox();
            this.checkBoxTimer2 = new System.Windows.Forms.CheckBox();
            this.checkBoxTimer3 = new System.Windows.Forms.CheckBox();
            this.buttonSet1 = new System.Windows.Forms.Button();
            this.buttonSet2 = new System.Windows.Forms.Button();
            this.buttonSet3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.ForeColor = System.Drawing.Color.Yellow;
            this.labelTime.Location = new System.Drawing.Point(48, 18);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(98, 33);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "label1";
            // 
            // checkBoxTimer1
            // 
            this.checkBoxTimer1.AutoSize = true;
            this.checkBoxTimer1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxTimer1.ForeColor = System.Drawing.Color.White;
            this.checkBoxTimer1.Location = new System.Drawing.Point(27, 76);
            this.checkBoxTimer1.Name = "checkBoxTimer1";
            this.checkBoxTimer1.Size = new System.Drawing.Size(77, 23);
            this.checkBoxTimer1.TabIndex = 1;
            this.checkBoxTimer1.Text = "00:00";
            this.checkBoxTimer1.UseVisualStyleBackColor = true;
            // 
            // checkBoxTimer2
            // 
            this.checkBoxTimer2.AutoSize = true;
            this.checkBoxTimer2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxTimer2.ForeColor = System.Drawing.Color.White;
            this.checkBoxTimer2.Location = new System.Drawing.Point(27, 115);
            this.checkBoxTimer2.Name = "checkBoxTimer2";
            this.checkBoxTimer2.Size = new System.Drawing.Size(77, 23);
            this.checkBoxTimer2.TabIndex = 2;
            this.checkBoxTimer2.Text = "00:00";
            this.checkBoxTimer2.UseVisualStyleBackColor = true;
            // 
            // checkBoxTimer3
            // 
            this.checkBoxTimer3.AutoSize = true;
            this.checkBoxTimer3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxTimer3.ForeColor = System.Drawing.Color.White;
            this.checkBoxTimer3.Location = new System.Drawing.Point(27, 156);
            this.checkBoxTimer3.Name = "checkBoxTimer3";
            this.checkBoxTimer3.Size = new System.Drawing.Size(77, 23);
            this.checkBoxTimer3.TabIndex = 3;
            this.checkBoxTimer3.Text = "00:00";
            this.checkBoxTimer3.UseVisualStyleBackColor = true;
            // 
            // buttonSet1
            // 
            this.buttonSet1.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonSet1.ForeColor = System.Drawing.Color.White;
            this.buttonSet1.Location = new System.Drawing.Point(129, 75);
            this.buttonSet1.Name = "buttonSet1";
            this.buttonSet1.Size = new System.Drawing.Size(75, 23);
            this.buttonSet1.TabIndex = 4;
            this.buttonSet1.Text = "設定";
            this.buttonSet1.UseVisualStyleBackColor = false;
            this.buttonSet1.Click += new System.EventHandler(this.buttonSet1_Click);
            // 
            // buttonSet2
            // 
            this.buttonSet2.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonSet2.ForeColor = System.Drawing.Color.White;
            this.buttonSet2.Location = new System.Drawing.Point(129, 114);
            this.buttonSet2.Name = "buttonSet2";
            this.buttonSet2.Size = new System.Drawing.Size(75, 23);
            this.buttonSet2.TabIndex = 5;
            this.buttonSet2.Text = "設定";
            this.buttonSet2.UseVisualStyleBackColor = false;
            // 
            // buttonSet3
            // 
            this.buttonSet3.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonSet3.ForeColor = System.Drawing.Color.White;
            this.buttonSet3.Location = new System.Drawing.Point(129, 155);
            this.buttonSet3.Name = "buttonSet3";
            this.buttonSet3.Size = new System.Drawing.Size(75, 23);
            this.buttonSet3.TabIndex = 6;
            this.buttonSet3.Text = "設定";
            this.buttonSet3.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(238, 212);
            this.Controls.Add(this.buttonSet3);
            this.Controls.Add(this.buttonSet2);
            this.Controls.Add(this.buttonSet1);
            this.Controls.Add(this.checkBoxTimer3);
            this.Controls.Add(this.checkBoxTimer2);
            this.Controls.Add(this.checkBoxTimer1);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "アラーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkBoxTimer1;
        private System.Windows.Forms.CheckBox checkBoxTimer2;
        private System.Windows.Forms.CheckBox checkBoxTimer3;
        private System.Windows.Forms.Button buttonSet1;
        private System.Windows.Forms.Button buttonSet2;
        private System.Windows.Forms.Button buttonSet3;
        private System.Windows.Forms.Timer timer1;
    }
}

