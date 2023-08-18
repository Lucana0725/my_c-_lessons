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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(129, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "設定";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(129, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "設定";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumBlue;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(129, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "設定";
            this.button3.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}

