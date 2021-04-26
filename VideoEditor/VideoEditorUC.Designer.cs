namespace VideoEditor
{
    partial class VideoEditorUC
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
            this.btnGetAudioFormVideoOP = new System.Windows.Forms.Button();
            this.btnVideoAudioCuttingOP = new System.Windows.Forms.Button();
            this.btnAddSubForVideoOP = new System.Windows.Forms.Button();
            this.btnVideoDesignOP = new System.Windows.Forms.Button();
            this.btnVideoAudioSpeedControlOP = new System.Windows.Forms.Button();
            this.btnConvertVideoAudioOP = new System.Windows.Forms.Button();
            this.dgvShowProgress = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProgress)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetAudioFormVideoOP
            // 
            this.btnGetAudioFormVideoOP.Location = new System.Drawing.Point(97, 3);
            this.btnGetAudioFormVideoOP.Name = "btnGetAudioFormVideoOP";
            this.btnGetAudioFormVideoOP.Size = new System.Drawing.Size(88, 51);
            this.btnGetAudioFormVideoOP.TabIndex = 0;
            this.btnGetAudioFormVideoOP.Text = "Video --> MP3";
            this.btnGetAudioFormVideoOP.UseVisualStyleBackColor = true;
            this.btnGetAudioFormVideoOP.Click += new System.EventHandler(this.btnGetAudioFormVideoOP_Click);
            // 
            // btnVideoAudioCuttingOP
            // 
            this.btnVideoAudioCuttingOP.Location = new System.Drawing.Point(3, 3);
            this.btnVideoAudioCuttingOP.Name = "btnVideoAudioCuttingOP";
            this.btnVideoAudioCuttingOP.Size = new System.Drawing.Size(88, 51);
            this.btnVideoAudioCuttingOP.TabIndex = 0;
            this.btnVideoAudioCuttingOP.Text = "Cut Video and Audio";
            this.btnVideoAudioCuttingOP.UseVisualStyleBackColor = true;
            this.btnVideoAudioCuttingOP.Click += new System.EventHandler(this.btnVideoAudioCuttingOP_Click);
            // 
            // btnAddSubForVideoOP
            // 
            this.btnAddSubForVideoOP.Location = new System.Drawing.Point(191, 3);
            this.btnAddSubForVideoOP.Name = "btnAddSubForVideoOP";
            this.btnAddSubForVideoOP.Size = new System.Drawing.Size(88, 51);
            this.btnAddSubForVideoOP.TabIndex = 0;
            this.btnAddSubForVideoOP.Text = "Add Subtitles";
            this.btnAddSubForVideoOP.UseVisualStyleBackColor = true;
            this.btnAddSubForVideoOP.Click += new System.EventHandler(this.btnAddSubForVideoOP_Click);
            // 
            // btnVideoDesignOP
            // 
            this.btnVideoDesignOP.Location = new System.Drawing.Point(191, 60);
            this.btnVideoDesignOP.Name = "btnVideoDesignOP";
            this.btnVideoDesignOP.Size = new System.Drawing.Size(88, 51);
            this.btnVideoDesignOP.TabIndex = 1;
            this.btnVideoDesignOP.Text = "Create Video";
            this.btnVideoDesignOP.UseVisualStyleBackColor = true;
            this.btnVideoDesignOP.Click += new System.EventHandler(this.btnVideoDesignOP_Click);
            // 
            // btnVideoAudioSpeedControlOP
            // 
            this.btnVideoAudioSpeedControlOP.Location = new System.Drawing.Point(97, 60);
            this.btnVideoAudioSpeedControlOP.Name = "btnVideoAudioSpeedControlOP";
            this.btnVideoAudioSpeedControlOP.Size = new System.Drawing.Size(88, 51);
            this.btnVideoAudioSpeedControlOP.TabIndex = 2;
            this.btnVideoAudioSpeedControlOP.Text = "Adjust Video Speed";
            this.btnVideoAudioSpeedControlOP.UseVisualStyleBackColor = true;
            this.btnVideoAudioSpeedControlOP.Click += new System.EventHandler(this.btnVideoAudioSpeedControlOP_Click);
            // 
            // btnConvertVideoAudioOP
            // 
            this.btnConvertVideoAudioOP.Location = new System.Drawing.Point(3, 60);
            this.btnConvertVideoAudioOP.Name = "btnConvertVideoAudioOP";
            this.btnConvertVideoAudioOP.Size = new System.Drawing.Size(88, 51);
            this.btnConvertVideoAudioOP.TabIndex = 3;
            this.btnConvertVideoAudioOP.Text = "Convert Video Format";
            this.btnConvertVideoAudioOP.UseVisualStyleBackColor = true;
            this.btnConvertVideoAudioOP.Click += new System.EventHandler(this.btnConvertVideoAudioOP_Click);
            // 
            // dgvShowProgress
            // 
            this.dgvShowProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowProgress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvShowProgress.Location = new System.Drawing.Point(303, 24);
            this.dgvShowProgress.Name = "dgvShowProgress";
            this.dgvShowProgress.Size = new System.Drawing.Size(451, 279);
            this.dgvShowProgress.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "input";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "output";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "title";
            this.Column3.Name = "Column3";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnVideoAudioCuttingOP);
            this.flowLayoutPanel1.Controls.Add(this.btnGetAudioFormVideoOP);
            this.flowLayoutPanel1.Controls.Add(this.btnAddSubForVideoOP);
            this.flowLayoutPanel1.Controls.Add(this.btnConvertVideoAudioOP);
            this.flowLayoutPanel1.Controls.Add(this.btnVideoAudioSpeedControlOP);
            this.flowLayoutPanel1.Controls.Add(this.btnVideoDesignOP);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(282, 264);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 292);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Editor";
            // 
            // VideoEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvShowProgress);
            this.Name = "VideoEditorUC";
            this.Size = new System.Drawing.Size(757, 307);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProgress)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetAudioFormVideoOP;
        private System.Windows.Forms.Button btnVideoAudioCuttingOP;
        private System.Windows.Forms.Button btnAddSubForVideoOP;
        private System.Windows.Forms.Button btnVideoDesignOP;
        private System.Windows.Forms.Button btnVideoAudioSpeedControlOP;
        private System.Windows.Forms.Button btnConvertVideoAudioOP;
        private System.Windows.Forms.DataGridView dgvShowProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
