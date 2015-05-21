namespace WindowsFormsApplication1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpPopulation = new System.Windows.Forms.GroupBox();
            this.txtProcs = new System.Windows.Forms.NumericUpDown();
            this.txtCPULoad = new System.Windows.Forms.NumericUpDown();
            this.txtTasks = new System.Windows.Forms.NumericUpDown();
            this.txtPopSize = new System.Windows.Forms.NumericUpDown();
            this.lblProcs = new System.Windows.Forms.Label();
            this.lblCPULoad = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.grdTaskInf = new System.Windows.Forms.DataGridView();
            this.lblTaskInf = new System.Windows.Forms.Label();
            this.grdPopulation = new System.Windows.Forms.DataGridView();
            this.lblPartitioning = new System.Windows.Forms.Label();
            this.grpDE = new System.Windows.Forms.GroupBox();
            this.cmdStartDE = new System.Windows.Forms.Button();
            this.txtGenerations = new System.Windows.Forms.NumericUpDown();
            this.lblGenerations = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.NumericUpDown();
            this.lblF = new System.Windows.Forms.Label();
            this.txtCR = new System.Windows.Forms.NumericUpDown();
            this.lblCR = new System.Windows.Forms.Label();
            this.prbDEProgress = new System.Windows.Forms.ProgressBar();
            this.grpPopulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPULoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPopulation)).BeginInit();
            this.grpDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCR)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPopulation
            // 
            this.grpPopulation.Controls.Add(this.txtProcs);
            this.grpPopulation.Controls.Add(this.txtCPULoad);
            this.grpPopulation.Controls.Add(this.txtTasks);
            this.grpPopulation.Controls.Add(this.txtPopSize);
            this.grpPopulation.Controls.Add(this.lblProcs);
            this.grpPopulation.Controls.Add(this.lblCPULoad);
            this.grpPopulation.Controls.Add(this.lblTasks);
            this.grpPopulation.Controls.Add(this.lblSize);
            this.grpPopulation.Location = new System.Drawing.Point(12, 12);
            this.grpPopulation.Name = "grpPopulation";
            this.grpPopulation.Size = new System.Drawing.Size(291, 83);
            this.grpPopulation.TabIndex = 0;
            this.grpPopulation.TabStop = false;
            this.grpPopulation.Text = "Population";
            // 
            // txtProcs
            // 
            this.txtProcs.Location = new System.Drawing.Point(210, 24);
            this.txtProcs.Name = "txtProcs";
            this.txtProcs.Size = new System.Drawing.Size(66, 20);
            this.txtProcs.TabIndex = 14;
            // 
            // txtCPULoad
            // 
            this.txtCPULoad.DecimalPlaces = 1;
            this.txtCPULoad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtCPULoad.Location = new System.Drawing.Point(210, 51);
            this.txtCPULoad.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCPULoad.Name = "txtCPULoad";
            this.txtCPULoad.Size = new System.Drawing.Size(66, 20);
            this.txtCPULoad.TabIndex = 13;
            // 
            // txtTasks
            // 
            this.txtTasks.Location = new System.Drawing.Point(64, 51);
            this.txtTasks.Name = "txtTasks";
            this.txtTasks.Size = new System.Drawing.Size(66, 20);
            this.txtTasks.TabIndex = 12;
            // 
            // txtPopSize
            // 
            this.txtPopSize.Location = new System.Drawing.Point(64, 24);
            this.txtPopSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtPopSize.Name = "txtPopSize";
            this.txtPopSize.Size = new System.Drawing.Size(66, 20);
            this.txtPopSize.TabIndex = 11;
            // 
            // lblProcs
            // 
            this.lblProcs.AutoSize = true;
            this.lblProcs.Location = new System.Drawing.Point(149, 28);
            this.lblProcs.Name = "lblProcs";
            this.lblProcs.Size = new System.Drawing.Size(46, 13);
            this.lblProcs.TabIndex = 9;
            this.lblProcs.Text = "uProcs.:";
            // 
            // lblCPULoad
            // 
            this.lblCPULoad.AutoSize = true;
            this.lblCPULoad.Location = new System.Drawing.Point(149, 55);
            this.lblCPULoad.Name = "lblCPULoad";
            this.lblCPULoad.Size = new System.Drawing.Size(55, 13);
            this.lblCPULoad.TabIndex = 6;
            this.lblCPULoad.Text = "Max CPU:";
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Location = new System.Drawing.Point(16, 55);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(39, 13);
            this.lblTasks.TabIndex = 4;
            this.lblTasks.Text = "Tasks:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(16, 28);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size:";
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Location = new System.Drawing.Point(23, 51);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(165, 20);
            this.cmdGenerate.TabIndex = 8;
            this.cmdGenerate.Text = "&Generate Sample Data";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // grdTaskInf
            // 
            this.grdTaskInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTaskInf.Location = new System.Drawing.Point(12, 115);
            this.grdTaskInf.Name = "grdTaskInf";
            this.grdTaskInf.Size = new System.Drawing.Size(681, 68);
            this.grdTaskInf.TabIndex = 2;
            // 
            // lblTaskInf
            // 
            this.lblTaskInf.AutoSize = true;
            this.lblTaskInf.Location = new System.Drawing.Point(13, 102);
            this.lblTaskInf.Name = "lblTaskInf";
            this.lblTaskInf.Size = new System.Drawing.Size(89, 13);
            this.lblTaskInf.TabIndex = 3;
            this.lblTaskInf.Text = "Task Information:";
            // 
            // grdPopulation
            // 
            this.grdPopulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPopulation.Location = new System.Drawing.Point(12, 218);
            this.grdPopulation.Name = "grdPopulation";
            this.grdPopulation.Size = new System.Drawing.Size(681, 179);
            this.grdPopulation.TabIndex = 4;
            // 
            // lblPartitioning
            // 
            this.lblPartitioning.AutoSize = true;
            this.lblPartitioning.Location = new System.Drawing.Point(16, 205);
            this.lblPartitioning.Name = "lblPartitioning";
            this.lblPartitioning.Size = new System.Drawing.Size(89, 13);
            this.lblPartitioning.TabIndex = 5;
            this.lblPartitioning.Text = "Task Partitioning:";
            // 
            // grpDE
            // 
            this.grpDE.Controls.Add(this.cmdStartDE);
            this.grpDE.Controls.Add(this.txtGenerations);
            this.grpDE.Controls.Add(this.lblGenerations);
            this.grpDE.Controls.Add(this.txtF);
            this.grpDE.Controls.Add(this.lblF);
            this.grpDE.Controls.Add(this.txtCR);
            this.grpDE.Controls.Add(this.lblCR);
            this.grpDE.Controls.Add(this.cmdGenerate);
            this.grpDE.Location = new System.Drawing.Point(309, 12);
            this.grpDE.Name = "grpDE";
            this.grpDE.Size = new System.Drawing.Size(384, 83);
            this.grpDE.TabIndex = 9;
            this.grpDE.TabStop = false;
            this.grpDE.Text = "DE";
            // 
            // cmdStartDE
            // 
            this.cmdStartDE.Location = new System.Drawing.Point(201, 51);
            this.cmdStartDE.Name = "cmdStartDE";
            this.cmdStartDE.Size = new System.Drawing.Size(165, 19);
            this.cmdStartDE.TabIndex = 9;
            this.cmdStartDE.Text = "&Start Simulation";
            this.cmdStartDE.UseVisualStyleBackColor = true;
            this.cmdStartDE.Click += new System.EventHandler(this.cmdStartDE_Click);
            // 
            // txtGenerations
            // 
            this.txtGenerations.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtGenerations.Location = new System.Drawing.Point(300, 24);
            this.txtGenerations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtGenerations.Name = "txtGenerations";
            this.txtGenerations.Size = new System.Drawing.Size(66, 20);
            this.txtGenerations.TabIndex = 5;
            // 
            // lblGenerations
            // 
            this.lblGenerations.AutoSize = true;
            this.lblGenerations.Location = new System.Drawing.Point(260, 27);
            this.lblGenerations.Name = "lblGenerations";
            this.lblGenerations.Size = new System.Drawing.Size(33, 13);
            this.lblGenerations.TabIndex = 4;
            this.lblGenerations.Text = "Gen.:";
            // 
            // txtF
            // 
            this.txtF.DecimalPlaces = 1;
            this.txtF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtF.Location = new System.Drawing.Point(169, 24);
            this.txtF.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(66, 20);
            this.txtF.TabIndex = 3;
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(138, 28);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(19, 13);
            this.lblF.TabIndex = 2;
            this.lblF.Text = "F.:";
            // 
            // txtCR
            // 
            this.txtCR.DecimalPlaces = 1;
            this.txtCR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtCR.Location = new System.Drawing.Point(54, 24);
            this.txtCR.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(66, 20);
            this.txtCR.TabIndex = 1;
            // 
            // lblCR
            // 
            this.lblCR.AutoSize = true;
            this.lblCR.Location = new System.Drawing.Point(20, 26);
            this.lblCR.Name = "lblCR";
            this.lblCR.Size = new System.Drawing.Size(28, 13);
            this.lblCR.TabIndex = 0;
            this.lblCR.Text = "CR.:";
            // 
            // prbDEProgress
            // 
            this.prbDEProgress.Location = new System.Drawing.Point(0, 403);
            this.prbDEProgress.Name = "prbDEProgress";
            this.prbDEProgress.Size = new System.Drawing.Size(709, 26);
            this.prbDEProgress.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 430);
            this.Controls.Add(this.prbDEProgress);
            this.Controls.Add(this.grpDE);
            this.Controls.Add(this.lblPartitioning);
            this.Controls.Add(this.grdPopulation);
            this.Controls.Add(this.lblTaskInf);
            this.Controls.Add(this.grdTaskInf);
            this.Controls.Add(this.grpPopulation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Task Partitioner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpPopulation.ResumeLayout(false);
            this.grpPopulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPULoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPopSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPopulation)).EndInit();
            this.grpDE.ResumeLayout(false);
            this.grpDE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPopulation;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.Label lblCPULoad;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblProcs;
        private System.Windows.Forms.DataGridView grdTaskInf;
        private System.Windows.Forms.Label lblTaskInf;
        private System.Windows.Forms.DataGridView grdPopulation;
        private System.Windows.Forms.Label lblPartitioning;
        private System.Windows.Forms.NumericUpDown txtPopSize;
        private System.Windows.Forms.NumericUpDown txtProcs;
        private System.Windows.Forms.NumericUpDown txtCPULoad;
        private System.Windows.Forms.NumericUpDown txtTasks;
        private System.Windows.Forms.GroupBox grpDE;
        private System.Windows.Forms.NumericUpDown txtCR;
        private System.Windows.Forms.Label lblCR;
        private System.Windows.Forms.NumericUpDown txtF;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.NumericUpDown txtGenerations;
        private System.Windows.Forms.Label lblGenerations;
        private System.Windows.Forms.Button cmdStartDE;
        private System.Windows.Forms.ProgressBar prbDEProgress;
    }
}

