
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
            this.toolStripButtonSaveImageFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonArrowAssociation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowSuccession = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowRealization = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowAggregationAndAssociation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrowCompositionAndAssociation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClassForm = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInterfaceForm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEditObject = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_AddForm = new System.Windows.Forms.Button();
            this.button_AddArrow = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBoxHamburger = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileInToJPEGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shotkeyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggregationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.successionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHamburger)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewFile,
            this.toolStripButtonOpenFile,
            this.toolStripButtonSaveFile,
            this.toolStripButtonSaveImageFile,
            this.toolStripSeparator,
            this.toolStripButtonCut,
            this.toolStripButtonCopy,
            this.toolStripButtonPaste,
            this.toolStripSeparator3,
            this.toolStripButtonArrowAssociation,
            this.toolStripButtonArrowSuccession,
            this.toolStripButtonArrowRealization,
            this.toolStripButtonArrowAggregationAndAssociation,
            this.toolStripButtonArrowCompositionAndAssociation,
            this.toolStripSeparator1,
            this.toolStripButtonClassForm,
            this.toolStripButtonInterfaceForm,
            this.toolStripSeparator2,
            this.toolStripButtonEditObject,
            this.toolStripButtonUndo,
            this.toolStripButtonRedo,
            this.toolStripButtonDelete,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1265, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButtonNewFile
            // 
            this.toolStripButtonNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewFile.Image")));
            this.toolStripButtonNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewFile.Name = "toolStripButtonNewFile";
            this.toolStripButtonNewFile.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonNewFile.Text = "New file";
            this.toolStripButtonNewFile.Click += new System.EventHandler(this.toolStripButtonNewFile_Click);
            // 
            // toolStripButtonOpenFile
            // 
            this.toolStripButtonOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenFile.Image")));
            this.toolStripButtonOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFile.Name = "toolStripButtonOpenFile";
            this.toolStripButtonOpenFile.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonOpenFile.Text = "Open file";
            this.toolStripButtonOpenFile.Click += new System.EventHandler(this.toolStripButtonOpenFile_Click);
            // 
            // toolStripButtonSaveFile
            // 
            this.toolStripButtonSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveFile.Image")));
            this.toolStripButtonSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveFile.Name = "toolStripButtonSaveFile";
            this.toolStripButtonSaveFile.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonSaveFile.Text = "Save as...";
            this.toolStripButtonSaveFile.ToolTipText = "Save as...";
            this.toolStripButtonSaveFile.Click += new System.EventHandler(this.toolStripButtonSaveFile_Click);
            // 
            // toolStripButtonSaveImageFile
            // 
            this.toolStripButtonSaveImageFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveImageFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveImageFile.Image")));
            this.toolStripButtonSaveImageFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveImageFile.Name = "toolStripButtonSaveImageFile";
            this.toolStripButtonSaveImageFile.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonSaveImageFile.Text = "Save in JPEG";
            this.toolStripButtonSaveImageFile.Click += new System.EventHandler(this.toolStripButtonSaveImageFile_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButtonCut
            // 
            this.toolStripButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCut.Image")));
            this.toolStripButtonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCut.Name = "toolStripButtonCut";
            this.toolStripButtonCut.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonCut.Text = "Cut object";
            this.toolStripButtonCut.ToolTipText = "Cut object";
            this.toolStripButtonCut.Click += new System.EventHandler(this.toolStripButtonCut_Click);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopy.Image")));
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonCopy.Text = "Copy object";
            this.toolStripButtonCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButtonCopy.ToolTipText = "Copy object";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.toolStripButtonCopy_Click);
            // 
            // toolStripButtonPaste
            // 
            this.toolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPaste.Image")));
            this.toolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPaste.Name = "toolStripButtonPaste";
            this.toolStripButtonPaste.Size = new System.Drawing.Size(23, 44);
            this.toolStripButtonPaste.Text = "Paste object";
            this.toolStripButtonPaste.ToolTipText = "Paste object";
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
            this.toolStripButtonArrowAssociation.ToolTipText = "Association arrow";
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
            this.toolStripButtonArrowSuccession.ToolTipText = "Succession arrow";
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
            this.toolStripButtonArrowRealization.ToolTipText = "Realization arrow";
            this.toolStripButtonArrowRealization.Click += new System.EventHandler(this.toolStripButtonArrowRealization_Click);
            // 
            // toolStripButtonArrowAggregationAndAssociation
            // 
            this.toolStripButtonArrowAggregationAndAssociation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonArrowAggregationAndAssociation.Image")));
            this.toolStripButtonArrowAggregationAndAssociation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonArrowAggregationAndAssociation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonArrowAggregationAndAssociation.Name = "toolStripButtonArrowAggregationAndAssociation";
            this.toolStripButtonArrowAggregationAndAssociation.Size = new System.Drawing.Size(79, 44);
            this.toolStripButtonArrowAggregationAndAssociation.Text = "Aggregation";
            this.toolStripButtonArrowAggregationAndAssociation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonArrowAggregationAndAssociation.ToolTipText = "Aggregation arrow";
            this.toolStripButtonArrowAggregationAndAssociation.Click += new System.EventHandler(this.toolStripButtonArrowAggregation_Click);
            // 
            // toolStripButtonArrowCompositionAndAssociation
            // 
            this.toolStripButtonArrowCompositionAndAssociation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonArrowCompositionAndAssociation.Image")));
            this.toolStripButtonArrowCompositionAndAssociation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonArrowCompositionAndAssociation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonArrowCompositionAndAssociation.Name = "toolStripButtonArrowCompositionAndAssociation";
            this.toolStripButtonArrowCompositionAndAssociation.Size = new System.Drawing.Size(80, 44);
            this.toolStripButtonArrowCompositionAndAssociation.Text = "Composition";
            this.toolStripButtonArrowCompositionAndAssociation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonArrowCompositionAndAssociation.ToolTipText = "Composition arrow";
            this.toolStripButtonArrowCompositionAndAssociation.Click += new System.EventHandler(this.toolStripButtonArrowComposition_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButtonClassForm
            // 
            this.toolStripButtonClassForm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClassForm.Image")));
            this.toolStripButtonClassForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonClassForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClassForm.Name = "toolStripButtonClassForm";
            this.toolStripButtonClassForm.Size = new System.Drawing.Size(100, 44);
            this.toolStripButtonClassForm.Text = "Class form";
            this.toolStripButtonClassForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonClassForm.Click += new System.EventHandler(this.toolStripButtonCreateClassForm_Click);
            // 
            // toolStripButtonInterfaceForm
            // 
            this.toolStripButtonInterfaceForm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInterfaceForm.Image")));
            this.toolStripButtonInterfaceForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonInterfaceForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInterfaceForm.Name = "toolStripButtonInterfaceForm";
            this.toolStripButtonInterfaceForm.Size = new System.Drawing.Size(98, 44);
            this.toolStripButtonInterfaceForm.Text = "Interface form";
            this.toolStripButtonInterfaceForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonInterfaceForm.Click += new System.EventHandler(this.toolStripButtonInterfaceForm_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButtonEditObject
            // 
            this.toolStripButtonEditObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditObject.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditObject.Image")));
            this.toolStripButtonEditObject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEditObject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditObject.Name = "toolStripButtonEditObject";
            this.toolStripButtonEditObject.Size = new System.Drawing.Size(40, 44);
            this.toolStripButtonEditObject.Text = "Edit form or arrow";
            this.toolStripButtonEditObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonEditObject.Click += new System.EventHandler(this.toolStripButtonEditObject_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(55, 44);
            this.toolStripButtonUndo.Text = "Undo";
            this.toolStripButtonUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
            this.toolStripButtonRedo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(55, 44);
            this.toolStripButtonRedo.Text = "Redo";
            this.toolStripButtonRedo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonRedo.Click += new System.EventHandler(this.toolStripButtonRedo_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(44, 44);
            this.toolStripButtonDelete.Text = "Delete object";
            this.toolStripButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 47);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxMain.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMain.MinimumSize = new System.Drawing.Size(2000, 1200);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(2000, 1200);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxMain_Paint);
            this.pictureBoxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseClick);
            this.pictureBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseDown);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseMove);
            this.pictureBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxMain);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1265, 552);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel1_Scroll);
            // 
            // button_AddForm
            // 
            this.button_AddForm.Location = new System.Drawing.Point(0, 0);
            this.button_AddForm.Name = "button_AddForm";
            this.button_AddForm.Size = new System.Drawing.Size(75, 23);
            this.button_AddForm.TabIndex = 0;
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
            // pictureBoxHamburger
            // 
            this.pictureBoxHamburger.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHamburger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxHamburger.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxHamburger.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHamburger.Image")));
            this.pictureBoxHamburger.Location = new System.Drawing.Point(0, 71);
            this.pictureBoxHamburger.Name = "pictureBoxHamburger";
            this.pictureBoxHamburger.Size = new System.Drawing.Size(1265, 25);
            this.pictureBoxHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHamburger.TabIndex = 6;
            this.pictureBoxHamburger.TabStop = false;
            this.pictureBoxHamburger.Click += new System.EventHandler(this.pictureBoxHamburger_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1265, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripStatusLabel
            // 
            this.statusStripStatusLabel.Name = "statusStripStatusLabel";
            this.statusStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusStripStatusLabel.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1265, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.saveFileInToJPEGToolStripMenuItem,
            this.closeProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewFileToolStripMenuItem
            // 
            this.createNewFileToolStripMenuItem.Name = "createNewFileToolStripMenuItem";
            this.createNewFileToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.createNewFileToolStripMenuItem.Text = "Create new file     Ctrl+N";
            this.createNewFileToolStripMenuItem.Click += new System.EventHandler(this.createNewFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.openFileToolStripMenuItem.Text = "Open file               Ctrl+O";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.saveFileToolStripMenuItem.Text = "Save                        Ctrl+S";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // saveFileInToJPEGToolStripMenuItem
            // 
            this.saveFileInToJPEGToolStripMenuItem.Name = "saveFileInToJPEGToolStripMenuItem";
            this.saveFileInToJPEGToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.saveFileInToJPEGToolStripMenuItem.Text = "Save file in to JPEG   Ctrl+J";
            this.saveFileInToJPEGToolStripMenuItem.Click += new System.EventHandler(this.saveFileInToJPEGToolStripMenuItem_Click);
            // 
            // closeProgramToolStripMenuItem
            // 
            this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.closeProgramToolStripMenuItem.Text = "Close program     Ctrl+X";
            this.closeProgramToolStripMenuItem.Click += new System.EventHandler(this.closeProgramToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyObjectsToolStripMenuItem,
            this.cutObjectsToolStripMenuItem,
            this.pasteObjectsToolStripMenuItem,
            this.editObjectsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyObjectsToolStripMenuItem
            // 
            this.copyObjectsToolStripMenuItem.Name = "copyObjectsToolStripMenuItem";
            this.copyObjectsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.copyObjectsToolStripMenuItem.Text = "Copy objects        Ctrl+C";
            this.copyObjectsToolStripMenuItem.Click += new System.EventHandler(this.copyObjectsToolStripMenuItem_Click);
            // 
            // cutObjectsToolStripMenuItem
            // 
            this.cutObjectsToolStripMenuItem.Name = "cutObjectsToolStripMenuItem";
            this.cutObjectsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cutObjectsToolStripMenuItem.Text = "Cut objects           Ctrl+T";
            this.cutObjectsToolStripMenuItem.Click += new System.EventHandler(this.cutObjectsToolStripMenuItem_Click);
            // 
            // pasteObjectsToolStripMenuItem
            // 
            this.pasteObjectsToolStripMenuItem.Name = "pasteObjectsToolStripMenuItem";
            this.pasteObjectsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.pasteObjectsToolStripMenuItem.Text = "Paste objects        Ctrl+P";
            this.pasteObjectsToolStripMenuItem.Click += new System.EventHandler(this.pasteObjectsToolStripMenuItem_Click);
            // 
            // editObjectsToolStripMenuItem
            // 
            this.editObjectsToolStripMenuItem.Name = "editObjectsToolStripMenuItem";
            this.editObjectsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.editObjectsToolStripMenuItem.Text = "Edit objects          Ctrl+E";
            this.editObjectsToolStripMenuItem.Click += new System.EventHandler(this.editObjectsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shotkeyListToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // shotkeyListToolStripMenuItem
            // 
            this.shotkeyListToolStripMenuItem.Name = "shotkeyListToolStripMenuItem";
            this.shotkeyListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shotkeyListToolStripMenuItem.Text = "Shotkey list";
            this.shotkeyListToolStripMenuItem.Click += new System.EventHandler(this.shotkeyListToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classToolStripMenuItem,
            this.interfaceToolStripMenuItem,
            this.aggregationToolStripMenuItem,
            this.compositionToolStripMenuItem,
            this.realizationToolStripMenuItem,
            this.successionToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.classToolStripMenuItem.Text = "Class                     Ctrl+L";
            this.classToolStripMenuItem.Click += new System.EventHandler(this.classToolStripMenuItem_Click);
            // 
            // interfaceToolStripMenuItem
            // 
            this.interfaceToolStripMenuItem.Name = "interfaceToolStripMenuItem";
            this.interfaceToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.interfaceToolStripMenuItem.Text = "Interface               Ctrl+I";
            this.interfaceToolStripMenuItem.Click += new System.EventHandler(this.interfaceToolStripMenuItem_Click);
            // 
            // aggregationToolStripMenuItem
            // 
            this.aggregationToolStripMenuItem.Name = "aggregationToolStripMenuItem";
            this.aggregationToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.aggregationToolStripMenuItem.Text = "Aggregation         Ctrl+A";
            this.aggregationToolStripMenuItem.Click += new System.EventHandler(this.aggregationToolStripMenuItem_Click);
            // 
            // compositionToolStripMenuItem
            // 
            this.compositionToolStripMenuItem.Name = "compositionToolStripMenuItem";
            this.compositionToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.compositionToolStripMenuItem.Text = "Composition         Ctrl+M";
            this.compositionToolStripMenuItem.Click += new System.EventHandler(this.compositionToolStripMenuItem_Click);
            // 
            // realizationToolStripMenuItem
            // 
            this.realizationToolStripMenuItem.Name = "realizationToolStripMenuItem";
            this.realizationToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.realizationToolStripMenuItem.Text = "Realization             Ctrl+R";
            this.realizationToolStripMenuItem.Click += new System.EventHandler(this.realizationToolStripMenuItem_Click);
            // 
            // successionToolStripMenuItem
            // 
            this.successionToolStripMenuItem.Name = "successionToolStripMenuItem";
            this.successionToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.successionToolStripMenuItem.Text = "Succession             Ctrl+S";
            this.successionToolStripMenuItem.Click += new System.EventHandler(this.successionToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.propertiesToolStripMenuItem.Text = "Question";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 670);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBoxHamburger);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "UML Diagram Tool";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHamburger)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonArrowSuccession;
        private System.Windows.Forms.ToolStripButton toolStripButtonArrowAssociation;
        private System.Windows.Forms.ToolStripButton toolStripButtonArrowRealization;
        private System.Windows.Forms.ToolStripButton toolStripButtonArrowAggregationAndAssociation;
        private System.Windows.Forms.ToolStripButton toolStripButtonArrowCompositionAndAssociation;
        private System.Windows.Forms.ToolStripButton toolStripButtonClassForm;
        private System.Windows.Forms.ToolStripButton toolStripButtonInterfaceForm;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveImageFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButtonCut;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_AddForm;
        private System.Windows.Forms.Button button_AddArrow;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditObject;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.PictureBox pictureBoxHamburger;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileInToJPEGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shotkeyListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggregationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem successionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
    }
}

