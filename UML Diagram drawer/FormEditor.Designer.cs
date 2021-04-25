
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
            this.buttonSetColor = new System.Windows.Forms.Button();
            this.trackBarLineThickness = new System.Windows.Forms.TrackBar();
            this.panelEditForm = new System.Windows.Forms.Panel();
            this.textBoxSelectTextField = new System.Windows.Forms.TextBox();
            this.comboBoxSetTypeArrow = new System.Windows.Forms.ComboBox();
            this.buttonSetColorText = new System.Windows.Forms.Button();
            this.buttonSetBackColor = new System.Windows.Forms.Button();
            this.trackBarSizeForm = new System.Windows.Forms.TrackBar();
            this.buttonSelectFont = new System.Windows.Forms.Button();
            this.buttonAddMethod = new System.Windows.Forms.Button();
            this.buttonAddField = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLineThickness)).BeginInit();
            this.panelEditForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetColor
            // 
            this.buttonSetColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetColor.Location = new System.Drawing.Point(3, 3);
            this.buttonSetColor.Name = "buttonSetColor";
            this.buttonSetColor.Size = new System.Drawing.Size(235, 40);
            this.buttonSetColor.TabIndex = 0;
            this.buttonSetColor.Text = "Color";
            this.buttonSetColor.UseVisualStyleBackColor = true;
            this.buttonSetColor.Click += new System.EventHandler(this.buttonColorChoice_Click);
            // 
            // trackBarLineThickness
            // 
            this.trackBarLineThickness.Location = new System.Drawing.Point(3, 141);
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
            this.panelEditForm.Controls.Add(this.textBoxSelectTextField);
            this.panelEditForm.Controls.Add(this.comboBoxSetTypeArrow);
            this.panelEditForm.Controls.Add(this.buttonSetColorText);
            this.panelEditForm.Controls.Add(this.buttonSetColor);
            this.panelEditForm.Controls.Add(this.buttonSetBackColor);
            this.panelEditForm.Controls.Add(this.trackBarSizeForm);
            this.panelEditForm.Controls.Add(this.buttonSelectFont);
            this.panelEditForm.Controls.Add(this.buttonAddMethod);
            this.panelEditForm.Controls.Add(this.trackBarLineThickness);
            this.panelEditForm.Controls.Add(this.buttonAddField);
            this.panelEditForm.Location = new System.Drawing.Point(12, 12);
            this.panelEditForm.Name = "panelEditForm";
            this.panelEditForm.Size = new System.Drawing.Size(242, 517);
            this.panelEditForm.TabIndex = 3;
            // 
            // textBoxSelectTextField
            // 
            this.textBoxSelectTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSelectTextField.Location = new System.Drawing.Point(4, 409);
            this.textBoxSelectTextField.Multiline = true;
            this.textBoxSelectTextField.Name = "textBoxSelectTextField";
            this.textBoxSelectTextField.Size = new System.Drawing.Size(234, 105);
            this.textBoxSelectTextField.TabIndex = 6;
            this.textBoxSelectTextField.TextChanged += new System.EventHandler(this.textBoxSelectTextField_TextChanged);
            this.textBoxSelectTextField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxSelectTextField_MouseMove);
            // 
            // comboBoxSetTypeArrow
            // 
            this.comboBoxSetTypeArrow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetTypeArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSetTypeArrow.FormattingEnabled = true;
            this.comboBoxSetTypeArrow.Items.AddRange(new object[] {
            "Assotiation",
            "Succession",
            "Realization",
            "Aggregation",
            "Composition"});
            this.comboBoxSetTypeArrow.Location = new System.Drawing.Point(3, 181);
            this.comboBoxSetTypeArrow.Name = "comboBoxSetTypeArrow";
            this.comboBoxSetTypeArrow.Size = new System.Drawing.Size(235, 32);
            this.comboBoxSetTypeArrow.TabIndex = 2;
            this.comboBoxSetTypeArrow.SelectedIndexChanged += new System.EventHandler(this.comboBoxSetTypeArrow_SelectedIndexChanged);
            // 
            // buttonSetColorText
            // 
            this.buttonSetColorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetColorText.Location = new System.Drawing.Point(3, 49);
            this.buttonSetColorText.Name = "buttonSetColorText";
            this.buttonSetColorText.Size = new System.Drawing.Size(235, 40);
            this.buttonSetColorText.TabIndex = 4;
            this.buttonSetColorText.Text = "Color Text";
            this.buttonSetColorText.UseVisualStyleBackColor = true;
            this.buttonSetColorText.Click += new System.EventHandler(this.buttonColorTextChoice_Click);
            // 
            // buttonSetBackColor
            // 
            this.buttonSetBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetBackColor.Location = new System.Drawing.Point(3, 95);
            this.buttonSetBackColor.Name = "buttonSetBackColor";
            this.buttonSetBackColor.Size = new System.Drawing.Size(235, 40);
            this.buttonSetBackColor.TabIndex = 5;
            this.buttonSetBackColor.Text = "Back Color";
            this.buttonSetBackColor.UseVisualStyleBackColor = true;
            this.buttonSetBackColor.Click += new System.EventHandler(this.buttonSetBackColor_Click);
            // 
            // trackBarSizeForm
            // 
            this.trackBarSizeForm.Location = new System.Drawing.Point(3, 357);
            this.trackBarSizeForm.Maximum = 72;
            this.trackBarSizeForm.MaximumSize = new System.Drawing.Size(1000, 750);
            this.trackBarSizeForm.Minimum = 14;
            this.trackBarSizeForm.MinimumSize = new System.Drawing.Size(75, 50);
            this.trackBarSizeForm.Name = "trackBarSizeForm";
            this.trackBarSizeForm.Size = new System.Drawing.Size(235, 45);
            this.trackBarSizeForm.TabIndex = 5;
            this.trackBarSizeForm.Value = 14;
            this.trackBarSizeForm.Scroll += new System.EventHandler(this.trackBarSizeForm_Scroll);
            // 
            // buttonSelectFont
            // 
            this.buttonSelectFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectFont.Location = new System.Drawing.Point(3, 311);
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
            this.buttonAddMethod.Location = new System.Drawing.Point(0, 265);
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
            this.buttonAddField.Location = new System.Drawing.Point(3, 219);
            this.buttonAddField.Name = "buttonAddField";
            this.buttonAddField.Size = new System.Drawing.Size(235, 40);
            this.buttonAddField.TabIndex = 0;
            this.buttonAddField.Text = "Add Field";
            this.buttonAddField.UseVisualStyleBackColor = true;
            this.buttonAddField.Click += new System.EventHandler(this.buttonAddField_Click);
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 541);
            this.Controls.Add(this.panelEditForm);
            this.Name = "FormEditor";
            this.Text = "FormEditor";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditor_FormClosing);
            this.Load += new System.EventHandler(this.FormEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLineThickness)).EndInit();
            this.panelEditForm.ResumeLayout(false);
            this.panelEditForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorCoiseDialog;
        private System.Windows.Forms.TrackBar trackBarLineThickness;
        private System.Windows.Forms.Panel panelEditForm;
        private System.Windows.Forms.Button buttonAddMethod;
        private System.Windows.Forms.Button buttonAddField;
        private System.Windows.Forms.Button buttonSelectFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TrackBar trackBarSizeForm;
        private System.Windows.Forms.Button buttonSetColorText;
        private System.Windows.Forms.Button buttonSetBackColor;
        private System.Windows.Forms.ComboBox comboBoxSetTypeArrow;
        private System.Windows.Forms.Button buttonSetColor;
        private System.Windows.Forms.TextBox textBoxSelectTextField;
    }
}