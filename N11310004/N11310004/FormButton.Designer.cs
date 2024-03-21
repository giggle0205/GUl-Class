namespace N11310004
{
    partial class FormButton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClick = new System.Windows.Forms.Button();
            this.butlab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labCount = new System.Windows.Forms.Label();
            this.butCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClick.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClick.Location = new System.Drawing.Point(125, 152);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(565, 174);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "導彈按鈕";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // butlab
            // 
            this.butlab.Location = new System.Drawing.Point(125, 102);
            this.butlab.Name = "butlab";
            this.butlab.Size = new System.Drawing.Size(75, 23);
            this.butlab.TabIndex = 1;
            this.butlab.Text = "button1";
            this.butlab.UseVisualStyleBackColor = true;
            this.butlab.Click += new System.EventHandler(this.butlab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Location = new System.Drawing.Point(382, 72);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(11, 12);
            this.labCount.TabIndex = 4;
            this.labCount.Text = "0";
            this.labCount.Click += new System.EventHandler(this.label2_Click);
            // 
            // butCount
            // 
            this.butCount.Location = new System.Drawing.Point(351, 102);
            this.butCount.Name = "butCount";
            this.butCount.Size = new System.Drawing.Size(75, 23);
            this.butCount.TabIndex = 3;
            this.butCount.Text = "button1";
            this.butCount.UseVisualStyleBackColor = true;
            this.butCount.Click += new System.EventHandler(this.butCount_Click);
            // 
            // FormButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.butCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butlab);
            this.Controls.Add(this.btnClick);
            this.Name = "FormButton";
            this.Text = "按鈕畫面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button butlab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button butCount;
    }
}