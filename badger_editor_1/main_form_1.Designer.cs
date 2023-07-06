using System.Windows.Forms;//DragEventHandler()

namespace badger_editor_1
{
	partial class main_form
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyPasteLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.capitalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textSelectionColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundOpacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.templateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.asciiValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.welcomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label_zoom = new System.Windows.Forms.Label();
			this.label_menu_description1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Black;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.customizeToolStripMenuItem,
            this.viewToolStripMenuItem1,
            this.templateToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.infoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Black;
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator6,
            this.runToolStripMenuItem});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.newToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.BackColor = System.Drawing.Color.Gray;
			this.toolStripSeparator.ForeColor = System.Drawing.Color.Black;
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.BackColor = System.Drawing.Color.Gray;
			this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.printToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.printToolStripMenuItem.Text = "&Print";
			this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.BackColor = System.Drawing.Color.Gray;
			this.toolStripSeparator2.ForeColor = System.Drawing.Color.Black;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.clearToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.clearToolStripMenuItem.Text = "&Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.BackColor = System.Drawing.Color.Gray;
			this.toolStripSeparator6.ForeColor = System.Drawing.Color.Black;
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(143, 6);
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.runToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.runToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.runToolStripMenuItem.Text = "&Run";
			this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.BackColor = System.Drawing.Color.Black;
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.copyPasteLineToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator7,
            this.findToolStripMenuItem,
            this.toolStripSeparator8,
            this.capitalizeToolStripMenuItem,
            this.toolStripSeparator9,
            this.goToToolStripMenuItem});
			this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.undoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.undoToolStripMenuItem.Text = "&Undo";
			this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.redoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.redoToolStripMenuItem.Text = "&Redo";
			this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.BackColor = System.Drawing.Color.Gray;
			this.toolStripSeparator3.ForeColor = System.Drawing.Color.Black;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
			this.toolStripSeparator3.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.cutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.cutToolStripMenuItem.Text = "&Cut";
			this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.copyToolStripMenuItem.Text = "&Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.pasteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.pasteToolStripMenuItem.Text = "&Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
			// 
			// copyPasteLineToolStripMenuItem
			// 
			this.copyPasteLineToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.copyPasteLineToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.copyPasteLineToolStripMenuItem.Name = "copyPasteLineToolStripMenuItem";
			this.copyPasteLineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.copyPasteLineToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.copyPasteLineToolStripMenuItem.Text = "&Copy+Paste Line";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.BackColor = System.Drawing.Color.Gray;
			this.toolStripSeparator4.ForeColor = System.Drawing.Color.Black;
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(202, 6);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.selectAllToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.selectAllToolStripMenuItem.Text = "&Select All";
			this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.BackColor = System.Drawing.Color.Gray;
			this.toolStripSeparator7.ForeColor = System.Drawing.Color.Black;
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(202, 6);
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.findToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.findToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.findToolStripMenuItem.Text = "&Find";
			this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.BackColor = System.Drawing.Color.Gray;
			this.toolStripSeparator8.ForeColor = System.Drawing.Color.Black;
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(202, 6);
			// 
			// capitalizeToolStripMenuItem
			// 
			this.capitalizeToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.capitalizeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.capitalizeToolStripMenuItem.Name = "capitalizeToolStripMenuItem";
			this.capitalizeToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.capitalizeToolStripMenuItem.Text = "&Capitalize";
			this.capitalizeToolStripMenuItem.Click += new System.EventHandler(this.capitalizeToolStripMenuItem_Click);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.BackColor = System.Drawing.Color.Gray;
			this.toolStripSeparator9.ForeColor = System.Drawing.Color.Black;
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(202, 6);
			// 
			// goToToolStripMenuItem
			// 
			this.goToToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.goToToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
			this.goToToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.goToToolStripMenuItem.Text = "&Go To";
			this.goToToolStripMenuItem.Click += new System.EventHandler(this.goToToolStripMenuItem_Click);
			// 
			// customizeToolStripMenuItem
			// 
			this.customizeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
			this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.filePathToolStripMenuItem,
            this.defaultToolStripMenuItem,
            this.binaryToolStripMenuItem,
            this.tabSizeToolStripMenuItem,
            this.wordWrapToolStripMenuItem});
			this.customizeToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
			this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
			this.customizeToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.customizeToolStripMenuItem.Text = "&Customize";
			// 
			// textToolStripMenuItem1
			// 
			this.textToolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
			this.textToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textColorToolStripMenuItem,
            this.textFontToolStripMenuItem,
            this.textSelectionColorToolStripMenuItem});
			this.textToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
			this.textToolStripMenuItem1.Name = "textToolStripMenuItem1";
			this.textToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
			this.textToolStripMenuItem1.Text = "&Text";
			// 
			// textColorToolStripMenuItem
			// 
			this.textColorToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.textColorToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
			this.textColorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.textColorToolStripMenuItem.Text = "&Text Color";
			// 
			// textFontToolStripMenuItem
			// 
			this.textFontToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.textFontToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.textFontToolStripMenuItem.Name = "textFontToolStripMenuItem";
			this.textFontToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.textFontToolStripMenuItem.Text = "&Text Font";
			// 
			// textSelectionColorToolStripMenuItem
			// 
			this.textSelectionColorToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.textSelectionColorToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.textSelectionColorToolStripMenuItem.Name = "textSelectionColorToolStripMenuItem";
			this.textSelectionColorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.textSelectionColorToolStripMenuItem.Text = "&Text Selection Color";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.backgroundOpacityToolStripMenuItem});
			this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
			this.toolStripMenuItem1.Text = "&Background";
			// 
			// backgroundColorToolStripMenuItem
			// 
			this.backgroundColorToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.backgroundColorToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
			this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.backgroundColorToolStripMenuItem.Text = "&Background Color";
			// 
			// backgroundOpacityToolStripMenuItem
			// 
			this.backgroundOpacityToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.backgroundOpacityToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.backgroundOpacityToolStripMenuItem.Name = "backgroundOpacityToolStripMenuItem";
			this.backgroundOpacityToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.backgroundOpacityToolStripMenuItem.Text = "&Background Opacity";
			// 
			// filePathToolStripMenuItem
			// 
			this.filePathToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.filePathToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.filePathToolStripMenuItem.Name = "filePathToolStripMenuItem";
			this.filePathToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.filePathToolStripMenuItem.Text = "&File Path";
			this.filePathToolStripMenuItem.Click += new System.EventHandler(this.filePathToolStripMenuItem_Click);
			// 
			// defaultToolStripMenuItem
			// 
			this.defaultToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.defaultToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
			this.defaultToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.defaultToolStripMenuItem.Text = "&Default";
			this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
			// 
			// binaryToolStripMenuItem
			// 
			this.binaryToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.binaryToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
			this.binaryToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.binaryToolStripMenuItem.Text = "&Binary";
			this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
			// 
			// tabSizeToolStripMenuItem
			// 
			this.tabSizeToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.tabSizeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.tabSizeToolStripMenuItem.Name = "tabSizeToolStripMenuItem";
			this.tabSizeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.tabSizeToolStripMenuItem.Text = "&Tab Size";
			this.tabSizeToolStripMenuItem.Click += new System.EventHandler(this.tabSizeToolStripMenuItem_Click);
			// 
			// wordWrapToolStripMenuItem
			// 
			this.wordWrapToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.wordWrapToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
			this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.wordWrapToolStripMenuItem.Text = "&Word Wrap";
			this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem1
			// 
			this.viewToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
			this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem1});
			this.viewToolStripMenuItem1.ForeColor = System.Drawing.Color.Gray;
			this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
			this.viewToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem1.Text = "&View";
			// 
			// zoomToolStripMenuItem1
			// 
			this.zoomToolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
			this.zoomToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
			this.zoomToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
			this.zoomToolStripMenuItem1.Name = "zoomToolStripMenuItem1";
			this.zoomToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
			this.zoomToolStripMenuItem1.Text = "&Zoom";
			// 
			// zoomInToolStripMenuItem
			// 
			this.zoomInToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.zoomInToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
			this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
			this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			this.zoomInToolStripMenuItem.Text = "&Zoom In";
			// 
			// zoomOutToolStripMenuItem
			// 
			this.zoomOutToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.zoomOutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
			this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
			this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			this.zoomOutToolStripMenuItem.Text = "&Zoom Out";
			// 
			// templateToolStripMenuItem
			// 
			this.templateToolStripMenuItem.BackColor = System.Drawing.Color.Black;
			this.templateToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
			this.templateToolStripMenuItem.Name = "templateToolStripMenuItem";
			this.templateToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.templateToolStripMenuItem.Text = "&Template";
			// 
			// toolToolStripMenuItem
			// 
			this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asciiValueToolStripMenuItem});
			this.toolToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
			this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
			this.toolToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.toolToolStripMenuItem.Text = "&Tool";
			// 
			// asciiValueToolStripMenuItem
			// 
			this.asciiValueToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.asciiValueToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.asciiValueToolStripMenuItem.Name = "asciiValueToolStripMenuItem";
			this.asciiValueToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.asciiValueToolStripMenuItem.Text = "&Ascii Value";
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
			this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem,
            this.welcomeToolStripMenuItem,
            this.toolStripSeparator10,
            this.userToolStripMenuItem,
            this.appToolStripMenuItem,
            this.fileToolStripMenuItem2});
			this.infoToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.infoToolStripMenuItem.Text = "&Info";
			this.infoToolStripMenuItem.MouseEnter += new System.EventHandler(this.helpToolStripMenuItem_MouseEnter);
			this.infoToolStripMenuItem.MouseLeave += new System.EventHandler(this.helpToolStripMenuItem_MouseLeave);
			this.infoToolStripMenuItem.MouseHover += new System.EventHandler(this.helpToolStripMenuItem_MouseHover);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.searchToolStripMenuItem.Text = "&Search";
			this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.BackColor = System.Drawing.Color.Gray;
			this.toolStripSeparator5.ForeColor = System.Drawing.Color.Black;
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.aboutToolStripMenuItem.Image = global::badger_editor_1.Properties.Resources.badger_1;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// welcomeToolStripMenuItem
			// 
			this.welcomeToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.welcomeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.welcomeToolStripMenuItem.Name = "welcomeToolStripMenuItem";
			this.welcomeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.welcomeToolStripMenuItem.Text = "&Welcome";
			this.welcomeToolStripMenuItem.Click += new System.EventHandler(this.welcomeToolStripMenuItem_Click);
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.BackColor = System.Drawing.Color.Gray;
			this.toolStripSeparator10.ForeColor = System.Drawing.Color.Black;
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(177, 6);
			// 
			// userToolStripMenuItem
			// 
			this.userToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.userToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.userToolStripMenuItem.Name = "userToolStripMenuItem";
			this.userToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.userToolStripMenuItem.Text = "&User";
			this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
			// 
			// appToolStripMenuItem
			// 
			this.appToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.appToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.appToolStripMenuItem.Name = "appToolStripMenuItem";
			this.appToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.appToolStripMenuItem.Text = "&Application";
			this.appToolStripMenuItem.Click += new System.EventHandler(this.appToolStripMenuItem_Click);
			// 
			// fileToolStripMenuItem2
			// 
			this.fileToolStripMenuItem2.BackColor = System.Drawing.Color.Gray;
			this.fileToolStripMenuItem2.ForeColor = System.Drawing.Color.Black;
			this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
			this.fileToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
			this.fileToolStripMenuItem2.Text = "&File";
			this.fileToolStripMenuItem2.Click += new System.EventHandler(this.fileToolStripMenuItem2_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.AcceptsTab = true;
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.BackColor = System.Drawing.Color.Black;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.EnableAutoDragDrop = true;
			this.richTextBox1.ForeColor = System.Drawing.Color.Gray;
			this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.richTextBox1.Location = new System.Drawing.Point(23, 24);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(777, 403);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			this.richTextBox1.WordWrap = false;
			this.richTextBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.richTextBox1_DragDrop);
			this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
			this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
			this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Controls.Add(this.label_zoom);
			this.panel1.Controls.Add(this.label_menu_description1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 430);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 20);
			this.panel1.TabIndex = 2;
			// 
			// label_zoom
			// 
			this.label_zoom.AutoSize = true;
			this.label_zoom.Location = new System.Drawing.Point(393, -1);
			this.label_zoom.Name = "label_zoom";
			this.label_zoom.Size = new System.Drawing.Size(35, 15);
			this.label_zoom.TabIndex = 5;
			this.label_zoom.Text = "100%";
			// 
			// label_menu_description1
			// 
			this.label_menu_description1.AutoSize = true;
			this.label_menu_description1.BackColor = System.Drawing.Color.Transparent;
			this.label_menu_description1.ForeColor = System.Drawing.Color.Black;
			this.label_menu_description1.Location = new System.Drawing.Point(30, 0);
			this.label_menu_description1.Name = "label_menu_description1";
			this.label_menu_description1.Size = new System.Drawing.Size(0, 15);
			this.label_menu_description1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(531, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 15);
			this.label1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.AutoSize = true;
			this.panel2.BackColor = System.Drawing.Color.Gray;
			this.panel2.Controls.Add(this.label2);
			this.panel2.ForeColor = System.Drawing.Color.Black;
			this.panel2.Location = new System.Drawing.Point(0, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(23, 426);
			this.panel2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "0";
			// 
			// main_form
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "main_form";
			this.Text = "BADGER_EDITOR!";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_1_FormClosing);
			this.Load += new System.EventHandler(this.main_1_Load);
			this.Shown += new System.EventHandler(this.main_1_Shown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem filePathToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
		private ToolStripMenuItem binaryToolStripMenuItem;
		private ToolStripMenuItem capitalizeToolStripMenuItem;
		private ToolStripMenuItem welcomeToolStripMenuItem;
		private ToolStripMenuItem wordWrapToolStripMenuItem;
		private ToolStripMenuItem templateToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator;
		private ToolStripSeparator toolStripSeparator6;
		private ToolStripMenuItem copyPasteLineToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripSeparator toolStripSeparator7;
		private ToolStripSeparator toolStripSeparator8;
		private Panel panel2;
		private Label label2;
		private ToolStripMenuItem toolToolStripMenuItem;
		private ToolStripMenuItem asciiValueToolStripMenuItem;
		private ToolStripMenuItem goToToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator9;
		private ToolStripSeparator toolStripSeparator10;
		private Label label_menu_description1;
		private ToolStripMenuItem tabSizeToolStripMenuItem;
		private Label label_zoom;
		private ToolStripMenuItem viewToolStripMenuItem1;
		private ToolStripMenuItem zoomToolStripMenuItem1;
		private ToolStripMenuItem zoomInToolStripMenuItem;
		private ToolStripMenuItem zoomOutToolStripMenuItem;
		private ToolStripMenuItem textToolStripMenuItem1;
		private ToolStripMenuItem textColorToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem backgroundColorToolStripMenuItem;
		private ToolStripMenuItem backgroundOpacityToolStripMenuItem;
		private ToolStripMenuItem textFontToolStripMenuItem;
		private ToolStripMenuItem textSelectionColorToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem userToolStripMenuItem;
		private ToolStripMenuItem fileToolStripMenuItem2;
		private ToolStripMenuItem appToolStripMenuItem;
	}
}

