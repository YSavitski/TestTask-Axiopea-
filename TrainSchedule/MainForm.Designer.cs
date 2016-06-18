namespace TrainSchedule
{
    partial class MainForm
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
            this.dgvListSchedule = new System.Windows.Forms.DataGridView();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.tbStantionNameFind = new System.Windows.Forms.TextBox();
            this.dtpCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddTrain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListSchedule
            // 
            this.dgvListSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSchedule.Location = new System.Drawing.Point(12, 160);
            this.dgvListSchedule.Name = "dgvListSchedule";
            this.dgvListSchedule.ReadOnly = true;
            this.dgvListSchedule.RowTemplate.Height = 24;
            this.dgvListSchedule.Size = new System.Drawing.Size(852, 347);
            this.dgvListSchedule.TabIndex = 0;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(931, 88);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(157, 49);
            this.btnAddSchedule.TabIndex = 1;
            this.btnAddSchedule.Text = "Add Schedule";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // tbStantionNameFind
            // 
            this.tbStantionNameFind.Location = new System.Drawing.Point(79, 7);
            this.tbStantionNameFind.Name = "tbStantionNameFind";
            this.tbStantionNameFind.Size = new System.Drawing.Size(200, 22);
            this.tbStantionNameFind.TabIndex = 2;
            // 
            // dtpCurrentDate
            // 
            this.dtpCurrentDate.Location = new System.Drawing.Point(79, 44);
            this.dtpCurrentDate.Name = "dtpCurrentDate";
            this.dtpCurrentDate.Size = new System.Drawing.Size(200, 22);
            this.dtpCurrentDate.TabIndex = 3;
            this.dtpCurrentDate.ValueChanged += new System.EventHandler(this.dtpCurrentDate_ValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 49);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.Location = new System.Drawing.Point(931, 12);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(157, 49);
            this.btnAddTrain.TabIndex = 5;
            this.btnAddTrain.Text = "Add Train";
            this.btnAddTrain.UseVisualStyleBackColor = true;
            this.btnAddTrain.Click += new System.EventHandler(this.btnAddTrain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stantion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date In:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTrain);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpCurrentDate);
            this.Controls.Add(this.tbStantionNameFind);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.dgvListSchedule);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListSchedule;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.TextBox tbStantionNameFind;
        private System.Windows.Forms.DateTimePicker dtpCurrentDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

