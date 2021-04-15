
using System.Drawing;

namespace UML_Diagram_drawer
{
    partial class FormMain
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
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.button_AddForm = new System.Windows.Forms.Button();
            this.button_AddArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(537, 459);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMain_Paint);
            // 
            // button_AddForm
            // 
            this.button_AddForm.Location = new System.Drawing.Point(8, 8);
            this.button_AddForm.Name = "button_AddForm";
            this.button_AddForm.Size = new System.Drawing.Size(75, 23);
            this.button_AddForm.TabIndex = 1;
            this.button_AddForm.Text = "Add Form";
            this.button_AddForm.UseVisualStyleBackColor = true;
            this.button_AddForm.Click += new System.EventHandler(this.button_AddForm_Click);
            // 
            // button_AddArrow
            // 
            this.button_AddArrow.Location = new System.Drawing.Point(100, 8);
            this.button_AddArrow.Name = "button_AddArrow";
            this.button_AddArrow.Size = new System.Drawing.Size(75, 23);
            this.button_AddArrow.TabIndex = 2;
            this.button_AddArrow.Text = "Add Arrow";
            this.button_AddArrow.UseVisualStyleBackColor = true;
            this.button_AddArrow.Click += new System.EventHandler(this.button_AddArrow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 459);
            this.Controls.Add(this.button_AddArrow);
            this.Controls.Add(this.button_AddForm);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button button_AddForm;
        private System.Windows.Forms.Button button_AddArrow;
    }
}

