namespace VideoEditor
{
    partial class SubCreatorUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbInputLanguage_mainFunc = new System.Windows.Forms.ComboBox();
            this.btnExe_RenderSub = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ofdChooseInput = new System.Windows.Forms.OpenFileDialog();
            this.txtInputFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseInput = new MaterialSkin.Controls.MaterialButton();
            this.btnBrowseOutput = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFromAvailableSubOp = new System.Windows.Forms.Button();
            this.btnFromAudioOp = new System.Windows.Forms.Button();
            this.cbbOuputLanguage_mainFunc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutputFilePath = new System.Windows.Forms.TextBox();
            this.sfdChooseOutput_SubAddedVideoCreator = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // cbbInputLanguage_mainFunc
            // 
            this.cbbInputLanguage_mainFunc.FormattingEnabled = true;
            this.cbbInputLanguage_mainFunc.Items.AddRange(new object[] {
            "Tiếng Anh "});
            this.cbbInputLanguage_mainFunc.Location = new System.Drawing.Point(280, 232);
            this.cbbInputLanguage_mainFunc.Margin = new System.Windows.Forms.Padding(6);
            this.cbbInputLanguage_mainFunc.Name = "cbbInputLanguage_mainFunc";
            this.cbbInputLanguage_mainFunc.Size = new System.Drawing.Size(212, 32);
            this.cbbInputLanguage_mainFunc.TabIndex = 4;
            // 
            // btnExe_RenderSub
            // 
            this.btnExe_RenderSub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExe_RenderSub.Depth = 0;
            this.btnExe_RenderSub.DrawShadows = true;
            this.btnExe_RenderSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExe_RenderSub.HighEmphasis = true;
            this.btnExe_RenderSub.Icon = null;
            this.btnExe_RenderSub.Location = new System.Drawing.Point(797, 348);
            this.btnExe_RenderSub.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnExe_RenderSub.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExe_RenderSub.Name = "btnExe_RenderSub";
            this.btnExe_RenderSub.Size = new System.Drawing.Size(94, 36);
            this.btnExe_RenderSub.TabIndex = 2;
            this.btnExe_RenderSub.Text = "Execcute";
            this.btnExe_RenderSub.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExe_RenderSub.UseAccentColor = false;
            this.btnExe_RenderSub.UseVisualStyleBackColor = true;
            this.btnExe_RenderSub.Click += new System.EventHandler(this.btnExe_RenderSub_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Input language:";
            // 
            // ofdChooseInput
            // 
            this.ofdChooseInput.FileName = "openFileDialog1";
            // 
            // txtInputFilePath
            // 
            this.txtInputFilePath.Location = new System.Drawing.Point(280, 112);
            this.txtInputFilePath.Margin = new System.Windows.Forms.Padding(6);
            this.txtInputFilePath.Multiline = true;
            this.txtInputFilePath.Name = "txtInputFilePath";
            this.txtInputFilePath.Size = new System.Drawing.Size(506, 37);
            this.txtInputFilePath.TabIndex = 0;
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseInput.Depth = 0;
            this.btnBrowseInput.DrawShadows = true;
            this.btnBrowseInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseInput.HighEmphasis = true;
            this.btnBrowseInput.Icon = null;
            this.btnBrowseInput.Location = new System.Drawing.Point(811, 112);
            this.btnBrowseInput.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnBrowseInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(80, 36);
            this.btnBrowseInput.TabIndex = 2;
            this.btnBrowseInput.Text = "browse";
            this.btnBrowseInput.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowseInput.UseAccentColor = false;
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseOutput.Depth = 0;
            this.btnBrowseOutput.DrawShadows = true;
            this.btnBrowseOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseOutput.HighEmphasis = true;
            this.btnBrowseOutput.Icon = null;
            this.btnBrowseOutput.Location = new System.Drawing.Point(811, 168);
            this.btnBrowseOutput.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnBrowseOutput.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(80, 36);
            this.btnBrowseOutput.TabIndex = 2;
            this.btnBrowseOutput.Text = "browse";
            this.btnBrowseOutput.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowseOutput.UseAccentColor = false;
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output file:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Source format:";
            // 
            // btnFromAvailableSubOp
            // 
            this.btnFromAvailableSubOp.Location = new System.Drawing.Point(280, 47);
            this.btnFromAvailableSubOp.Name = "btnFromAvailableSubOp";
            this.btnFromAvailableSubOp.Size = new System.Drawing.Size(238, 35);
            this.btnFromAvailableSubOp.TabIndex = 9;
            this.btnFromAvailableSubOp.Text = "From available subtitle";
            this.btnFromAvailableSubOp.UseVisualStyleBackColor = true;
            this.btnFromAvailableSubOp.Click += new System.EventHandler(this.btnFromAvailableSubOp_Click);
            // 
            // btnFromAudioOp
            // 
            this.btnFromAudioOp.Location = new System.Drawing.Point(524, 47);
            this.btnFromAudioOp.Name = "btnFromAudioOp";
            this.btnFromAudioOp.Size = new System.Drawing.Size(262, 35);
            this.btnFromAudioOp.TabIndex = 9;
            this.btnFromAudioOp.Text = "From audio";
            this.btnFromAudioOp.UseVisualStyleBackColor = true;
            this.btnFromAudioOp.Click += new System.EventHandler(this.btnFromAudioOp_Click);
            // 
            // cbbOuputLanguage_mainFunc
            // 
            this.cbbOuputLanguage_mainFunc.FormattingEnabled = true;
            this.cbbOuputLanguage_mainFunc.Items.AddRange(new object[] {
            "Tiếng Việt"});
            this.cbbOuputLanguage_mainFunc.Location = new System.Drawing.Point(280, 290);
            this.cbbOuputLanguage_mainFunc.Margin = new System.Windows.Forms.Padding(6);
            this.cbbOuputLanguage_mainFunc.Name = "cbbOuputLanguage_mainFunc";
            this.cbbOuputLanguage_mainFunc.Size = new System.Drawing.Size(212, 32);
            this.cbbOuputLanguage_mainFunc.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Output language:";
            // 
            // txtOutputFilePath
            // 
            this.txtOutputFilePath.Location = new System.Drawing.Point(280, 168);
            this.txtOutputFilePath.Margin = new System.Windows.Forms.Padding(6);
            this.txtOutputFilePath.Multiline = true;
            this.txtOutputFilePath.Name = "txtOutputFilePath";
            this.txtOutputFilePath.Size = new System.Drawing.Size(506, 36);
            this.txtOutputFilePath.TabIndex = 0;
            // 
            // SubCreatorUC
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFromAudioOp);
            this.Controls.Add(this.btnFromAvailableSubOp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbOuputLanguage_mainFunc);
            this.Controls.Add(this.cbbInputLanguage_mainFunc);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.btnExe_RenderSub);
            this.Controls.Add(this.btnBrowseInput);
            this.Controls.Add(this.txtOutputFilePath);
            this.Controls.Add(this.txtInputFilePath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SubCreatorUC";
            this.Size = new System.Drawing.Size(1028, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbInputLanguage_mainFunc;
        private MaterialSkin.Controls.MaterialButton btnExe_RenderSub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofdChooseInput;
        private System.Windows.Forms.TextBox txtInputFilePath;
        private MaterialSkin.Controls.MaterialButton btnBrowseInput;
        private MaterialSkin.Controls.MaterialButton btnBrowseOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFromAvailableSubOp;
        private System.Windows.Forms.Button btnFromAudioOp;
        private System.Windows.Forms.ComboBox cbbOuputLanguage_mainFunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutputFilePath;
        private System.Windows.Forms.SaveFileDialog sfdChooseOutput_SubAddedVideoCreator;
    }
}
