
namespace UML_Diagram_drawer
{
    partial class FormEditor
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
            this.colorCoiseDialog = new System.Windows.Forms.ColorDialog();
            this.buttonColorChoice = new System.Windows.Forms.Button();
            this.trackBarLineThickness = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBarSizeForm = new System.Windows.Forms.TrackBar();
            this.buttonSelectFont = new System.Windows.Forms.Button();
            this.buttonAddMethod = new System.Windows.Forms.Button();
            this.buttonAddField = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.buttonLineThickness = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLineThickness)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonColorChoice
            // 
            this.buttonColorChoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonColorChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonColorChoice.Location = new System.Drawing.Point(0, 0);
            this.buttonColorChoice.Name = "buttonColorChoice";
            this.buttonColorChoice.Size = new System.Drawing.Size(235, 40);
            this.buttonColorChoice.TabIndex = 0;
            this.buttonColorChoice.Text = "Color choice";
            this.buttonColorChoice.UseVisualStyleBackColor = true;
            this.buttonColorChoice.Click += new System.EventHandler(this.buttonColorChoice_Click);
            // 
            // trackBarLineThickness
            // 
            this.trackBarLineThickness.Location = new System.Drawing.Point(0, 92);
            this.trackBarLineThickness.Maximum = 20;
            this.trackBarLineThickness.MaximumSize = new System.Drawing.Size(500, 500);
            this.trackBarLineThickness.Minimum = 1;
            this.trackBarLineThickness.MinimumSize = new System.Drawing.Size(100, 50);
            this.trackBarLineThickness.Name = "trackBarLineThickness";
            this.trackBarLineThickness.Size = new System.Drawing.Size(235, 45);
            this.trackBarLineThickness.TabIndex = 1;
            this.trackBarLineThickness.Value = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.trackBarSizeForm);
            this.panel2.Controls.Add(this.buttonSelectFont);
            this.panel2.Controls.Add(this.buttonAddMethod);
            this.panel2.Controls.Add(this.buttonAddField);
            this.panel2.Location = new System.Drawing.Point(0, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 197);
            this.panel2.TabIndex = 3;
            // 
            // trackBarSizeForm
            // 
            this.trackBarSizeForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarSizeForm.Location = new System.Drawing.Point(0, 147);
            this.trackBarSizeForm.Maximum = 100;
            this.trackBarSizeForm.MaximumSize = new System.Drawing.Size(1000, 750);
            this.trackBarSizeForm.Minimum = 1;
            this.trackBarSizeForm.MinimumSize = new System.Drawing.Size(75, 50);
            this.trackBarSizeForm.Name = "trackBarSizeForm";
            this.trackBarSizeForm.Size = new System.Drawing.Size(235, 50);
            this.trackBarSizeForm.TabIndex = 5;
            this.trackBarSizeForm.Value = 30;
            this.trackBarSizeForm.Scroll += new System.EventHandler(this.trackBarSizeForm_Scroll);
            // 
            // buttonSelectFont
            // 
            this.buttonSelectFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectFont.Location = new System.Drawing.Point(0, 92);
            this.buttonSelectFont.Name = "buttonSelectFont";
            this.buttonSelectFont.Size = new System.Drawing.Size(235, 40);
            this.buttonSelectFont.TabIndex = 4;
            this.buttonSelectFont.Text = "Font";
            this.buttonSelectFont.UseVisualStyleBackColor = true;
            // 
            // buttonAddMethod
            // 
            this.buttonAddMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddMethod.Location = new System.Drawing.Point(0, 46);
            this.buttonAddMethod.Name = "buttonAddMethod";
            this.buttonAddMethod.Size = new System.Drawing.Size(235, 40);
            this.buttonAddMethod.TabIndex = 1;
            this.buttonAddMethod.Text = "Add Method";
            this.buttonAddMethod.UseVisualStyleBackColor = true;
            // 
            // buttonAddField
            // 
            this.buttonAddField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddField.Location = new System.Drawing.Point(0, 0);
            this.buttonAddField.Name = "buttonAddField";
            this.buttonAddField.Size = new System.Drawing.Size(235, 40);
            this.buttonAddField.TabIndex = 0;
            this.buttonAddField.Text = "Add Field";
            this.buttonAddField.UseVisualStyleBackColor = true;
            // 
            // buttonLineThickness
            // 
            this.buttonLineThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLineThickness.Location = new System.Drawing.Point(0, 46);
            this.buttonLineThickness.Name = "buttonLineThickness";
            this.buttonLineThickness.Size = new System.Drawing.Size(235, 40);
            this.buttonLineThickness.TabIndex = 4;
            this.buttonLineThickness.Text = "Line Thickness";
            this.buttonLineThickness.UseVisualStyleBackColor = true;
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 341);
            this.Controls.Add(this.buttonLineThickness);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.trackBarLineThickness);
            this.Controls.Add(this.buttonColorChoice);
            this.Name = "FormEditor";
            this.Text = "FormEditor";
            this.Load += new System.EventHandler(this.FormEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLineThickness)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorCoiseDialog;
        private System.Windows.Forms.Button buttonColorChoice;
        private System.Windows.Forms.TrackBar trackBarLineThickness;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAddMethod;
        private System.Windows.Forms.Button buttonAddField;
        private System.Windows.Forms.Button buttonSelectFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TrackBar trackBarSizeForm;
        private System.Windows.Forms.Button buttonLineThickness;
    }
}