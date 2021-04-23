
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveImageFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditObject = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonArrowAssociation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowSuccession = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowRealization = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowAggregation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowAggregationAndAssociation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowComposition = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowCompositionAndAssociation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClassForm = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInterfaceForm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSetColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.button_AddForm = new System.Windows.Forms.Button();
            this.button_AddArrow = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewFile,
            this.toolStripButtonOpenFile,
            this.toolStripButtonSaveFile,
            this.toolStripButtonPrint,
            this.toolStripButtonSaveImageFile,
            this.toolStripSeparator,
            this.toolStripButton15,
            this.toolStripButton14,
            this.toolStripButtonEditObject,
            this.toolStripButtonCut,
            this.toolStripButtonCopy,
            this.toolStripButtonPaste,
            this.toolStripSeparator3,
            this.toolStripButtonArrowAssociation,
            this.toolStripButtonArrowSuccession,
            this.toolStripButtonArrowRealization,
            this.toolStripButtonArrowAggregation,
            this.toolStripButtonArrowAggregationAndAssociation,
            this.toolStripButtonArrowComposition,
            this.toolStripButtonArrowCompositionAndAssociation,
            this.toolStripSeparator1,
            this.toolStripButtonClassForm,
            this.toolStripButtonInterfaceForm,
            this.toolStripSeparator2,
            this.toolStripSetColor,
            this.toolStripButton13,
            this.toolStripSeparator4,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1400, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNewFile
            // 
            this.toolStripButtonNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewFile.Image")));
            this.toolStripButtonNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewFile.Name = "toolStripButtonNewFile";
            this.toolStripButtonNewFile.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonNewFile.Text = "&New";
            // 
            // toolStripButtonOpenFile
            // 
            this.toolStripButtonOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenFile.Image")));
            this.toolStripButtonOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFile.Name = "toolStripButtonOpenFile";
            this.toolStripButtonOpenFile.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonOpenFile.Text = "&Open";
            this.toolStripButtonOpenFile.Click += new System.EventHandler(this.toolStripButtonOpenFile_Click);
            // 
            // toolStripButtonSaveFile
            // 
            this.toolStripButtonSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveFile.Image")));
            this.toolStripButtonSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveFile.Name = "toolStripButtonSaveFile";
            this.toolStripButtonSaveFile.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonSaveFile.Text = "&Save";
            this.toolStripButtonSaveFile.Click += new System.EventHandler(this.toolStripButtonSaveFile_Click);
            // 
            // toolStripButtonPrint
            // toolStripButtonSaveImageFile
            // 
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonPrint.Text = "&Print";
            this.toolStripButtonSaveImageFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveImageFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveImageFile.Image")));
            this.toolStripButtonSaveImageFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveImageFile.Name = "toolStripButtonSaveImageFile";
            this.toolStripButtonSaveImageFile.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonSaveImageFile.Text = "&Print";
            this.toolStripButtonSaveImageFile.Click += new System.EventHandler(this.toolStripButtonSaveImageFile_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(38, 44);
            this.toolStripButton15.Text = "Redo";
            this.toolStripButton15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(40, 44);
            this.toolStripButton14.Text = "Undo";
            this.toolStripButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonEditObject
            // 
            this.toolStripButtonEditObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditObject.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditObject.Image")));
            this.toolStripButtonEditObject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditObject.Name = "toolStripButtonEditObject";
            this.toolStripButtonEditObject.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonEditObject.Text = "Edit";
            this.toolStripButtonEditObject.Click += new System.EventHandler(this.toolStripButtonEditObject_Click);
            // 
            // toolStripButtonCut
            // 
            this.toolStripButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCut.Image")));
            this.toolStripButtonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCut.Name = "toolStripButtonCut";
            this.toolStripButtonCut.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonCut.Text = "C&ut";
            this.toolStripButtonCut.Click += new System.EventHandler(this.toolStripButtonCut_Click);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopy.Image")));
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonCopy.Text = "&Copy";
            this.toolStripButtonCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButtonCopy.Click += new System.EventHandler(this.toolStripButtonCopy_Click);
            // 
            // toolStripButtonPaste
            // 
            this.toolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPaste.Image")));
            this.toolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPaste.Name = "toolStripButtonPaste";
            this.toolStripButtonPaste.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonPaste.Text = "&Paste";
            this.toolStripButtonPaste.Click += new System.EventHandler(this.toolStripButtonPaste_Click);
            this.toolStripButtonPaste.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PasteObject_MouseDown);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButtonArrowAssociation
            // 
            this.toolStripButtonArrowAssociation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonArrowAssociation.Image")));
            this.toolStripButtonArrowAssociation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonArrowAssociation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonArrowAssociation.Name = "toolStripButtonArrowAssociation";
            this.toolStripButtonArrowAssociation.Size = new System.Drawing.Size(79, 44);
            this.toolStripButtonArrowAssociation.Text = "Association";
            this.toolStripButtonArrowAssociation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonArrowAssociation.Click += new System.EventHandler(this.toolStripButtonArrowAssociation_Click);
            // 
            // toolStripButtonArrowSuccession
            // 
            this.toolStripButtonArrowSuccession.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonArrowSuccession.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonArrowSuccession.Image")));
            this.toolStripButtonArrowSuccession.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonArrowSuccession.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonArrowSuccession.Name = "toolStripButtonArrowSuccession";
            this.toolStripButtonArrowSuccession.Size = new System.Drawing.Size(79, 44);
            this.toolStripButtonArrowSuccession.Text = "Succession";
            this.toolStripButtonArrowSuccession.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonArrowSuccession.Click += new System.EventHandler(this.toolStripButtonArrowSuccession_Click);
            // 
            // toolStripButtonArrowRealization
            // 
            this.toolStripButtonArrowRealization.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonArrowRealization.Image")));
            this.toolStripButtonArrowRealization.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonArrowRealization.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonArrowRealization.Name = "toolStripButtonArrowRealization";
            this.toolStripButtonArrowRealization.Size = new System.Drawing.Size(79, 44);
            this.toolStripButtonArrowRealization.Text = "Realization";
            this.toolStripButtonArrowRealization.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonArrowRealization.Click += new System.EventHandler(this.toolStripButtonArrowRealization_Click);
            // 
            // toolStripButtonArrowAggregation
            // 
            this.toolStripButtonArrowAggregation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonArrowAggregation.Image")));
            this.toolStripButtonArrowAggregation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonArrowAggregation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonArrowAggregation.Name = "toolStripButtonArrowAggregation";
            this.toolStripButtonArrowAggregation.Size = new System.Drawing.Size(79, 44);
            this.toolStripButtonArrowAggregation.Text = "Aggregation";
            this.toolStripButtonArrowAggregation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonArrowAggregation.Click += new System.EventHandler(this.toolStripButtonArrowAggregation_Click);
            // 
            // toolStripButtonArrowAggregationAndAssociation
            // 
            this.toolStripButtonArrowAggregationAndAssociation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonArrowAggregationAndAssociation.Image")));
            this.toolStripButtonArrowAggregationAndAssociation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonArrowAggregationAndAssociation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonArrowAggregationAndAssociation.Name = "toolStripButtonArrowAggregationAndAssociation";
            this.toolStripButtonArrowAggregationAndAssociation.Size = new System.Drawing.Size(79, 44);
            this.toolStripButtonArrowAggregationAndAssociation.Text = "Aggrg/Assct";
            this.toolStripButtonArrowAggregationAndAssociation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonArrowAggregationAndAssociation.ToolTipText = "Aggrg&Assct";
            this.toolStripButtonArrowAggregationAndAssociation.Click += new System.EventHandler(this.toolStripButtonArrowAggregationAndAssociation_Click);
            // 
            // toolStripButtonArrowComposition
            // 
            this.toolStripButtonArrowComposition.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonArrowComposition.Image")));
            this.toolStripButtonArrowComposition.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonArrowComposition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonArrowComposition.Name = "toolStripButtonArrowComposition";
            this.toolStripButtonArrowComposition.Size = new System.Drawing.Size(80, 44);
            this.toolStripButtonArrowComposition.Text = "Composition";
            this.toolStripButtonArrowComposition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonArrowComposition.Click += new System.EventHandler(this.toolStripButtonArrowComposition_Click);
            // 
            // toolStripButtonArrowCompositionAndAssociation
            // 
            this.toolStripButtonArrowCompositionAndAssociation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonArrowCompositionAndAssociation.Image")));
            this.toolStripButtonArrowCompositionAndAssociation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonArrowCompositionAndAssociation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonArrowCompositionAndAssociation.Name = "toolStripButtonArrowCompositionAndAssociation";
            this.toolStripButtonArrowCompositionAndAssociation.Size = new System.Drawing.Size(79, 44);
            this.toolStripButtonArrowCompositionAndAssociation.Text = "Comp/Assct";
            this.toolStripButtonArrowCompositionAndAssociation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonArrowCompositionAndAssociation.Click += new System.EventHandler(this.toolStripButtonArrowCompositionAndAssociation_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButtonClassForm
            // 
            this.toolStripButtonClassForm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClassForm.Image")));
            this.toolStripButtonClassForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClassForm.Name = "toolStripButtonClassForm";
            this.toolStripButtonClassForm.Size = new System.Drawing.Size(45, 44);
            this.toolStripButtonClassForm.Text = "Form1";
            this.toolStripButtonClassForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonClassForm.Click += new System.EventHandler(this.toolStripButtonCreateClassForm_Click);
            // 
            // toolStripButtonInterfaceForm
            // 
            this.toolStripButtonInterfaceForm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInterfaceForm.Image")));
            this.toolStripButtonInterfaceForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInterfaceForm.Name = "toolStripButtonInterfaceForm";
            this.toolStripButtonInterfaceForm.Size = new System.Drawing.Size(45, 44);
            this.toolStripButtonInterfaceForm.Text = "Form2";
            this.toolStripButtonInterfaceForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSetColor
            // 
            this.toolStripSetColor.BackColor = System.Drawing.Color.Black;
            this.toolStripSetColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSetColor.ForeColor = System.Drawing.Color.White;
            this.toolStripSetColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSetColor.Image")));
            this.toolStripSetColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSetColor.Name = "toolStripSetColor";
            this.toolStripSetColor.Size = new System.Drawing.Size(40, 44);
            this.toolStripSetColor.Text = "Color";
            this.toolStripSetColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(57, 44);
            this.toolStripButton13.Text = "Trashcan";
            this.toolStripButton13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 47);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 44);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(1400, 673);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxMain_Paint);
            this.pictureBoxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseClick);
            this.pictureBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseDown);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseMove);
            this.pictureBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseUp);
            // 
            // button_AddForm
            // 
            this.button_AddForm.Location = new System.Drawing.Point(0, 211);
            this.button_AddForm.Name = "button_AddForm";
            this.button_AddForm.Size = new System.Drawing.Size(75, 23);
            this.button_AddForm.TabIndex = 1;
            this.button_AddForm.Text = "Add Form";
            this.button_AddForm.UseVisualStyleBackColor = true;
            // 
            // button_AddArrow
            // 
            this.button_AddArrow.Location = new System.Drawing.Point(0, 240);
            this.button_AddArrow.Name = "button_AddArrow";
            this.button_AddArrow.Size = new System.Drawing.Size(75, 23);
            this.button_AddArrow.TabIndex = 2;
            this.button_AddArrow.Text = "Add Arrow";
            this.button_AddArrow.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "UML diagrams|*.umld";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "UML diagrams|*.umld";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "JPEG Image|*.jpg";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1400, 673);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "FormMain";
            this.Text = "UML Diagram";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonArrowSuccession;
        private System.Windows.Forms.ToolStripButton toolStripButtonArrowAssociation;
        private System.Windows.Forms.ToolStripButton toolStripButtonArrowRealization;
        private System.Windows.Forms.ToolStripButton toolStripButtonArrowAggregation;
        private System.Windows.Forms.ToolStripButton toolStripButtonArrowAggregationAndAssociation;
        private System.Windows.Forms.ToolStripButton toolStripButtonArrowComposition;
        private System.Windows.Forms.ToolStripButton toolStripButtonArrowCompositionAndAssociation;
        private System.Windows.Forms.ToolStripButton toolStripButtonClassForm;
        private System.Windows.Forms.ToolStripButton toolStripButtonInterfaceForm;
        private System.Windows.Forms.ToolStripButton toolStripSetColor;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveImageFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButtonCut;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button button_AddForm;
        private System.Windows.Forms.Button button_AddArrow;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditObject;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

