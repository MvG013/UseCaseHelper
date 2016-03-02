namespace UseCaseHelper
{
    partial class Form1
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
            this.rbActor = new System.Windows.Forms.RadioButton();
            this.rbUseCase = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.gbelementen = new System.Windows.Forms.GroupBox();
            this.gbModes = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbelementen.SuspendLayout();
            this.gbModes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbActor
            // 
            this.rbActor.AutoSize = true;
            this.rbActor.Location = new System.Drawing.Point(6, 22);
            this.rbActor.Name = "rbActor";
            this.rbActor.Size = new System.Drawing.Size(50, 17);
            this.rbActor.TabIndex = 2;
            this.rbActor.TabStop = true;
            this.rbActor.Text = "Actor";
            this.rbActor.UseVisualStyleBackColor = true;
            // 
            // rbUseCase
            // 
            this.rbUseCase.AutoSize = true;
            this.rbUseCase.Location = new System.Drawing.Point(6, 45);
            this.rbUseCase.Name = "rbUseCase";
            this.rbUseCase.Size = new System.Drawing.Size(70, 17);
            this.rbUseCase.TabIndex = 3;
            this.rbUseCase.TabStop = true;
            this.rbUseCase.Text = "Use case";
            this.rbUseCase.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(6, 68);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 4;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbCreate
            // 
            this.rbCreate.AutoSize = true;
            this.rbCreate.Location = new System.Drawing.Point(6, 22);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(56, 17);
            this.rbCreate.TabIndex = 5;
            this.rbCreate.TabStop = true;
            this.rbCreate.Text = "Create";
            this.rbCreate.UseVisualStyleBackColor = true;
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(6, 45);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(55, 17);
            this.rbSelect.TabIndex = 6;
            this.rbSelect.TabStop = true;
            this.rbSelect.Text = "Select";
            this.rbSelect.UseVisualStyleBackColor = true;
            // 
            // gbelementen
            // 
            this.gbelementen.Controls.Add(this.rbUseCase);
            this.gbelementen.Controls.Add(this.rbActor);
            this.gbelementen.Controls.Add(this.rbLine);
            this.gbelementen.Location = new System.Drawing.Point(12, 12);
            this.gbelementen.Name = "gbelementen";
            this.gbelementen.Size = new System.Drawing.Size(88, 100);
            this.gbelementen.TabIndex = 7;
            this.gbelementen.TabStop = false;
            this.gbelementen.Text = "Elementen";
            // 
            // gbModes
            // 
            this.gbModes.Controls.Add(this.rbCreate);
            this.gbModes.Controls.Add(this.rbSelect);
            this.gbModes.Location = new System.Drawing.Point(106, 12);
            this.gbModes.Name = "gbModes";
            this.gbModes.Size = new System.Drawing.Size(69, 100);
            this.gbModes.TabIndex = 8;
            this.gbModes.TabStop = false;
            this.gbModes.Text = "Modes";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(492, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(492, 41);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 340);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbModes);
            this.Controls.Add(this.gbelementen);
            this.Name = "Form1";
            this.Text = "Use Case Helper";
            this.gbelementen.ResumeLayout(false);
            this.gbelementen.PerformLayout();
            this.gbModes.ResumeLayout(false);
            this.gbModes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbActor;
        private System.Windows.Forms.RadioButton rbUseCase;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbCreate;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.GroupBox gbelementen;
        private System.Windows.Forms.GroupBox gbModes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

