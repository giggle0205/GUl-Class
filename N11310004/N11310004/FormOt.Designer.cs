namespace N11310004
{
    partial class FormOt
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
            this.butAdd = new System.Windows.Forms.Button();
            this.butreduce = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butAdd.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butAdd.Location = new System.Drawing.Point(299, 147);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 56);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "+";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butreduce
            // 
            this.butreduce.BackColor = System.Drawing.Color.IndianRed;
            this.butreduce.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butreduce.Location = new System.Drawing.Point(415, 147);
            this.butreduce.Name = "butreduce";
            this.butreduce.Size = new System.Drawing.Size(75, 56);
            this.butreduce.TabIndex = 1;
            this.butreduce.Text = "-";
            this.butreduce.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butreduce.UseVisualStyleBackColor = false;
            this.butreduce.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(369, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // FormOt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butreduce);
            this.Controls.Add(this.butAdd);
            this.Name = "FormOt";
            this.Text = "作業1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butreduce;
        private System.Windows.Forms.Label label1;
    }
}