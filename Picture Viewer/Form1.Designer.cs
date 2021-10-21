
namespace Picture_Viewer
{
    partial class FormPictureViewer
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
            this.components = new System.ComponentModel.Container();
            this.StatusBarPicture = new System.Windows.Forms.StatusStrip();
            this.StatusLabelPictureName = new System.Windows.Forms.ToolStripStatusLabel();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.Btn_Start_Stop = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnShowSelectedPictures = new System.Windows.Forms.Button();
            this.BtnImportPictrue = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LablelMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Import_Pictures = new System.Windows.Forms.ToolStripMenuItem();
            this.Single_Mode = new System.Windows.Forms.ToolStripMenuItem();
            this.Mult_Mode = new System.Windows.Forms.ToolStripMenuItem();
            this.Slide_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.Change_Mode = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_Mode = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPictrueDialog = new System.Windows.Forms.OpenFileDialog();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.ListBoxPicture = new System.Windows.Forms.ListBox();
            this.PanelViewer = new System.Windows.Forms.Panel();
            this.PanelMultiMode = new System.Windows.Forms.Panel();
            this.PictureBoxSingle_SlideShow = new System.Windows.Forms.PictureBox();
            this.StatusBarPicture.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            this.PanelViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSingle_SlideShow)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusBarPicture
            // 
            this.StatusBarPicture.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBarPicture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelPictureName});
            this.StatusBarPicture.Location = new System.Drawing.Point(0, 428);
            this.StatusBarPicture.Name = "StatusBarPicture";
            this.StatusBarPicture.Size = new System.Drawing.Size(800, 22);
            this.StatusBarPicture.TabIndex = 0;
            this.StatusBarPicture.Visible = false;
            // 
            // StatusLabelPictureName
            // 
            this.StatusLabelPictureName.Name = "StatusLabelPictureName";
            this.StatusLabelPictureName.Size = new System.Drawing.Size(0, 16);
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.DarkGray;
            this.PanelBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelBottom.Controls.Add(this.Btn_Start_Stop);
            this.PanelBottom.Controls.Add(this.BtnClear);
            this.PanelBottom.Controls.Add(this.BtnShowSelectedPictures);
            this.PanelBottom.Controls.Add(this.BtnImportPictrue);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 472);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1044, 49);
            this.PanelBottom.TabIndex = 1;
            // 
            // Btn_Start_Stop
            // 
            this.Btn_Start_Stop.AutoSize = true;
            this.Btn_Start_Stop.BackColor = System.Drawing.Color.Cornsilk;
            this.Btn_Start_Stop.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Start_Stop.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Btn_Start_Stop.ForeColor = System.Drawing.Color.Green;
            this.Btn_Start_Stop.Location = new System.Drawing.Point(365, 0);
            this.Btn_Start_Stop.Margin = new System.Windows.Forms.Padding(100);
            this.Btn_Start_Stop.Name = "Btn_Start_Stop";
            this.Btn_Start_Stop.Size = new System.Drawing.Size(225, 45);
            this.Btn_Start_Stop.TabIndex = 3;
            this.Btn_Start_Stop.Text = "Stop";
            this.Btn_Start_Stop.UseVisualStyleBackColor = false;
            this.Btn_Start_Stop.Visible = false;
            this.Btn_Start_Stop.Click += new System.EventHandler(this.Btn_Start_Stop_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.Cornsilk;
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClear.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnClear.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnClear.Location = new System.Drawing.Point(590, 0);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(100);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(225, 45);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear Pictures";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Visible = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnShowSelectedPictures
            // 
            this.BtnShowSelectedPictures.AutoSize = true;
            this.BtnShowSelectedPictures.BackColor = System.Drawing.Color.Cornsilk;
            this.BtnShowSelectedPictures.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnShowSelectedPictures.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnShowSelectedPictures.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnShowSelectedPictures.Location = new System.Drawing.Point(815, 0);
            this.BtnShowSelectedPictures.Margin = new System.Windows.Forms.Padding(100);
            this.BtnShowSelectedPictures.Name = "BtnShowSelectedPictures";
            this.BtnShowSelectedPictures.Size = new System.Drawing.Size(225, 45);
            this.BtnShowSelectedPictures.TabIndex = 1;
            this.BtnShowSelectedPictures.Text = "Show Selected Pictures";
            this.BtnShowSelectedPictures.UseVisualStyleBackColor = false;
            this.BtnShowSelectedPictures.Visible = false;
            this.BtnShowSelectedPictures.Click += new System.EventHandler(this.BtnShowSelectedPictures_Click_1);
            // 
            // BtnImportPictrue
            // 
            this.BtnImportPictrue.AutoSize = true;
            this.BtnImportPictrue.BackColor = System.Drawing.Color.Cornsilk;
            this.BtnImportPictrue.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnImportPictrue.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnImportPictrue.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnImportPictrue.Location = new System.Drawing.Point(0, 0);
            this.BtnImportPictrue.Margin = new System.Windows.Forms.Padding(105, 90, 105, 90);
            this.BtnImportPictrue.Name = "BtnImportPictrue";
            this.BtnImportPictrue.Size = new System.Drawing.Size(303, 45);
            this.BtnImportPictrue.TabIndex = 0;
            this.BtnImportPictrue.Text = "Import Picture";
            this.BtnImportPictrue.UseVisualStyleBackColor = false;
            this.BtnImportPictrue.Click += new System.EventHandler(this.BtnImportPictrue_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.DarkGray;
            this.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTop.Controls.Add(this.LablelMode);
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1044, 42);
            this.PanelTop.TabIndex = 2;
            // 
            // LablelMode
            // 
            this.LablelMode.AutoSize = true;
            this.LablelMode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LablelMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.LablelMode.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LablelMode.ForeColor = System.Drawing.Color.Lime;
            this.LablelMode.Location = new System.Drawing.Point(1038, 0);
            this.LablelMode.Name = "LablelMode";
            this.LablelMode.Size = new System.Drawing.Size(2, 33);
            this.LablelMode.TabIndex = 1;
            this.LablelMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click right to select mode or exit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Import_Pictures,
            this.Single_Mode,
            this.Mult_Mode,
            this.Slide_Show,
            this.Change_Mode,
            this.Exit_Mode});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 148);
            this.contextMenuStrip1.Text = "menu";
            // 
            // Import_Pictures
            // 
            this.Import_Pictures.Name = "Import_Pictures";
            this.Import_Pictures.Size = new System.Drawing.Size(178, 24);
            this.Import_Pictures.Text = "Import Pictures";
            this.Import_Pictures.Click += new System.EventHandler(this.Import_Pictures_Click);
            // 
            // Single_Mode
            // 
            this.Single_Mode.Name = "Single_Mode";
            this.Single_Mode.Size = new System.Drawing.Size(178, 24);
            this.Single_Mode.Text = "Single Mode";
            this.Single_Mode.Click += new System.EventHandler(this.Single_Mode_Click);
            // 
            // Mult_Mode
            // 
            this.Mult_Mode.Name = "Mult_Mode";
            this.Mult_Mode.Size = new System.Drawing.Size(178, 24);
            this.Mult_Mode.Text = "Multi Mode";
            this.Mult_Mode.Click += new System.EventHandler(this.Mult_Mode_Click);
            // 
            // Slide_Show
            // 
            this.Slide_Show.Name = "Slide_Show";
            this.Slide_Show.Size = new System.Drawing.Size(178, 24);
            this.Slide_Show.Text = "Slide Show";
            this.Slide_Show.Click += new System.EventHandler(this.Slide_Show_Click);
            // 
            // Change_Mode
            // 
            this.Change_Mode.Name = "Change_Mode";
            this.Change_Mode.Size = new System.Drawing.Size(178, 24);
            this.Change_Mode.Text = "Change Mode";
            this.Change_Mode.Visible = false;
            this.Change_Mode.Click += new System.EventHandler(this.Change_Mode_Click);
            // 
            // Exit_Mode
            // 
            this.Exit_Mode.Name = "Exit_Mode";
            this.Exit_Mode.Size = new System.Drawing.Size(178, 24);
            this.Exit_Mode.Text = "Exit";
            this.Exit_Mode.Click += new System.EventHandler(this.Exit_Mode_Click);
            // 
            // AddPictrueDialog
            // 
            this.AddPictrueDialog.InitialDirectory = "C:\\\\";
            this.AddPictrueDialog.Multiselect = true;
            // 
            // PanelLeft
            // 
            this.PanelLeft.Controls.Add(this.ListBoxPicture);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 42);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(250, 430);
            this.PanelLeft.TabIndex = 3;
            // 
            // ListBoxPicture
            // 
            this.ListBoxPicture.BackColor = System.Drawing.Color.Silver;
            this.ListBoxPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxPicture.Enabled = false;
            this.ListBoxPicture.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ListBoxPicture.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ListBoxPicture.FormattingEnabled = true;
            this.ListBoxPicture.ItemHeight = 21;
            this.ListBoxPicture.Location = new System.Drawing.Point(0, 0);
            this.ListBoxPicture.Name = "ListBoxPicture";
            this.ListBoxPicture.Size = new System.Drawing.Size(250, 430);
            this.ListBoxPicture.TabIndex = 5;
            this.ListBoxPicture.SelectedIndexChanged += new System.EventHandler(this.ListBoxPicture_SelectedIndexChanged);
            // 
            // PanelViewer
            // 
            this.PanelViewer.Controls.Add(this.PanelMultiMode);
            this.PanelViewer.Controls.Add(this.PictureBoxSingle_SlideShow);
            this.PanelViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelViewer.Location = new System.Drawing.Point(250, 42);
            this.PanelViewer.Name = "PanelViewer";
            this.PanelViewer.Size = new System.Drawing.Size(794, 430);
            this.PanelViewer.TabIndex = 4;
            // 
            // PanelMultiMode
            // 
            this.PanelMultiMode.AutoScroll = true;
            this.PanelMultiMode.AutoSize = true;
            this.PanelMultiMode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelMultiMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMultiMode.Location = new System.Drawing.Point(0, 0);
            this.PanelMultiMode.Name = "PanelMultiMode";
            this.PanelMultiMode.Size = new System.Drawing.Size(794, 430);
            this.PanelMultiMode.TabIndex = 10;
            this.PanelMultiMode.Visible = false;
            // 
            // PictureBoxSingle_SlideShow
            // 
            this.PictureBoxSingle_SlideShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxSingle_SlideShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxSingle_SlideShow.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxSingle_SlideShow.Name = "PictureBoxSingle_SlideShow";
            this.PictureBoxSingle_SlideShow.Size = new System.Drawing.Size(794, 430);
            this.PictureBoxSingle_SlideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxSingle_SlideShow.TabIndex = 7;
            this.PictureBoxSingle_SlideShow.TabStop = false;
            this.PictureBoxSingle_SlideShow.Visible = false;
            // 
            // FormPictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 521);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.PanelViewer);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.StatusBarPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(1066, 572);
            this.Name = "FormPictureViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StatusBarPicture.ResumeLayout(false);
            this.StatusBarPicture.PerformLayout();
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.PanelLeft.ResumeLayout(false);
            this.PanelViewer.ResumeLayout(false);
            this.PanelViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSingle_SlideShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBarPicture;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelPictureName;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnShowSelectedPictures;
        private System.Windows.Forms.Button BtnImportPictrue;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label LablelMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Import_Pictures;
        private System.Windows.Forms.ToolStripMenuItem Single_Mode;
        private System.Windows.Forms.ToolStripMenuItem Mult_Mode;
        private System.Windows.Forms.ToolStripMenuItem Slide_Show;
        private System.Windows.Forms.ToolStripMenuItem Exit_Mode;
        private System.Windows.Forms.OpenFileDialog AddPictrueDialog;
        private System.Windows.Forms.ToolStripMenuItem Change_Mode;
        private System.Windows.Forms.Button Btn_Start_Stop;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.ListBox ListBoxPicture;
        private System.Windows.Forms.Panel PanelViewer;
        private System.Windows.Forms.PictureBox PictureBoxSingle_SlideShow;
        private System.Windows.Forms.Panel PanelMultiMode;
    }
}

