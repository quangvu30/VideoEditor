namespace VideoEditor
{
    partial class fVideoAudioCutting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fVideoAudioCutting));
            this.tlc_TimeLine_VideoSpliter = new AxTimelineAxLib.AxTimelineControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddVideo_VideoSpliter = new MaterialSkin.Controls.MaterialButton();
            this.cbWithoutAudio_VideoSplitor = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnAddAudio_VideoSpliter = new MaterialSkin.Controls.MaterialButton();
            this.ofd_OpenVideo_VideoSpliter = new System.Windows.Forms.OpenFileDialog();
            this.btnClear_VideoSpliter = new MaterialSkin.Controls.MaterialButton();
            this.btnPausePlay_VideoSpliter = new MaterialSkin.Controls.MaterialButton();
            this.btnStop_VideoSpliter = new MaterialSkin.Controls.MaterialButton();
            this.bntSplit_VideoSpliter = new MaterialSkin.Controls.MaterialButton();
            this.cbbScale_VideoSpliter = new MaterialSkin.Controls.MaterialComboBox();
            this.sfdSave_VideoSpliter = new System.Windows.Forms.SaveFileDialog();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tlc_TimeLine_VideoSpliter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlc_TimeLine_VideoSpliter
            // 
            this.tlc_TimeLine_VideoSpliter.Enabled = true;
            this.tlc_TimeLine_VideoSpliter.Location = new System.Drawing.Point(6, 70);
            this.tlc_TimeLine_VideoSpliter.Name = "tlc_TimeLine_VideoSpliter";
            this.tlc_TimeLine_VideoSpliter.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tlc_TimeLine_VideoSpliter.OcxState")));
            this.tlc_TimeLine_VideoSpliter.Size = new System.Drawing.Size(862, 376);
            this.tlc_TimeLine_VideoSpliter.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 468);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddVideo_VideoSpliter
            // 
            this.btnAddVideo_VideoSpliter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddVideo_VideoSpliter.Depth = 0;
            this.btnAddVideo_VideoSpliter.DrawShadows = true;
            this.btnAddVideo_VideoSpliter.HighEmphasis = true;
            this.btnAddVideo_VideoSpliter.Icon = null;
            this.btnAddVideo_VideoSpliter.Location = new System.Drawing.Point(6, 510);
            this.btnAddVideo_VideoSpliter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddVideo_VideoSpliter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddVideo_VideoSpliter.Name = "btnAddVideo_VideoSpliter";
            this.btnAddVideo_VideoSpliter.Size = new System.Drawing.Size(96, 36);
            this.btnAddVideo_VideoSpliter.TabIndex = 2;
            this.btnAddVideo_VideoSpliter.Text = "Add Video";
            this.btnAddVideo_VideoSpliter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddVideo_VideoSpliter.UseAccentColor = false;
            this.btnAddVideo_VideoSpliter.UseVisualStyleBackColor = true;
            this.btnAddVideo_VideoSpliter.Click += new System.EventHandler(this.btnAddVideo_VideoSpliter_Click);
            // 
            // cbWithoutAudio_VideoSplitor
            // 
            this.cbWithoutAudio_VideoSplitor.AutoSize = true;
            this.cbWithoutAudio_VideoSplitor.Depth = 0;
            this.cbWithoutAudio_VideoSplitor.Location = new System.Drawing.Point(167, 463);
            this.cbWithoutAudio_VideoSplitor.Margin = new System.Windows.Forms.Padding(0);
            this.cbWithoutAudio_VideoSplitor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbWithoutAudio_VideoSplitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbWithoutAudio_VideoSplitor.Name = "cbWithoutAudio_VideoSplitor";
            this.cbWithoutAudio_VideoSplitor.Ripple = true;
            this.cbWithoutAudio_VideoSplitor.Size = new System.Drawing.Size(134, 37);
            this.cbWithoutAudio_VideoSplitor.TabIndex = 3;
            this.cbWithoutAudio_VideoSplitor.Text = "Without audio";
            this.cbWithoutAudio_VideoSplitor.UseVisualStyleBackColor = true;
            // 
            // btnAddAudio_VideoSpliter
            // 
            this.btnAddAudio_VideoSpliter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddAudio_VideoSpliter.Depth = 0;
            this.btnAddAudio_VideoSpliter.DrawShadows = true;
            this.btnAddAudio_VideoSpliter.HighEmphasis = true;
            this.btnAddAudio_VideoSpliter.Icon = null;
            this.btnAddAudio_VideoSpliter.Location = new System.Drawing.Point(110, 510);
            this.btnAddAudio_VideoSpliter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddAudio_VideoSpliter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddAudio_VideoSpliter.Name = "btnAddAudio_VideoSpliter";
            this.btnAddAudio_VideoSpliter.Size = new System.Drawing.Size(97, 36);
            this.btnAddAudio_VideoSpliter.TabIndex = 4;
            this.btnAddAudio_VideoSpliter.Text = "Add audio";
            this.btnAddAudio_VideoSpliter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddAudio_VideoSpliter.UseAccentColor = false;
            this.btnAddAudio_VideoSpliter.UseVisualStyleBackColor = true;
            this.btnAddAudio_VideoSpliter.Click += new System.EventHandler(this.btnAddAudio_VideoSpliter_Click);
            // 
            // ofd_OpenVideo_VideoSpliter
            // 
            this.ofd_OpenVideo_VideoSpliter.FileName = "openFileDialog1";
            // 
            // btnClear_VideoSpliter
            // 
            this.btnClear_VideoSpliter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear_VideoSpliter.Depth = 0;
            this.btnClear_VideoSpliter.DrawShadows = true;
            this.btnClear_VideoSpliter.HighEmphasis = true;
            this.btnClear_VideoSpliter.Icon = null;
            this.btnClear_VideoSpliter.Location = new System.Drawing.Point(718, 510);
            this.btnClear_VideoSpliter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear_VideoSpliter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear_VideoSpliter.Name = "btnClear_VideoSpliter";
            this.btnClear_VideoSpliter.Size = new System.Drawing.Size(66, 36);
            this.btnClear_VideoSpliter.TabIndex = 5;
            this.btnClear_VideoSpliter.Text = "Clear";
            this.btnClear_VideoSpliter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear_VideoSpliter.UseAccentColor = false;
            this.btnClear_VideoSpliter.UseVisualStyleBackColor = true;
            this.btnClear_VideoSpliter.Click += new System.EventHandler(this.btnClear_VideoSpliter_Click);
            // 
            // btnPausePlay_VideoSpliter
            // 
            this.btnPausePlay_VideoSpliter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPausePlay_VideoSpliter.Depth = 0;
            this.btnPausePlay_VideoSpliter.DrawShadows = true;
            this.btnPausePlay_VideoSpliter.HighEmphasis = true;
            this.btnPausePlay_VideoSpliter.Icon = null;
            this.btnPausePlay_VideoSpliter.Location = new System.Drawing.Point(215, 510);
            this.btnPausePlay_VideoSpliter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPausePlay_VideoSpliter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPausePlay_VideoSpliter.Name = "btnPausePlay_VideoSpliter";
            this.btnPausePlay_VideoSpliter.Size = new System.Drawing.Size(110, 36);
            this.btnPausePlay_VideoSpliter.TabIndex = 6;
            this.btnPausePlay_VideoSpliter.Text = "Pause/Play";
            this.btnPausePlay_VideoSpliter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPausePlay_VideoSpliter.UseAccentColor = false;
            this.btnPausePlay_VideoSpliter.UseVisualStyleBackColor = true;
            this.btnPausePlay_VideoSpliter.Click += new System.EventHandler(this.btnPausePlay_VideoSpliter_Click);
            // 
            // btnStop_VideoSpliter
            // 
            this.btnStop_VideoSpliter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop_VideoSpliter.Depth = 0;
            this.btnStop_VideoSpliter.DrawShadows = true;
            this.btnStop_VideoSpliter.HighEmphasis = true;
            this.btnStop_VideoSpliter.Icon = null;
            this.btnStop_VideoSpliter.Location = new System.Drawing.Point(333, 510);
            this.btnStop_VideoSpliter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStop_VideoSpliter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop_VideoSpliter.Name = "btnStop_VideoSpliter";
            this.btnStop_VideoSpliter.Size = new System.Drawing.Size(58, 36);
            this.btnStop_VideoSpliter.TabIndex = 7;
            this.btnStop_VideoSpliter.Text = "Stop";
            this.btnStop_VideoSpliter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStop_VideoSpliter.UseAccentColor = false;
            this.btnStop_VideoSpliter.UseVisualStyleBackColor = true;
            this.btnStop_VideoSpliter.Click += new System.EventHandler(this.btnStop_VideoSpliter_Click);
            // 
            // bntSplit_VideoSpliter
            // 
            this.bntSplit_VideoSpliter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntSplit_VideoSpliter.Depth = 0;
            this.bntSplit_VideoSpliter.DrawShadows = true;
            this.bntSplit_VideoSpliter.HighEmphasis = true;
            this.bntSplit_VideoSpliter.Icon = null;
            this.bntSplit_VideoSpliter.Location = new System.Drawing.Point(718, 465);
            this.bntSplit_VideoSpliter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bntSplit_VideoSpliter.MouseState = MaterialSkin.MouseState.HOVER;
            this.bntSplit_VideoSpliter.Name = "bntSplit_VideoSpliter";
            this.bntSplit_VideoSpliter.Size = new System.Drawing.Size(134, 36);
            this.bntSplit_VideoSpliter.TabIndex = 8;
            this.bntSplit_VideoSpliter.Text = "Split and save";
            this.bntSplit_VideoSpliter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bntSplit_VideoSpliter.UseAccentColor = false;
            this.bntSplit_VideoSpliter.UseVisualStyleBackColor = true;
            this.bntSplit_VideoSpliter.Click += new System.EventHandler(this.bntSplit_VideoSpliter_Click);
            // 
            // cbbScale_VideoSpliter
            // 
            this.cbbScale_VideoSpliter.AutoResize = false;
            this.cbbScale_VideoSpliter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbScale_VideoSpliter.Depth = 0;
            this.cbbScale_VideoSpliter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbScale_VideoSpliter.DropDownHeight = 174;
            this.cbbScale_VideoSpliter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbScale_VideoSpliter.DropDownWidth = 121;
            this.cbbScale_VideoSpliter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbScale_VideoSpliter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbScale_VideoSpliter.FormattingEnabled = true;
            this.cbbScale_VideoSpliter.IntegralHeight = false;
            this.cbbScale_VideoSpliter.ItemHeight = 43;
            this.cbbScale_VideoSpliter.Items.AddRange(new object[] {
            "0.01",
            "0.03",
            "0.05",
            "0.1",
            "0.2",
            "0.4",
            "1.0",
            "2.0",
            "3.0"});
            this.cbbScale_VideoSpliter.Location = new System.Drawing.Point(6, 452);
            this.cbbScale_VideoSpliter.MaxDropDownItems = 4;
            this.cbbScale_VideoSpliter.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbScale_VideoSpliter.Name = "cbbScale_VideoSpliter";
            this.cbbScale_VideoSpliter.Size = new System.Drawing.Size(121, 49);
            this.cbbScale_VideoSpliter.StartIndex = 0;
            this.cbbScale_VideoSpliter.TabIndex = 9;
            this.cbbScale_VideoSpliter.SelectedIndexChanged += new System.EventHandler(this.cbbScale_VideoSpliter_SelectedIndexChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(800, 510);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(52, 36);
            this.materialButton1.TabIndex = 10;
            this.materialButton1.Text = "Exit";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(883, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 487);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // fVideoAudioCutting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.cbbScale_VideoSpliter);
            this.Controls.Add(this.bntSplit_VideoSpliter);
            this.Controls.Add(this.btnStop_VideoSpliter);
            this.Controls.Add(this.btnPausePlay_VideoSpliter);
            this.Controls.Add(this.btnClear_VideoSpliter);
            this.Controls.Add(this.btnAddAudio_VideoSpliter);
            this.Controls.Add(this.cbWithoutAudio_VideoSplitor);
            this.Controls.Add(this.btnAddVideo_VideoSpliter);
            this.Controls.Add(this.tlc_TimeLine_VideoSpliter);
            this.Name = "fVideoAudioCutting";
            this.Text = "fVideoAudioCutting";
            this.Load += new System.EventHandler(this.fVideoAudioCutting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlc_TimeLine_VideoSpliter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxTimelineAxLib.AxTimelineControl tlc_TimeLine_VideoSpliter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnAddVideo_VideoSpliter;
        private MaterialSkin.Controls.MaterialCheckbox cbWithoutAudio_VideoSplitor;
        private MaterialSkin.Controls.MaterialButton btnAddAudio_VideoSpliter;
        private System.Windows.Forms.OpenFileDialog ofd_OpenVideo_VideoSpliter;
        private MaterialSkin.Controls.MaterialButton btnClear_VideoSpliter;
        private MaterialSkin.Controls.MaterialButton btnPausePlay_VideoSpliter;
        private MaterialSkin.Controls.MaterialButton btnStop_VideoSpliter;
        private MaterialSkin.Controls.MaterialButton bntSplit_VideoSpliter;
        private MaterialSkin.Controls.MaterialComboBox cbbScale_VideoSpliter;
        private System.Windows.Forms.SaveFileDialog sfdSave_VideoSpliter;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}