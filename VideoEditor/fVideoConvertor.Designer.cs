namespace VideoEditor
{
    partial class fVideoConvertor
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
            this.btnCancleForm__Convertor = new MaterialSkin.Controls.MaterialButton();
            this.btnExec__Convertor = new MaterialSkin.Controls.MaterialButton();
            this.btnBrowseOutput_Convertor = new MaterialSkin.Controls.MaterialButton();
            this.btnBrowseInput_Convertor = new MaterialSkin.Controls.MaterialButton();
            this.txtOutputFolderPath_Convertor = new System.Windows.Forms.TextBox();
            this.txtInputFilePath_Convertor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbOutputFormat__Convertor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVideoInput_Convertor = new System.Windows.Forms.Button();
            this.btnImageInput_Convertor = new System.Windows.Forms.Button();
            this.btnAudioInput_Convertor = new System.Windows.Forms.Button();
            this.ofdChooseInput_Convertor = new System.Windows.Forms.OpenFileDialog();
            this.sfdOutputFolder_Convertor = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(77, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Output file:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(92, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Input file:";
            // 
            // btnCancleForm__Convertor
            // 
            this.btnCancleForm__Convertor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancleForm__Convertor.Depth = 0;
            this.btnCancleForm__Convertor.DrawShadows = true;
            this.btnCancleForm__Convertor.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleForm__Convertor.HighEmphasis = true;
            this.btnCancleForm__Convertor.Icon = null;
            this.btnCancleForm__Convertor.Location = new System.Drawing.Point(779, 391);
            this.btnCancleForm__Convertor.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnCancleForm__Convertor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancleForm__Convertor.Name = "btnCancleForm__Convertor";
            this.btnCancleForm__Convertor.Size = new System.Drawing.Size(52, 36);
            this.btnCancleForm__Convertor.TabIndex = 17;
            this.btnCancleForm__Convertor.Text = "Exit";
            this.btnCancleForm__Convertor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancleForm__Convertor.UseAccentColor = false;
            this.btnCancleForm__Convertor.UseVisualStyleBackColor = true;
            this.btnCancleForm__Convertor.Click += new System.EventHandler(this.btnCancleForm__Convertor_Click);
            // 
            // btnExec__Convertor
            // 
            this.btnExec__Convertor.AutoSize = false;
            this.btnExec__Convertor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExec__Convertor.Depth = 0;
            this.btnExec__Convertor.DrawShadows = true;
            this.btnExec__Convertor.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExec__Convertor.HighEmphasis = true;
            this.btnExec__Convertor.Icon = null;
            this.btnExec__Convertor.Location = new System.Drawing.Point(669, 391);
            this.btnExec__Convertor.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnExec__Convertor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExec__Convertor.Name = "btnExec__Convertor";
            this.btnExec__Convertor.Size = new System.Drawing.Size(80, 36);
            this.btnExec__Convertor.TabIndex = 18;
            this.btnExec__Convertor.Text = "Execute";
            this.btnExec__Convertor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExec__Convertor.UseAccentColor = false;
            this.btnExec__Convertor.UseVisualStyleBackColor = true;
            this.btnExec__Convertor.Click += new System.EventHandler(this.btnExec__Convertor_Click);
            // 
            // btnBrowseOutput_Convertor
            // 
            this.btnBrowseOutput_Convertor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseOutput_Convertor.Depth = 0;
            this.btnBrowseOutput_Convertor.DrawShadows = true;
            this.btnBrowseOutput_Convertor.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseOutput_Convertor.HighEmphasis = true;
            this.btnBrowseOutput_Convertor.Icon = null;
            this.btnBrowseOutput_Convertor.Location = new System.Drawing.Point(751, 253);
            this.btnBrowseOutput_Convertor.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnBrowseOutput_Convertor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseOutput_Convertor.Name = "btnBrowseOutput_Convertor";
            this.btnBrowseOutput_Convertor.Size = new System.Drawing.Size(80, 36);
            this.btnBrowseOutput_Convertor.TabIndex = 19;
            this.btnBrowseOutput_Convertor.Text = "browse";
            this.btnBrowseOutput_Convertor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowseOutput_Convertor.UseAccentColor = false;
            this.btnBrowseOutput_Convertor.UseVisualStyleBackColor = true;
            this.btnBrowseOutput_Convertor.Click += new System.EventHandler(this.btnBrowseOutput_Convertor_Click);
            // 
            // btnBrowseInput_Convertor
            // 
            this.btnBrowseInput_Convertor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseInput_Convertor.Depth = 0;
            this.btnBrowseInput_Convertor.DrawShadows = true;
            this.btnBrowseInput_Convertor.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseInput_Convertor.HighEmphasis = true;
            this.btnBrowseInput_Convertor.Icon = null;
            this.btnBrowseInput_Convertor.Location = new System.Drawing.Point(751, 180);
            this.btnBrowseInput_Convertor.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnBrowseInput_Convertor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseInput_Convertor.Name = "btnBrowseInput_Convertor";
            this.btnBrowseInput_Convertor.Size = new System.Drawing.Size(80, 36);
            this.btnBrowseInput_Convertor.TabIndex = 20;
            this.btnBrowseInput_Convertor.Text = "browse";
            this.btnBrowseInput_Convertor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowseInput_Convertor.UseAccentColor = false;
            this.btnBrowseInput_Convertor.UseVisualStyleBackColor = true;
            this.btnBrowseInput_Convertor.Click += new System.EventHandler(this.btnBrowseInput_Convertor_Click);
            // 
            // txtOutputFolderPath_Convertor
            // 
            this.txtOutputFolderPath_Convertor.Location = new System.Drawing.Point(220, 252);
            this.txtOutputFolderPath_Convertor.Margin = new System.Windows.Forms.Padding(6);
            this.txtOutputFolderPath_Convertor.Multiline = true;
            this.txtOutputFolderPath_Convertor.Name = "txtOutputFolderPath_Convertor";
            this.txtOutputFolderPath_Convertor.Size = new System.Drawing.Size(506, 36);
            this.txtOutputFolderPath_Convertor.TabIndex = 15;
            // 
            // txtInputFilePath_Convertor
            // 
            this.txtInputFilePath_Convertor.Location = new System.Drawing.Point(220, 180);
            this.txtInputFilePath_Convertor.Margin = new System.Windows.Forms.Padding(6);
            this.txtInputFilePath_Convertor.Multiline = true;
            this.txtInputFilePath_Convertor.Name = "txtInputFilePath_Convertor";
            this.txtInputFilePath_Convertor.Size = new System.Drawing.Size(506, 37);
            this.txtInputFilePath_Convertor.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(49, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Output format:";
            // 
            // cbbOutputFormat__Convertor
            // 
            this.cbbOutputFormat__Convertor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbbOutputFormat__Convertor.FormattingEnabled = true;
            this.cbbOutputFormat__Convertor.Location = new System.Drawing.Point(217, 333);
            this.cbbOutputFormat__Convertor.Margin = new System.Windows.Forms.Padding(6);
            this.cbbOutputFormat__Convertor.Name = "cbbOutputFormat__Convertor";
            this.cbbOutputFormat__Convertor.Size = new System.Drawing.Size(180, 32);
            this.cbbOutputFormat__Convertor.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(27, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Type source file:";
            // 
            // btnVideoInput_Convertor
            // 
            this.btnVideoInput_Convertor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnVideoInput_Convertor.Location = new System.Drawing.Point(220, 111);
            this.btnVideoInput_Convertor.Name = "btnVideoInput_Convertor";
            this.btnVideoInput_Convertor.Size = new System.Drawing.Size(87, 32);
            this.btnVideoInput_Convertor.TabIndex = 25;
            this.btnVideoInput_Convertor.Text = "video";
            this.btnVideoInput_Convertor.UseVisualStyleBackColor = true;
            this.btnVideoInput_Convertor.Click += new System.EventHandler(this.btnVideoInput_Convertor_Click);
            // 
            // btnImageInput_Convertor
            // 
            this.btnImageInput_Convertor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnImageInput_Convertor.Location = new System.Drawing.Point(406, 111);
            this.btnImageInput_Convertor.Name = "btnImageInput_Convertor";
            this.btnImageInput_Convertor.Size = new System.Drawing.Size(87, 32);
            this.btnImageInput_Convertor.TabIndex = 25;
            this.btnImageInput_Convertor.Text = "Image";
            this.btnImageInput_Convertor.UseVisualStyleBackColor = true;
            this.btnImageInput_Convertor.Click += new System.EventHandler(this.btnImageInput_Convertor_Click);
            // 
            // btnAudioInput_Convertor
            // 
            this.btnAudioInput_Convertor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAudioInput_Convertor.Location = new System.Drawing.Point(313, 111);
            this.btnAudioInput_Convertor.Name = "btnAudioInput_Convertor";
            this.btnAudioInput_Convertor.Size = new System.Drawing.Size(87, 32);
            this.btnAudioInput_Convertor.TabIndex = 25;
            this.btnAudioInput_Convertor.Text = "Audio";
            this.btnAudioInput_Convertor.UseVisualStyleBackColor = true;
            this.btnAudioInput_Convertor.Click += new System.EventHandler(this.btnAudioInput_Convertor_Click_1);
            // 
            // ofdChooseInput_Convertor
            // 
            this.ofdChooseInput_Convertor.FileName = "openFileDialog1";
            // 
            // fVideoConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 448);
            this.Controls.Add(this.btnAudioInput_Convertor);
            this.Controls.Add(this.btnImageInput_Convertor);
            this.Controls.Add(this.btnVideoInput_Convertor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbOutputFormat__Convertor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancleForm__Convertor);
            this.Controls.Add(this.btnExec__Convertor);
            this.Controls.Add(this.btnBrowseOutput_Convertor);
            this.Controls.Add(this.btnBrowseInput_Convertor);
            this.Controls.Add(this.txtOutputFolderPath_Convertor);
            this.Controls.Add(this.txtInputFilePath_Convertor);
            this.Name = "fVideoConvertor";
            this.Text = "fVideoConvertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnCancleForm__Convertor;
        private MaterialSkin.Controls.MaterialButton btnExec__Convertor;
        private MaterialSkin.Controls.MaterialButton btnBrowseOutput_Convertor;
        private MaterialSkin.Controls.MaterialButton btnBrowseInput_Convertor;
        private System.Windows.Forms.TextBox txtOutputFolderPath_Convertor;
        private System.Windows.Forms.TextBox txtInputFilePath_Convertor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbOutputFormat__Convertor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVideoInput_Convertor;
        private System.Windows.Forms.Button btnImageInput_Convertor;
        private System.Windows.Forms.Button btnAudioInput_Convertor;
        private System.Windows.Forms.OpenFileDialog ofdChooseInput_Convertor;
        private System.Windows.Forms.SaveFileDialog sfdOutputFolder_Convertor;
    }
}