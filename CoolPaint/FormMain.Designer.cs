namespace CoolPaint
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
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbLine = new System.Windows.Forms.ToolStripButton();
            this.tsbBroken = new System.Windows.Forms.ToolStripButton();
            this.tsbRectangle = new System.Windows.Forms.ToolStripButton();
            this.tsbEllipse = new System.Windows.Forms.ToolStripButton();
            this.tsbPolygon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslWidth = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslFillColor = new System.Windows.Forms.ToolStripLabel();
            this.tsbFillColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslLineColor = new System.Windows.Forms.ToolStripLabel();
            this.tsbLineColor = new System.Windows.Forms.ToolStripButton();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuMainStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pbMain)).BeginInit();
            this.menuMainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.tsbLine, this.tsbBroken, this.tsbRectangle, this.tsbEllipse, this.tsbPolygon, this.toolStripSeparator1, this.tslWidth, this.toolStripComboBox1, this.toolStripSeparator3, this.tslFillColor, this.tsbFillColor, this.toolStripSeparator2, this.tslLineColor, this.tsbLineColor});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(800, 25);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "tsMain";
            // 
            // tsbLine
            // 
            this.tsbLine.Checked = true;
            this.tsbLine.CheckOnClick = true;
            this.tsbLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLine.Image = ((System.Drawing.Image) (resources.GetObject("tsbLine.Image")));
            this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLine.Name = "tsbLine";
            this.tsbLine.Size = new System.Drawing.Size(33, 22);
            this.tsbLine.Text = "Line";
            this.tsbLine.ToolTipText = "Line";
            this.tsbLine.Click += new System.EventHandler(this.ToolButtonClick);
            // 
            // tsbBroken
            // 
            this.tsbBroken.CheckOnClick = true;
            this.tsbBroken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBroken.Image = ((System.Drawing.Image) (resources.GetObject("tsbBroken.Image")));
            this.tsbBroken.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBroken.Name = "tsbBroken";
            this.tsbBroken.Size = new System.Drawing.Size(48, 22);
            this.tsbBroken.Text = "Broken";
            this.tsbBroken.Click += new System.EventHandler(this.ToolButtonClick);
            // 
            // tsbRectangle
            // 
            this.tsbRectangle.CheckOnClick = true;
            this.tsbRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRectangle.Image = ((System.Drawing.Image) (resources.GetObject("tsbRectangle.Image")));
            this.tsbRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRectangle.Name = "tsbRectangle";
            this.tsbRectangle.Size = new System.Drawing.Size(63, 22);
            this.tsbRectangle.Text = "Rectangle";
            this.tsbRectangle.Click += new System.EventHandler(this.ToolButtonClick);
            // 
            // tsbEllipse
            // 
            this.tsbEllipse.CheckOnClick = true;
            this.tsbEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEllipse.Image = ((System.Drawing.Image) (resources.GetObject("tsbEllipse.Image")));
            this.tsbEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEllipse.Name = "tsbEllipse";
            this.tsbEllipse.Size = new System.Drawing.Size(44, 22);
            this.tsbEllipse.Text = "Ellipse";
            this.tsbEllipse.ToolTipText = "Ellipse";
            this.tsbEllipse.Click += new System.EventHandler(this.ToolButtonClick);
            // 
            // tsbPolygon
            // 
            this.tsbPolygon.CheckOnClick = true;
            this.tsbPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPolygon.Image = ((System.Drawing.Image) (resources.GetObject("tsbPolygon.Image")));
            this.tsbPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPolygon.Name = "tsbPolygon";
            this.tsbPolygon.Size = new System.Drawing.Size(55, 22);
            this.tsbPolygon.Text = "Polygon";
            this.tsbPolygon.Click += new System.EventHandler(this.ToolButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslWidth
            // 
            this.tslWidth.Name = "tslWidth";
            this.tslWidth.Size = new System.Drawing.Size(42, 22);
            this.tslWidth.Text = "Width:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBox1.Text = "1";
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tslFillColor
            // 
            this.tslFillColor.Name = "tslFillColor";
            this.tslFillColor.Size = new System.Drawing.Size(55, 22);
            this.tslFillColor.Text = "Fill color:";
            // 
            // tsbFillColor
            // 
            this.tsbFillColor.BackColor = System.Drawing.Color.Red;
            this.tsbFillColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbFillColor.Image = ((System.Drawing.Image) (resources.GetObject("tsbFillColor.Image")));
            this.tsbFillColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFillColor.Name = "tsbFillColor";
            this.tsbFillColor.Size = new System.Drawing.Size(23, 22);
            this.tsbFillColor.Click += new System.EventHandler(this.PickColor);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslLineColor
            // 
            this.tslLineColor.Name = "tslLineColor";
            this.tslLineColor.Size = new System.Drawing.Size(62, 22);
            this.tslLineColor.Text = "Line color:";
            // 
            // tsbLineColor
            // 
            this.tsbLineColor.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.tsbLineColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLineColor.Image = ((System.Drawing.Image) (resources.GetObject("tsbLineColor.Image")));
            this.tsbLineColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLineColor.Name = "tsbLineColor";
            this.tsbLineColor.Size = new System.Drawing.Size(23, 22);
            this.tsbLineColor.Click += new System.EventHandler(this.PickColor);
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.White;
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMain.Location = new System.Drawing.Point(0, 49);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(800, 481);
            this.pbMain.TabIndex = 1;
            this.pbMain.TabStop = false;
            this.pbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMain_Paint);
            this.pbMain.DoubleClick += new System.EventHandler(this.pbMain_DoubleClick);
            this.pbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseDown);
            this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseMove);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // menuMainStrip
            // 
            this.menuMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem, this.editToolStripMenuItem});
            this.menuMainStrip.Location = new System.Drawing.Point(0, 0);
            this.menuMainStrip.Name = "menuMainStrip";
            this.menuMainStrip.Size = new System.Drawing.Size(800, 24);
            this.menuMainStrip.TabIndex = 2;
            this.menuMainStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.openToolStripMenuItem, this.saveToolStripMenuItem, this.saveAsToolStripMenuItem, this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.undoToolStripMenuItem, this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.menuMainStrip);
            this.MainMenuStrip = this.menuMainStrip;
            this.Name = "FormMain";
            this.Text = "CoolPaint";
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pbMain)).EndInit();
            this.menuMainStrip.ResumeLayout(false);
            this.menuMainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuMainStrip;

        private System.Windows.Forms.ColorDialog colorDialog;

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripButton tsbLineColor;

        private System.Windows.Forms.ToolStripLabel tslLineColor;

        private System.Windows.Forms.ToolStripButton tsbFillColor;

        private System.Windows.Forms.ToolStripLabel tslFillColor;

        private System.Windows.Forms.ToolStripLabel tslWidth;

        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripButton tsbPolygon;

        private System.Windows.Forms.ToolStripButton tsbEllipse;

        private System.Windows.Forms.ToolStripButton tsbRectangle;

        private System.Windows.Forms.PictureBox pbMain;

        private System.Windows.Forms.ToolStripButton tsbBroken;
        private System.Windows.Forms.ToolStripButton tsbLine;

        private System.Windows.Forms.ToolStrip tsMain;

        #endregion
    }
}