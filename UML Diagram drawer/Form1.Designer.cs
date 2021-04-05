
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
            this.button_Realization = new System.Windows.Forms.Button();
            this.button_Succession = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Location = new System.Drawing.Point(12, 38);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(960, 454);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Click += new System.EventHandler(this.pictureBoxMain_Click);
            // 
            // button_Realization
            // 
            this.button_Realization.Location = new System.Drawing.Point(12, 9);
            this.button_Realization.Name = "button_Realization";
            this.button_Realization.Size = new System.Drawing.Size(75, 23);
            this.button_Realization.TabIndex = 1;
            this.button_Realization.Text = "Realization";
            this.button_Realization.UseVisualStyleBackColor = true;
            this.button_Realization.Click += new System.EventHandler(this.buttonRealization_Click);
            // 
            // button_Succession
            // 
            this.button_Succession.Location = new System.Drawing.Point(93, 9);
            this.button_Succession.Name = "button_Succession";
            this.button_Succession.Size = new System.Drawing.Size(75, 23);
            this.button_Succession.TabIndex = 2;
            this.button_Succession.TabStop = false;
            this.button_Succession.Text = "Succession";
            this.button_Succession.UseVisualStyleBackColor = true;
            this.button_Succession.Click += new System.EventHandler(this.button_Succession_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 504);
            this.Controls.Add(this.button_Succession);
            this.Controls.Add(this.button_Realization);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button button_Realization;
        private System.Windows.Forms.Button button_Succession;
    }
}

