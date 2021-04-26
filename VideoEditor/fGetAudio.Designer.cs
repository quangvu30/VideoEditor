namespace VideoEditor
{
    partial class fGetAudio
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
            this.btnBrowseOutput_GetAudio = new MaterialSkin.Controls.MaterialButton();
            this.btnBrowseInput_GetAudio = new MaterialSkin.Controls.MaterialButton();
            this.txtOutputFilePath_GetAudio = new System.Windows.Forms.TextBox();
            this.txtInputFilePath_GetAudio = new System.Windows.Forms.TextBox();
            this.btnExec_GetAuido = new MaterialSkin.Controls.MaterialButton();
            this.btnCancleForm_GetAudiof = new MaterialSkin.Controls.MaterialButton();
            this.ofdChooseInput_GetAudio = new System.Windows.Forms.OpenFileDialog();
            this.sfdOutputFolder_GetAudio = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(38, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Output file:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(38, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Input file:";
            // 
            // btnBrowseOutput_GetAudio
            // 
            this.btnBrowseOutput_GetAudio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseOutput_GetAudio.Depth = 0;
            this.btnBrowseOutput_GetAudio.DrawShadows = true;
            this.btnBrowseOutput_GetAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseOutput_GetAudio.HighEmphasis = true;
            this.btnBrowseOutput_GetAudio.Icon = null;
            this.btnBrowseOutput_GetAudio.Location = new System.Drawing.Point(703, 189);
            this.btnBrowseOutput_GetAudio.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnBrowseOutput_GetAudio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseOutput_GetAudio.Name = "btnBrowseOutput_GetAudio";
            this.btnBrowseOutput_GetAudio.Size = new System.Drawing.Size(80, 36);
            this.btnBrowseOutput_GetAudio.TabIndex = 11;
            this.btnBrowseOutput_GetAudio.Text = "browse";
            this.btnBrowseOutput_GetAudio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowseOutput_GetAudio.UseAccentColor = false;
            this.btnBrowseOutput_GetAudio.UseVisualStyleBackColor = true;
            this.btnBrowseOutput_GetAudio.Click += new System.EventHandler(this.btnBrowseOutput_GetAudio_Click);
            // 
            // btnBrowseInput_GetAudio
            // 
            this.btnBrowseInput_GetAudio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseInput_GetAudio.Depth = 0;
            this.btnBrowseInput_GetAudio.DrawShadows = true;
            this.btnBrowseInput_GetAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseInput_GetAudio.HighEmphasis = true;
            this.btnBrowseInput_GetAudio.Icon = null;
            this.btnBrowseInput_GetAudio.Location = new System.Drawing.Point(703, 101);
            this.btnBrowseInput_GetAudio.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnBrowseInput_GetAudio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseInput_GetAudio.Name = "btnBrowseInput_GetAudio";
            this.btnBrowseInput_GetAudio.Size = new System.Drawing.Size(80, 36);
            this.btnBrowseInput_GetAudio.TabIndex = 12;
            this.btnBrowseInput_GetAudio.Text = "browse";
            this.btnBrowseInput_GetAudio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowseInput_GetAudio.UseAccentColor = false;
            this.btnBrowseInput_GetAudio.UseVisualStyleBackColor = true;
            this.btnBrowseInput_GetAudio.Click += new System.EventHandler(this.btnBrowseInput_GetAudio_Click);
            // 
            // txtOutputFilePath_GetAudio
            // 
            this.txtOutputFilePath_GetAudio.Location = new System.Drawing.Point(172, 188);
            this.txtOutputFilePath_GetAudio.Margin = new System.Windows.Forms.Padding(6);
            this.txtOutputFilePath_GetAudio.Multiline = true;
            this.txtOutputFilePath_GetAudio.Name = "txtOutputFilePath_GetAudio";
            this.txtOutputFilePath_GetAudio.Size = new System.Drawing.Size(506, 36);
            this.txtOutputFilePath_GetAudio.TabIndex = 9;
            // 
            // txtInputFilePath_GetAudio
            // 
            this.txtInputFilePath_GetAudio.Location = new System.Drawing.Point(172, 101);
            this.txtInputFilePath_GetAudio.Margin = new System.Windows.Forms.Padding(6);
            this.txtInputFilePath_GetAudio.Multiline = true;
            this.txtInputFilePath_GetAudio.Name = "txtInputFilePath_GetAudio";
            this.txtInputFilePath_GetAudio.Size = new System.Drawing.Size(506, 37);
            this.txtInputFilePath_GetAudio.TabIndex = 10;
            this.txtInputFilePath_GetAudio.TextChanged += new System.EventHandler(this.txtInputFilePath_GetAudio_TextChanged);
            // 
            // btnExec_GetAuido
            // 
            this.btnExec_GetAuido.AutoSize = false;
            this.btnExec_GetAuido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExec_GetAuido.Depth = 0;
            this.btnExec_GetAuido.DrawShadows = true;
            this.btnExec_GetAuido.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExec_GetAuido.HighEmphasis = true;
            this.btnExec_GetAuido.Icon = null;
            this.btnExec_GetAuido.Location = new System.Drawing.Point(622, 293);
            this.btnExec_GetAuido.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnExec_GetAuido.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExec_GetAuido.Name = "btnExec_GetAuido";
            this.btnExec_GetAuido.Size = new System.Drawing.Size(80, 36);
            this.btnExec_GetAuido.TabIndex = 11;
            this.btnExec_GetAuido.Text = "Execute";
            this.btnExec_GetAuido.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExec_GetAuido.UseAccentColor = false;
            this.btnExec_GetAuido.UseVisualStyleBackColor = true;
            this.btnExec_GetAuido.Click += new System.EventHandler(this.btnExec_GetAuido_Click);
            // 
            // btnCancleForm_GetAudiof
            // 
            this.btnCancleForm_GetAudiof.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancleForm_GetAudiof.Depth = 0;
            this.btnCancleForm_GetAudiof.DrawShadows = true;
            this.btnCancleForm_GetAudiof.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleForm_GetAudiof.HighEmphasis = true;
            this.btnCancleForm_GetAudiof.Icon = null;
            this.btnCancleForm_GetAudiof.Location = new System.Drawing.Point(731, 293);
            this.btnCancleForm_GetAudiof.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnCancleForm_GetAudiof.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancleForm_GetAudiof.Name = "btnCancleForm_GetAudiof";
            this.btnCancleForm_GetAudiof.Size = new System.Drawing.Size(52, 36);
            this.btnCancleForm_GetAudiof.TabIndex = 11;
            this.btnCancleForm_GetAudiof.Text = "Exit";
            this.btnCancleForm_GetAudiof.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancleForm_GetAudiof.UseAccentColor = false;
            this.btnCancleForm_GetAudiof.UseVisualStyleBackColor = true;
            this.btnCancleForm_GetAudiof.Click += new System.EventHandler(this.btnCancleForm_GetAudiof_Click);
            // 
            // ofdChooseInput_GetAudio
            // 
            this.ofdChooseInput_GetAudio.FileName = "openFileDialog1";
            // 
            // fGetAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancleForm_GetAudiof);
            this.Controls.Add(this.btnExec_GetAuido);
            this.Controls.Add(this.btnBrowseOutput_GetAudio);
            this.Controls.Add(this.btnBrowseInput_GetAudio);
            this.Controls.Add(this.txtOutputFilePath_GetAudio);
            this.Controls.Add(this.txtInputFilePath_GetAudio);
            this.Name = "fGetAudio";
            this.Text = "GetAudio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnBrowseOutput_GetAudio;
        private MaterialSkin.Controls.MaterialButton btnBrowseInput_GetAudio;
        private System.Windows.Forms.TextBox txtOutputFilePath_GetAudio;
        private System.Windows.Forms.TextBox txtInputFilePath_GetAudio;
        private MaterialSkin.Controls.MaterialButton btnExec_GetAuido;
        private MaterialSkin.Controls.MaterialButton btnCancleForm_GetAudiof;
        private System.Windows.Forms.OpenFileDialog ofdChooseInput_GetAudio;
        private System.Windows.Forms.SaveFileDialog sfdOutputFolder_GetAudio;
    }
}