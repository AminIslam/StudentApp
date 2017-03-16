namespace StudentLayerApp.UI
{
    partial class ShowDefaultParam
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
            this.btnDefaultParam = new System.Windows.Forms.Button();
            this.txtDefaultParam = new System.Windows.Forms.TextBox();
            this.dtmpDefault = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnDefaultParam
            // 
            this.btnDefaultParam.Location = new System.Drawing.Point(142, 168);
            this.btnDefaultParam.Name = "btnDefaultParam";
            this.btnDefaultParam.Size = new System.Drawing.Size(111, 23);
            this.btnDefaultParam.TabIndex = 0;
            this.btnDefaultParam.Text = "Default";
            this.btnDefaultParam.UseVisualStyleBackColor = true;
            this.btnDefaultParam.Click += new System.EventHandler(this.btnDefaultParam_Click);
            // 
            // txtDefaultParam
            // 
            this.txtDefaultParam.Location = new System.Drawing.Point(103, 97);
            this.txtDefaultParam.Name = "txtDefaultParam";
            this.txtDefaultParam.Size = new System.Drawing.Size(179, 20);
            this.txtDefaultParam.TabIndex = 1;
            // 
            // dtmpDefault
            // 
            this.dtmpDefault.Location = new System.Drawing.Point(103, 49);
            this.dtmpDefault.Name = "dtmpDefault";
            this.dtmpDefault.Size = new System.Drawing.Size(200, 20);
            this.dtmpDefault.TabIndex = 2;
            // 
            // ShowDefaultParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 316);
            this.Controls.Add(this.dtmpDefault);
            this.Controls.Add(this.txtDefaultParam);
            this.Controls.Add(this.btnDefaultParam);
            this.Name = "ShowDefaultParam";
            this.Text = "ShowDefaultParam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDefaultParam;
        private System.Windows.Forms.TextBox txtDefaultParam;
        private System.Windows.Forms.DateTimePicker dtmpDefault;
    }
}