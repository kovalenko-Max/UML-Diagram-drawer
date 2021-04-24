
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
            this.panelEditForm = new System.Windows.Forms.Panel();
            this.trackBarSizeForm = new System.Windows.Forms.TrackBar();
            this.buttonSelectFont = new System.Windows.Forms.Button();
            this.buttonAddMethod = new System.Windows.Forms.Button();
            this.buttonAddField = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.buttonColorTextChoice = new System.Windows.Forms.Button();
            this.buttonSetBackColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLineThickness)).BeginInit();
            this.panelEditForm.SuspendLayout();
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
            this.trackBarLineThickness.Location = new System.Drawing.Point(0, 149);
            this.trackBarLineThickness.Maximum = 20;
            this.trackBarLineThickness.MaximumSize = new System.Drawing.Size(500, 500);
            this.trackBarLineThickness.Minimum = 1;
            this.trackBarLineThickness.MinimumSize = new System.Drawing.Size(100, 50);
            this.trackBarLineThickness.Name = "trackBarLineThickness";
            this.trackBarLineThickness.Size = new System.Drawing.Size(235, 45);
            this.trackBarLineThickness.TabIndex = 1;
            this.trackBarLineThickness.Value = 1;
            this.trackBarLineThickness.Scroll += new System.EventHandler(this.trackBarLineThickness_Scroll);
            // 
            // panelEditForm
            // 
            this.panelEditForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditForm.Controls.Add(this.trackBarSizeForm);
            this.panelEditForm.Controls.Add(this.buttonSelectFont);
            this.panelEditForm.Controls.Add(this.buttonAddMethod);
            this.panelEditForm.Controls.Add(this.buttonAddField);
            this.panelEditForm.Location = new System.Drawing.Point(0, 200);
            this.panelEditForm.Name = "panelEditForm";
            this.panelEditForm.Size = new System.Drawing.Size(235, 197);
            this.panelEditForm.TabIndex = 3;
            // 
            // trackBarSizeForm
            // 
            this.trackBarSizeForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarSizeForm.Location = new System.Drawing.Point(0, 147);
            this.trackBarSizeForm.Maximum = 72;
            this.trackBarSizeForm.MaximumSize = new System.Drawing.Size(1000, 750);
            this.trackBarSizeForm.Minimum = 14;
            this.trackBarSizeForm.MinimumSize = new System.Drawing.Size(75, 50);
            this.trackBarSizeForm.Name = "trackBarSizeForm";
            this.trackBarSizeForm.Size = new System.Drawing.Size(235, 50);
            this.trackBarSizeForm.TabIndex = 5;
            this.trackBarSizeForm.Value = 14;
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
            this.buttonSelectFont.Click += new System.EventHandler(this.buttonSelectFont_Click);
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
            this.buttonAddMethod.Click += new System.EventHandler(this.buttonAddMethod_Click);
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
            this.buttonAddField.Click += new System.EventHandler(this.buttonAddField_Click);
            // 
            // buttonColorTextChoice
            // 
            this.buttonColorTextChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonColorTextChoice.Location = new System.Drawing.Point(0, 46);
            this.buttonColorTextChoice.Name = "buttonColorTextChoice";
            this.buttonColorTextChoice.Size = new System.Drawing.Size(235, 40);
            this.buttonColorTextChoice.TabIndex = 4;
            this.buttonColorTextChoice.Text = "Color text coice";
            this.buttonColorTextChoice.UseVisualStyleBackColor = true;
            this.buttonColorTextChoice.Click += new System.EventHandler(this.buttonColorTextChoice_Click);
            // 
            // buttonSetBackColor
            // 
            this.buttonSetBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetBackColor.Location = new System.Drawing.Point(0, 92);
            this.buttonSetBackColor.Name = "buttonSetBackColor";
            this.buttonSetBackColor.Size = new System.Drawing.Size(235, 40);
            this.buttonSetBackColor.TabIndex = 5;
            this.buttonSetBackColor.Text = "BackColor";
            this.buttonSetBackColor.UseVisualStyleBackColor = true;
            this.buttonSetBackColor.Click += new System.EventHandler(this.buttonSetBackColor_Click);
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 409);
            this.Controls.Add(this.buttonSetBackColor);
            this.Controls.Add(this.buttonColorTextChoice);
            this.Controls.Add(this.panelEditForm);
            this.Controls.Add(this.trackBarLineThickness);
            this.Controls.Add(this.buttonColorChoice);
            this.Name = "FormEditor";
            this.Text = "FormEditor";
            this.Load += new System.EventHandler(this.FormEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLineThickness)).EndInit();
            this.panelEditForm.ResumeLayout(false);
            this.panelEditForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorCoiseDialog;
        private System.Windows.Forms.Button buttonColorChoice;
        private System.Windows.Forms.TrackBar trackBarLineThickness;
        private System.Windows.Forms.Panel panelEditForm;
        private System.Windows.Forms.Button buttonAddMethod;
        private System.Windows.Forms.Button buttonAddField;
        private System.Windows.Forms.Button buttonSelectFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TrackBar trackBarSizeForm;
        private System.Windows.Forms.Button buttonColorTextChoice;
        private System.Windows.Forms.Button buttonSetBackColor;
    }
}