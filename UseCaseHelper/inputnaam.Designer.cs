namespace UseCaseHelper
{
    partial class inputnaam
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
            this.BtnOke = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TbNaam = new System.Windows.Forms.TextBox();
            this.LblVraag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOke
            // 
            this.BtnOke.Location = new System.Drawing.Point(12, 54);
            this.BtnOke.Name = "BtnOke";
            this.BtnOke.Size = new System.Drawing.Size(75, 23);
            this.BtnOke.TabIndex = 0;
            this.BtnOke.Text = "Oke";
            this.BtnOke.UseVisualStyleBackColor = true;
            this.BtnOke.Click += new System.EventHandler(this.BtnOke_Click_1);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(103, 54);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TbNaam
            // 
            this.TbNaam.Location = new System.Drawing.Point(12, 28);
            this.TbNaam.Name = "TbNaam";
            this.TbNaam.Size = new System.Drawing.Size(166, 20);
            this.TbNaam.TabIndex = 2;
            // 
            // LblVraag
            // 
            this.LblVraag.Location = new System.Drawing.Point(12, 9);
            this.LblVraag.Name = "LblVraag";
            this.LblVraag.Size = new System.Drawing.Size(166, 16);
            this.LblVraag.TabIndex = 0;
            // 
            // inputnaam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 98);
            this.Controls.Add(this.LblVraag);
            this.Controls.Add(this.TbNaam);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inputnaam";
            this.Text = "inputnaam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOke;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TbNaam;
        private System.Windows.Forms.Label LblVraag;
    }
}