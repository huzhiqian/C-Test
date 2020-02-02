namespace RoundButtonTestProj
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.roundButton1 = new RoundButton.RoundButton();
            this.roundButton2 = new RoundButton.RoundButton();
            this.SuspendLayout();
            // 
            // roundButton1
            // 
            this.roundButton1.BorderWidth = 4;
            this.roundButton1.ButtonCenterColorEnd = System.Drawing.Color.Red;
            this.roundButton1.ButtonCenterColorStart = System.Drawing.Color.DeepPink;
            this.roundButton1.DistanceToBorder = 4;
            this.roundButton1.FocusBorderColor = System.Drawing.Color.Black;
            this.roundButton1.Location = new System.Drawing.Point(353, 82);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(59, 59);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // roundButton2
            // 
            this.roundButton2.BorderWidth = 4;
            this.roundButton2.ButtonCenterColorEnd = System.Drawing.Color.Red;
            this.roundButton2.ButtonCenterColorStart = System.Drawing.Color.DeepPink;
            this.roundButton2.DistanceToBorder = 4;
            this.roundButton2.FocusBorderColor = System.Drawing.Color.Black;
            this.roundButton2.IsShowIcon = true;
            this.roundButton2.Location = new System.Drawing.Point(371, 196);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(59, 59);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.Text = "roundButton2";
            this.roundButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton.RoundButton roundButton1;
        private RoundButton.RoundButton roundButton2;
    }
}

