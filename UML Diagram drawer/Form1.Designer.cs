
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
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonArrowAssociation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowSuccession = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowRealization = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowAggregation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowAggregationAndAssociation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowComposition = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowCompositionAndAssociation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCreateClassForm = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator3,
            this.toolStripButtonArrowAssociation,
            this.toolStripButtonArrowSuccession,
            this.toolStripButtonArrowRealization,
            this.toolStripButtonArrowAggregation,
            this.toolStripButtonArrowAggregationAndAssociation,
            this.toolStripButtonArrowComposition,
            this.toolStripButtonArrowCompositionAndAssociation,
            this.toolStripSeparator1,
            this.toolStripButtonCreateClassForm,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator2,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripButton14,
            this.toolStripButton15,
            this.toolStripSeparator4,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1145, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 44);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 44);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 44);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 44);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 44);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 44);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 44);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            this.pasteToolStripButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PasteObject_MouseDown);
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
            // toolStripButtonCreateClassForm
            // 
            this.toolStripButtonCreateClassForm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreateClassForm.Image")));
            this.toolStripButtonCreateClassForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreateClassForm.Name = "toolStripButtonCreateClassForm";
            this.toolStripButtonCreateClassForm.Size = new System.Drawing.Size(45, 44);
            this.toolStripButtonCreateClassForm.Text = "Form1";
            this.toolStripButtonCreateClassForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonCreateClassForm.Click += new System.EventHandler(this.toolStripButtonCreateClassForm_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(45, 44);
            this.toolStripButton9.Text = "Form2";
            this.toolStripButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(45, 44);
            this.toolStripButton10.Text = "Form3";
            this.toolStripButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(45, 44);
            this.toolStripButton11.Text = "Form4";
            this.toolStripButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.BackColor = System.Drawing.Color.Black;
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton12.ForeColor = System.Drawing.Color.White;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(40, 44);
            this.toolStripButton12.Text = "Color";
            this.toolStripButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton12.Click += new System.EventHandler(this.toolStripButton12_Click);
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
            // toolStripButton14
            // 
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(40, 44);
            this.toolStripButton14.Text = "Undo";
            this.toolStripButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // colorDialog1
            // 
            this.colorDialog1.HelpRequest += new System.EventHandler(this.toolStripButton12_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxMain.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(1400, 671);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Click += new System.EventHandler(this.pictureBoxMain_Click);
            this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxMain_Paint);
            this.pictureBoxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseClick);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseMove);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxMain);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1145, 382);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel1_Scroll);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1145, 429);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButtonCreateClassForm;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

