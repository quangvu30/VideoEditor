namespace VideoEditor
{
    partial class fVideoSpeedControler
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
            this.btnInput_SpeedControler = new MaterialSkin.Controls.MaterialButton();
            this.btnOutput_Speedcontrol = new MaterialSkin.Controls.MaterialButton();
            this.dgvInOutFile_SpeedControl = new System.Windows.Forms.DataGridView();
            this.btnExec_SpeedControl = new MaterialSkin.Controls.MaterialButton();
            this.btnCancle_SpeedControl = new MaterialSkin.Controls.MaterialButton();
            this.ofdOpenInputFile_SpeedControler = new System.Windows.Forms.OpenFileDialog();
            this.fbdOpenInpuFolder_SpeedControler = new System.Windows.Forms.FolderBrowserDialog();
            this.input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speed = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInOutFile_SpeedControl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInput_SpeedControler
            // 
            this.btnInput_SpeedControler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInput_SpeedControler.Depth = 0;
            this.btnInput_SpeedControler.DrawShadows = true;
            this.btnInput_SpeedControler.HighEmphasis = true;
            this.btnInput_SpeedControler.Icon = null;
            this.btnInput_SpeedControler.Location = new System.Drawing.Point(22, 81);
            this.btnInput_SpeedControler.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInput_SpeedControler.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInput_SpeedControler.Name = "btnInput_SpeedControler";
            this.btnInput_SpeedControler.Size = new System.Drawing.Size(152, 36);
            this.btnInput_SpeedControler.TabIndex = 0;
            this.btnInput_SpeedControler.Text = "         select input       ";
            this.btnInput_SpeedControler.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInput_SpeedControler.UseAccentColor = false;
            this.btnInput_SpeedControler.UseVisualStyleBackColor = true;
            this.btnInput_SpeedControler.Click += new System.EventHandler(this.btnInput_SpeedControler_Click);
            // 
            // btnOutput_Speedcontrol
            // 
            this.btnOutput_Speedcontrol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOutput_Speedcontrol.Depth = 0;
            this.btnOutput_Speedcontrol.DrawShadows = true;
            this.btnOutput_Speedcontrol.HighEmphasis = true;
            this.btnOutput_Speedcontrol.Icon = null;
            this.btnOutput_Speedcontrol.Location = new System.Drawing.Point(495, 81);
            this.btnOutput_Speedcontrol.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOutput_Speedcontrol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOutput_Speedcontrol.Name = "btnOutput_Speedcontrol";
            this.btnOutput_Speedcontrol.Size = new System.Drawing.Size(166, 36);
            this.btnOutput_Speedcontrol.TabIndex = 200;
            this.btnOutput_Speedcontrol.Text = "         select output       ";
            this.btnOutput_Speedcontrol.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOutput_Speedcontrol.UseAccentColor = false;
            this.btnOutput_Speedcontrol.UseVisualStyleBackColor = true;
            this.btnOutput_Speedcontrol.Click += new System.EventHandler(this.btnOutput_Speedcontrol_Click);
            // 
            // dgvInOutFile_SpeedControl
            // 
            this.dgvInOutFile_SpeedControl.AllowUserToAddRows = false;
            this.dgvInOutFile_SpeedControl.AllowUserToDeleteRows = false;
            this.dgvInOutFile_SpeedControl.AllowUserToResizeColumns = false;
            this.dgvInOutFile_SpeedControl.AllowUserToResizeRows = false;
            this.dgvInOutFile_SpeedControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInOutFile_SpeedControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInOutFile_SpeedControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.input,
            this.output,
            this.speed});
            this.dgvInOutFile_SpeedControl.Location = new System.Drawing.Point(22, 126);
            this.dgvInOutFile_SpeedControl.Name = "dgvInOutFile_SpeedControl";
            this.dgvInOutFile_SpeedControl.Size = new System.Drawing.Size(639, 275);
            this.dgvInOutFile_SpeedControl.TabIndex = 1;
            this.dgvInOutFile_SpeedControl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInOutFile_SpeedControl_CellClick);
            // 
            // btnExec_SpeedControl
            // 
            this.btnExec_SpeedControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExec_SpeedControl.Depth = 0;
            this.btnExec_SpeedControl.DrawShadows = true;
            this.btnExec_SpeedControl.HighEmphasis = true;
            this.btnExec_SpeedControl.Icon = null;
            this.btnExec_SpeedControl.Location = new System.Drawing.Point(485, 421);
            this.btnExec_SpeedControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExec_SpeedControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExec_SpeedControl.Name = "btnExec_SpeedControl";
            this.btnExec_SpeedControl.Size = new System.Drawing.Size(76, 36);
            this.btnExec_SpeedControl.TabIndex = 4;
            this.btnExec_SpeedControl.Text = "Excute ";
            this.btnExec_SpeedControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExec_SpeedControl.UseAccentColor = false;
            this.btnExec_SpeedControl.UseVisualStyleBackColor = true;
            this.btnExec_SpeedControl.Click += new System.EventHandler(this.btnExec_SpeedControl_Click);
            // 
            // btnCancle_SpeedControl
            // 
            this.btnCancle_SpeedControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancle_SpeedControl.Depth = 0;
            this.btnCancle_SpeedControl.DrawShadows = true;
            this.btnCancle_SpeedControl.HighEmphasis = true;
            this.btnCancle_SpeedControl.Icon = null;
            this.btnCancle_SpeedControl.Location = new System.Drawing.Point(584, 421);
            this.btnCancle_SpeedControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancle_SpeedControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancle_SpeedControl.Name = "btnCancle_SpeedControl";
            this.btnCancle_SpeedControl.Size = new System.Drawing.Size(77, 36);
            this.btnCancle_SpeedControl.TabIndex = 4;
            this.btnCancle_SpeedControl.Text = "cancle";
            this.btnCancle_SpeedControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancle_SpeedControl.UseAccentColor = false;
            this.btnCancle_SpeedControl.UseVisualStyleBackColor = true;
            this.btnCancle_SpeedControl.Click += new System.EventHandler(this.btnCancle_SpeedControl_Click);
            // 
            // ofdOpenInputFile_SpeedControler
            // 
            this.ofdOpenInputFile_SpeedControler.FileName = "openFileDialog1";
            // 
            // input
            // 
            this.input.FillWeight = 182.7411F;
            this.input.HeaderText = "input file path";
            this.input.Name = "input";
            // 
            // output
            // 
            this.output.FillWeight = 72.10463F;
            this.output.HeaderText = "output file path";
            this.output.Name = "output";
            // 
            // speed
            // 
            this.speed.FillWeight = 45.15422F;
            this.speed.HeaderText = "speed";
            this.speed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.speed.Name = "speed";
            this.speed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.speed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // fVideoSpeedControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 483);
            this.Controls.Add(this.btnCancle_SpeedControl);
            this.Controls.Add(this.btnExec_SpeedControl);
            this.Controls.Add(this.dgvInOutFile_SpeedControl);
            this.Controls.Add(this.btnOutput_Speedcontrol);
            this.Controls.Add(this.btnInput_SpeedControler);
            this.Name = "fVideoSpeedControler";
            this.Text = "fVideoSpeedControler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInOutFile_SpeedControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnInput_SpeedControler;
        private MaterialSkin.Controls.MaterialButton btnOutput_Speedcontrol;
        private System.Windows.Forms.DataGridView dgvInOutFile_SpeedControl;
        private MaterialSkin.Controls.MaterialButton btnExec_SpeedControl;
        private MaterialSkin.Controls.MaterialButton btnCancle_SpeedControl;
        private System.Windows.Forms.OpenFileDialog ofdOpenInputFile_SpeedControler;
        private System.Windows.Forms.FolderBrowserDialog fbdOpenInpuFolder_SpeedControler;
        private System.Windows.Forms.DataGridViewTextBoxColumn input;
        private System.Windows.Forms.DataGridViewTextBoxColumn output;
        private System.Windows.Forms.DataGridViewComboBoxColumn speed;
    }
}