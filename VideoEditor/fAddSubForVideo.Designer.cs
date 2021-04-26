namespace VideoEditor
{
    partial class fAddSubForVideo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseOutput_AddingSub = new MaterialSkin.Controls.MaterialButton();
            this.btnBrowseInputVideo_AddingSub = new MaterialSkin.Controls.MaterialButton();
            this.txtOutputFilePath_AddingSub = new System.Windows.Forms.TextBox();
            this.txtInputVideoFilePath_AddingSub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseInputSubFile_AddingSub = new MaterialSkin.Controls.MaterialButton();
            this.txtInputSubFilePath_AddingSub = new System.Windows.Forms.TextBox();
            this.btnExe_AddingSub = new MaterialSkin.Controls.MaterialButton();
            this.btnCancleForm_AddingSubf = new MaterialSkin.Controls.MaterialButton();
            this.ofdChooseInputSub_AddSub = new System.Windows.Forms.OpenFileDialog();
            this.fbdOutoutFolder_AddSub = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(31, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Output folder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(31, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Video input file:";
            // 
            // btnBrowseOutput_AddingSub
            // 
            this.btnBrowseOutput_AddingSub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseOutput_AddingSub.Depth = 0;
            this.btnBrowseOutput_AddingSub.DrawShadows = true;
            this.btnBrowseOutput_AddingSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseOutput_AddingSub.HighEmphasis = true;
            this.btnBrowseOutput_AddingSub.Icon = null;
            this.btnBrowseOutput_AddingSub.Location = new System.Drawing.Point(770, 271);
            this.btnBrowseOutput_AddingSub.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnBrowseOutput_AddingSub.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseOutput_AddingSub.Name = "btnBrowseOutput_AddingSub";
            this.btnBrowseOutput_AddingSub.Size = new System.Drawing.Size(80, 36);
            this.btnBrowseOutput_AddingSub.TabIndex = 11;
            this.btnBrowseOutput_AddingSub.Text = "browse";
            this.btnBrowseOutput_AddingSub.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowseOutput_AddingSub.UseAccentColor = false;
            this.btnBrowseOutput_AddingSub.UseVisualStyleBackColor = true;
            this.btnBrowseOutput_AddingSub.Click += new System.EventHandler(this.btnBrowseOutput_AddingSub_Click);
            // 
            // btnBrowseInputVideo_AddingSub
            // 
            this.btnBrowseInputVideo_AddingSub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseInputVideo_AddingSub.Depth = 0;
            this.btnBrowseInputVideo_AddingSub.DrawShadows = true;
            this.btnBrowseInputVideo_AddingSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseInputVideo_AddingSub.HighEmphasis = true;
            this.btnBrowseInputVideo_AddingSub.Icon = null;
            this.btnBrowseInputVideo_AddingSub.Location = new System.Drawing.Point(770, 184);
            this.btnBrowseInputVideo_AddingSub.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnBrowseInputVideo_AddingSub.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseInputVideo_AddingSub.Name = "btnBrowseInputVideo_AddingSub";
            this.btnBrowseInputVideo_AddingSub.Size = new System.Drawing.Size(80, 36);
            this.btnBrowseInputVideo_AddingSub.TabIndex = 12;
            this.btnBrowseInputVideo_AddingSub.Text = "browse";
            this.btnBrowseInputVideo_AddingSub.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowseInputVideo_AddingSub.UseAccentColor = false;
            this.btnBrowseInputVideo_AddingSub.UseVisualStyleBackColor = true;
            this.btnBrowseInputVideo_AddingSub.Click += new System.EventHandler(this.btnBrowseInputVideo_AddingSub_Click);
            // 
            // txtOutputFilePath_AddingSub
            // 
            this.txtOutputFilePath_AddingSub.Location = new System.Drawing.Point(212, 271);
            this.txtOutputFilePath_AddingSub.Margin = new System.Windows.Forms.Padding(6);
            this.txtOutputFilePath_AddingSub.Multiline = true;
            this.txtOutputFilePath_AddingSub.Name = "txtOutputFilePath_AddingSub";
            this.txtOutputFilePath_AddingSub.Size = new System.Drawing.Size(506, 36);
            this.txtOutputFilePath_AddingSub.TabIndex = 9;
            this.txtOutputFilePath_AddingSub.Text = "D:\\";
            // 
            // txtInputVideoFilePath_AddingSub
            // 
            this.txtInputVideoFilePath_AddingSub.Location = new System.Drawing.Point(212, 185);
            this.txtInputVideoFilePath_AddingSub.Margin = new System.Windows.Forms.Padding(6);
            this.txtInputVideoFilePath_AddingSub.Multiline = true;
            this.txtInputVideoFilePath_AddingSub.Name = "txtInputVideoFilePath_AddingSub";
            this.txtInputVideoFilePath_AddingSub.Size = new System.Drawing.Size(506, 37);
            this.txtInputVideoFilePath_AddingSub.TabIndex = 10;
            this.txtInputVideoFilePath_AddingSub.Text = "D:\\Subtile_Project\\VideoProccessData\\shot.mp4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(31, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Subtile input file:";
            // 
            // btnBrowseInputSubFile_AddingSub
            // 
            this.btnBrowseInputSubFile_AddingSub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseInputSubFile_AddingSub.Depth = 0;
            this.btnBrowseInputSubFile_AddingSub.DrawShadows = true;
            this.btnBrowseInputSubFile_AddingSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseInputSubFile_AddingSub.HighEmphasis = true;
            this.btnBrowseInputSubFile_AddingSub.Icon = null;
            this.btnBrowseInputSubFile_AddingSub.Location = new System.Drawing.Point(770, 107);
            this.btnBrowseInputSubFile_AddingSub.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnBrowseInputSubFile_AddingSub.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseInputSubFile_AddingSub.Name = "btnBrowseInputSubFile_AddingSub";
            this.btnBrowseInputSubFile_AddingSub.Size = new System.Drawing.Size(80, 36);
            this.btnBrowseInputSubFile_AddingSub.TabIndex = 16;
            this.btnBrowseInputSubFile_AddingSub.Text = "browse";
            this.btnBrowseInputSubFile_AddingSub.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowseInputSubFile_AddingSub.UseAccentColor = false;
            this.btnBrowseInputSubFile_AddingSub.UseVisualStyleBackColor = true;
            this.btnBrowseInputSubFile_AddingSub.Click += new System.EventHandler(this.btnBrowseInputSubFile_AddingSub_Click);
            // 
            // txtInputSubFilePath_AddingSub
            // 
            this.txtInputSubFilePath_AddingSub.Location = new System.Drawing.Point(212, 108);
            this.txtInputSubFilePath_AddingSub.Margin = new System.Windows.Forms.Padding(6);
            this.txtInputSubFilePath_AddingSub.Multiline = true;
            this.txtInputSubFilePath_AddingSub.Name = "txtInputSubFilePath_AddingSub";
            this.txtInputSubFilePath_AddingSub.Size = new System.Drawing.Size(506, 37);
            this.txtInputSubFilePath_AddingSub.TabIndex = 15;
            this.txtInputSubFilePath_AddingSub.Text = "D:\\Subtitles.srt";
            this.txtInputSubFilePath_AddingSub.TextChanged += new System.EventHandler(this.txtInputSubFilePath_AddingSub_TextChanged);
            // 
            // btnExe_AddingSub
            // 
            this.btnExe_AddingSub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExe_AddingSub.Depth = 0;
            this.btnExe_AddingSub.DrawShadows = true;
            this.btnExe_AddingSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExe_AddingSub.HighEmphasis = true;
            this.btnExe_AddingSub.Icon = null;
            this.btnExe_AddingSub.Location = new System.Drawing.Point(673, 355);
            this.btnExe_AddingSub.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnExe_AddingSub.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExe_AddingSub.Name = "btnExe_AddingSub";
            this.btnExe_AddingSub.Size = new System.Drawing.Size(93, 36);
            this.btnExe_AddingSub.TabIndex = 11;
            this.btnExe_AddingSub.Text = "Exectute";
            this.btnExe_AddingSub.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExe_AddingSub.UseAccentColor = false;
            this.btnExe_AddingSub.UseVisualStyleBackColor = true;
            this.btnExe_AddingSub.Click += new System.EventHandler(this.btnExe_AddingSub_Click);
            // 
            // btnCancleForm_AddingSubf
            // 
            this.btnCancleForm_AddingSubf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancleForm_AddingSubf.Depth = 0;
            this.btnCancleForm_AddingSubf.DrawShadows = true;
            this.btnCancleForm_AddingSubf.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleForm_AddingSubf.HighEmphasis = true;
            this.btnCancleForm_AddingSubf.Icon = null;
            this.btnCancleForm_AddingSubf.Location = new System.Drawing.Point(798, 355);
            this.btnCancleForm_AddingSubf.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnCancleForm_AddingSubf.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancleForm_AddingSubf.Name = "btnCancleForm_AddingSubf";
            this.btnCancleForm_AddingSubf.Size = new System.Drawing.Size(52, 36);
            this.btnCancleForm_AddingSubf.TabIndex = 11;
            this.btnCancleForm_AddingSubf.Text = "Exit";
            this.btnCancleForm_AddingSubf.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancleForm_AddingSubf.UseAccentColor = false;
            this.btnCancleForm_AddingSubf.UseVisualStyleBackColor = true;
            this.btnCancleForm_AddingSubf.Click += new System.EventHandler(this.btnCancleForm_AddingSubf_Click);
            // 
            // ofdChooseInputSub_AddSub
            // 
            this.ofdChooseInputSub_AddSub.FileName = "openFileDialog1";
            // 
            // fAddSubForVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseInputSubFile_AddingSub);
            this.Controls.Add(this.txtInputSubFilePath_AddingSub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancleForm_AddingSubf);
            this.Controls.Add(this.btnExe_AddingSub);
            this.Controls.Add(this.btnBrowseOutput_AddingSub);
            this.Controls.Add(this.btnBrowseInputVideo_AddingSub);
            this.Controls.Add(this.txtOutputFilePath_AddingSub);
            this.Controls.Add(this.txtInputVideoFilePath_AddingSub);
            this.Name = "fAddSubForVideo";
            this.Text = "fAddSubForVideo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnBrowseOutput_AddingSub;
        private MaterialSkin.Controls.MaterialButton btnBrowseInputVideo_AddingSub;
        private System.Windows.Forms.TextBox txtOutputFilePath_AddingSub;
        private System.Windows.Forms.TextBox txtInputVideoFilePath_AddingSub;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton btnBrowseInputSubFile_AddingSub;
        private System.Windows.Forms.TextBox txtInputSubFilePath_AddingSub;
        private MaterialSkin.Controls.MaterialButton btnExe_AddingSub;
        private MaterialSkin.Controls.MaterialButton btnCancleForm_AddingSubf;
        private System.Windows.Forms.OpenFileDialog ofdChooseInputSub_AddSub;
        private System.Windows.Forms.FolderBrowserDialog fbdOutoutFolder_AddSub;
    }
}