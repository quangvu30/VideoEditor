namespace VideoEditor
{
    partial class fVdeoEdtitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fVdeoEdtitor));
            this.tlc_TimeLine_VideoEditor = new AxTimelineAxLib.AxTimelineControl();
            this.btnAddVideo_VideoEditor = new MaterialSkin.Controls.MaterialButton();
            this.bntAddImages_VideoEditor = new MaterialSkin.Controls.MaterialButton();
            this.btnAddAudio_VideoEditor = new MaterialSkin.Controls.MaterialButton();
            this.btnExportToMp4_VidieoEditor = new MaterialSkin.Controls.MaterialButton();
            this.btnPlay_Pause_VideoEditor = new MaterialSkin.Controls.MaterialButton();
            this.btnStop_VideoEditor = new MaterialSkin.Controls.MaterialButton();
            this.ofd_OpenVideo_VideoEditor = new System.Windows.Forms.OpenFileDialog();
            this.sfd_ExportVideo_VideoEditor = new System.Windows.Forms.SaveFileDialog();
            this.pb_ExportProcess_VideoEditor = new System.Windows.Forms.ProgressBar();
            this.cbWithoutAudio_VideoEditor = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnClear_VideoEditor = new MaterialSkin.Controls.MaterialButton();
            this.cbbTimeLineScale = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbPreview_VideoEditor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tlc_TimeLine_VideoEditor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview_VideoEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // tlc_TimeLine_VideoEditor
            // 
            this.tlc_TimeLine_VideoEditor.Enabled = true;
            this.tlc_TimeLine_VideoEditor.Location = new System.Drawing.Point(16, 76);
            this.tlc_TimeLine_VideoEditor.Name = "tlc_TimeLine_VideoEditor";
            this.tlc_TimeLine_VideoEditor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tlc_TimeLine_VideoEditor.OcxState")));
            this.tlc_TimeLine_VideoEditor.Size = new System.Drawing.Size(893, 363);
            this.tlc_TimeLine_VideoEditor.TabIndex = 1;
            this.tlc_TimeLine_VideoEditor.OnConvertProgress += new AxTimelineAxLib._ITimelineControlEvents_OnConvertProgressEventHandler(this.tlc_TimeLine_VideoEditor_OnConvertProgress);
            this.tlc_TimeLine_VideoEditor.OnConvertCompleted += new System.EventHandler(this.tlc_TimeLine_VideoEditor_OnConvertCompleted);
            // 
            // btnAddVideo_VideoEditor
            // 
            this.btnAddVideo_VideoEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddVideo_VideoEditor.Depth = 0;
            this.btnAddVideo_VideoEditor.DrawShadows = true;
            this.btnAddVideo_VideoEditor.HighEmphasis = true;
            this.btnAddVideo_VideoEditor.Icon = null;
            this.btnAddVideo_VideoEditor.Location = new System.Drawing.Point(307, 448);
            this.btnAddVideo_VideoEditor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddVideo_VideoEditor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddVideo_VideoEditor.Name = "btnAddVideo_VideoEditor";
            this.btnAddVideo_VideoEditor.Size = new System.Drawing.Size(96, 36);
            this.btnAddVideo_VideoEditor.TabIndex = 2;
            this.btnAddVideo_VideoEditor.Text = "Add Video";
            this.btnAddVideo_VideoEditor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddVideo_VideoEditor.UseAccentColor = false;
            this.btnAddVideo_VideoEditor.UseVisualStyleBackColor = true;
            this.btnAddVideo_VideoEditor.Click += new System.EventHandler(this.btnAddVideo_VideoEditor_Click);
            // 
            // bntAddImages_VideoEditor
            // 
            this.bntAddImages_VideoEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntAddImages_VideoEditor.Depth = 0;
            this.bntAddImages_VideoEditor.DrawShadows = true;
            this.bntAddImages_VideoEditor.HighEmphasis = true;
            this.bntAddImages_VideoEditor.Icon = null;
            this.bntAddImages_VideoEditor.Location = new System.Drawing.Point(307, 496);
            this.bntAddImages_VideoEditor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bntAddImages_VideoEditor.MouseState = MaterialSkin.MouseState.HOVER;
            this.bntAddImages_VideoEditor.Name = "bntAddImages_VideoEditor";
            this.bntAddImages_VideoEditor.Size = new System.Drawing.Size(108, 36);
            this.bntAddImages_VideoEditor.TabIndex = 2;
            this.bntAddImages_VideoEditor.Text = "Add images";
            this.bntAddImages_VideoEditor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bntAddImages_VideoEditor.UseAccentColor = false;
            this.bntAddImages_VideoEditor.UseVisualStyleBackColor = true;
            this.bntAddImages_VideoEditor.Click += new System.EventHandler(this.bntAddImages_VideoEditor_Click);
            // 
            // btnAddAudio_VideoEditor
            // 
            this.btnAddAudio_VideoEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddAudio_VideoEditor.Depth = 0;
            this.btnAddAudio_VideoEditor.DrawShadows = true;
            this.btnAddAudio_VideoEditor.HighEmphasis = true;
            this.btnAddAudio_VideoEditor.Icon = null;
            this.btnAddAudio_VideoEditor.Location = new System.Drawing.Point(423, 448);
            this.btnAddAudio_VideoEditor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddAudio_VideoEditor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddAudio_VideoEditor.Name = "btnAddAudio_VideoEditor";
            this.btnAddAudio_VideoEditor.Size = new System.Drawing.Size(97, 36);
            this.btnAddAudio_VideoEditor.TabIndex = 2;
            this.btnAddAudio_VideoEditor.Text = "Add audio";
            this.btnAddAudio_VideoEditor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddAudio_VideoEditor.UseAccentColor = false;
            this.btnAddAudio_VideoEditor.UseVisualStyleBackColor = true;
            this.btnAddAudio_VideoEditor.Click += new System.EventHandler(this.btnAddAudio_VideoEditor_Click);
            // 
            // btnExportToMp4_VidieoEditor
            // 
            this.btnExportToMp4_VidieoEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportToMp4_VidieoEditor.Depth = 0;
            this.btnExportToMp4_VidieoEditor.DrawShadows = true;
            this.btnExportToMp4_VidieoEditor.HighEmphasis = true;
            this.btnExportToMp4_VidieoEditor.Icon = null;
            this.btnExportToMp4_VidieoEditor.Location = new System.Drawing.Point(775, 495);
            this.btnExportToMp4_VidieoEditor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportToMp4_VidieoEditor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportToMp4_VidieoEditor.Name = "btnExportToMp4_VidieoEditor";
            this.btnExportToMp4_VidieoEditor.Size = new System.Drawing.Size(134, 36);
            this.btnExportToMp4_VidieoEditor.TabIndex = 2;
            this.btnExportToMp4_VidieoEditor.Text = "Export to mp4";
            this.btnExportToMp4_VidieoEditor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportToMp4_VidieoEditor.UseAccentColor = false;
            this.btnExportToMp4_VidieoEditor.UseVisualStyleBackColor = true;
            this.btnExportToMp4_VidieoEditor.Click += new System.EventHandler(this.btnExportToMp4_VidieoEditor_Click);
            // 
            // btnPlay_Pause_VideoEditor
            // 
            this.btnPlay_Pause_VideoEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlay_Pause_VideoEditor.Depth = 0;
            this.btnPlay_Pause_VideoEditor.DrawShadows = true;
            this.btnPlay_Pause_VideoEditor.HighEmphasis = true;
            this.btnPlay_Pause_VideoEditor.Icon = null;
            this.btnPlay_Pause_VideoEditor.Location = new System.Drawing.Point(733, 447);
            this.btnPlay_Pause_VideoEditor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPlay_Pause_VideoEditor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlay_Pause_VideoEditor.Name = "btnPlay_Pause_VideoEditor";
            this.btnPlay_Pause_VideoEditor.Size = new System.Drawing.Size(110, 36);
            this.btnPlay_Pause_VideoEditor.TabIndex = 2;
            this.btnPlay_Pause_VideoEditor.Text = "Play/Pause";
            this.btnPlay_Pause_VideoEditor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPlay_Pause_VideoEditor.UseAccentColor = false;
            this.btnPlay_Pause_VideoEditor.UseVisualStyleBackColor = true;
            this.btnPlay_Pause_VideoEditor.Click += new System.EventHandler(this.btnPlay_Pause_VideoEditor_Click);
            // 
            // btnStop_VideoEditor
            // 
            this.btnStop_VideoEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop_VideoEditor.Depth = 0;
            this.btnStop_VideoEditor.DrawShadows = true;
            this.btnStop_VideoEditor.HighEmphasis = true;
            this.btnStop_VideoEditor.Icon = null;
            this.btnStop_VideoEditor.Location = new System.Drawing.Point(851, 448);
            this.btnStop_VideoEditor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStop_VideoEditor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop_VideoEditor.Name = "btnStop_VideoEditor";
            this.btnStop_VideoEditor.Size = new System.Drawing.Size(58, 36);
            this.btnStop_VideoEditor.TabIndex = 2;
            this.btnStop_VideoEditor.Text = "Stop";
            this.btnStop_VideoEditor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStop_VideoEditor.UseAccentColor = false;
            this.btnStop_VideoEditor.UseVisualStyleBackColor = true;
            this.btnStop_VideoEditor.Click += new System.EventHandler(this.btnStop_VideoEditor_Click);
            // 
            // ofd_OpenVideo_VideoEditor
            // 
            this.ofd_OpenVideo_VideoEditor.FileName = "openFileDialog1";
            // 
            // pb_ExportProcess_VideoEditor
            // 
            this.pb_ExportProcess_VideoEditor.Location = new System.Drawing.Point(6, 434);
            this.pb_ExportProcess_VideoEditor.Name = "pb_ExportProcess_VideoEditor";
            this.pb_ExportProcess_VideoEditor.Size = new System.Drawing.Size(468, 23);
            this.pb_ExportProcess_VideoEditor.TabIndex = 14;
            // 
            // cbWithoutAudio_VideoEditor
            // 
            this.cbWithoutAudio_VideoEditor.AutoSize = true;
            this.cbWithoutAudio_VideoEditor.Depth = 0;
            this.cbWithoutAudio_VideoEditor.Location = new System.Drawing.Point(159, 457);
            this.cbWithoutAudio_VideoEditor.Margin = new System.Windows.Forms.Padding(0);
            this.cbWithoutAudio_VideoEditor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbWithoutAudio_VideoEditor.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbWithoutAudio_VideoEditor.Name = "cbWithoutAudio_VideoEditor";
            this.cbWithoutAudio_VideoEditor.Ripple = true;
            this.cbWithoutAudio_VideoEditor.Size = new System.Drawing.Size(134, 37);
            this.cbWithoutAudio_VideoEditor.TabIndex = 15;
            this.cbWithoutAudio_VideoEditor.Text = "Without audio";
            this.cbWithoutAudio_VideoEditor.UseVisualStyleBackColor = true;
            // 
            // btnClear_VideoEditor
            // 
            this.btnClear_VideoEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear_VideoEditor.Depth = 0;
            this.btnClear_VideoEditor.DrawShadows = true;
            this.btnClear_VideoEditor.HighEmphasis = true;
            this.btnClear_VideoEditor.Icon = null;
            this.btnClear_VideoEditor.Location = new System.Drawing.Point(432, 496);
            this.btnClear_VideoEditor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear_VideoEditor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear_VideoEditor.Name = "btnClear_VideoEditor";
            this.btnClear_VideoEditor.Size = new System.Drawing.Size(88, 36);
            this.btnClear_VideoEditor.TabIndex = 16;
            this.btnClear_VideoEditor.Text = "      Clear       ";
            this.btnClear_VideoEditor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear_VideoEditor.UseAccentColor = false;
            this.btnClear_VideoEditor.UseVisualStyleBackColor = true;
            this.btnClear_VideoEditor.Click += new System.EventHandler(this.btnClear_VideoEditor_Click);
            // 
            // cbbTimeLineScale
            // 
            this.cbbTimeLineScale.AutoResize = false;
            this.cbbTimeLineScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbTimeLineScale.Depth = 0;
            this.cbbTimeLineScale.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbTimeLineScale.DropDownHeight = 174;
            this.cbbTimeLineScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimeLineScale.DropDownWidth = 121;
            this.cbbTimeLineScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbTimeLineScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbTimeLineScale.FormattingEnabled = true;
            this.cbbTimeLineScale.IntegralHeight = false;
            this.cbbTimeLineScale.ItemHeight = 43;
            this.cbbTimeLineScale.Items.AddRange(new object[] {
            "0.01",
            "0.03",
            "0.05",
            "0.1",
            "0.2",
            "0.4",
            "1.0",
            "2.0",
            "3.0"});
            this.cbbTimeLineScale.Location = new System.Drawing.Point(16, 445);
            this.cbbTimeLineScale.MaxDropDownItems = 4;
            this.cbbTimeLineScale.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbTimeLineScale.Name = "cbbTimeLineScale";
            this.cbbTimeLineScale.Size = new System.Drawing.Size(121, 49);
            this.cbbTimeLineScale.StartIndex = 0;
            this.cbbTimeLineScale.TabIndex = 17;
            this.cbbTimeLineScale.SelectedIndexChanged += new System.EventHandler(this.cbbTimeLineScale_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbPreview_VideoEditor);
            this.groupBox1.Controls.Add(this.pb_ExportProcess_VideoEditor);
            this.groupBox1.Location = new System.Drawing.Point(919, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 467);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // pbPreview_VideoEditor
            // 
            this.pbPreview_VideoEditor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbPreview_VideoEditor.Location = new System.Drawing.Point(6, 19);
            this.pbPreview_VideoEditor.Name = "pbPreview_VideoEditor";
            this.pbPreview_VideoEditor.Size = new System.Drawing.Size(468, 409);
            this.pbPreview_VideoEditor.TabIndex = 15;
            this.pbPreview_VideoEditor.TabStop = false;
            // 
            // fVdeoEdtitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbTimeLineScale);
            this.Controls.Add(this.btnClear_VideoEditor);
            this.Controls.Add(this.cbWithoutAudio_VideoEditor);
            this.Controls.Add(this.btnStop_VideoEditor);
            this.Controls.Add(this.btnPlay_Pause_VideoEditor);
            this.Controls.Add(this.btnExportToMp4_VidieoEditor);
            this.Controls.Add(this.btnAddAudio_VideoEditor);
            this.Controls.Add(this.bntAddImages_VideoEditor);
            this.Controls.Add(this.btnAddVideo_VideoEditor);
            this.Controls.Add(this.tlc_TimeLine_VideoEditor);
            this.Name = "fVdeoEdtitor";
            this.Text = "Create Video";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fVdeoEdtitor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tlc_TimeLine_VideoEditor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview_VideoEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxTimelineAxLib.AxTimelineControl tlc_TimeLine_VideoEditor;
        private MaterialSkin.Controls.MaterialButton btnAddVideo_VideoEditor;
        private MaterialSkin.Controls.MaterialButton bntAddImages_VideoEditor;
        private MaterialSkin.Controls.MaterialButton btnAddAudio_VideoEditor;
        private MaterialSkin.Controls.MaterialButton btnExportToMp4_VidieoEditor;
        private MaterialSkin.Controls.MaterialButton btnPlay_Pause_VideoEditor;
        private MaterialSkin.Controls.MaterialButton btnStop_VideoEditor;
        private System.Windows.Forms.OpenFileDialog ofd_OpenVideo_VideoEditor;
        private System.Windows.Forms.SaveFileDialog sfd_ExportVideo_VideoEditor;
        private System.Windows.Forms.ProgressBar pb_ExportProcess_VideoEditor;
        private MaterialSkin.Controls.MaterialCheckbox cbWithoutAudio_VideoEditor;
        private MaterialSkin.Controls.MaterialButton btnClear_VideoEditor;
        private MaterialSkin.Controls.MaterialComboBox cbbTimeLineScale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbPreview_VideoEditor;
    }
}