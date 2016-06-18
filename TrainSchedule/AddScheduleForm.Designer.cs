namespace TrainSchedule
{
    partial class AddScheduleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSeachByStantion = new System.Windows.Forms.TextBox();
            this.btnSearchByStantion = new System.Windows.Forms.Button();
            this.dgvTrainsInStantion = new System.Windows.Forms.DataGridView();
            this.btnAddScheduleForCurrRow = new System.Windows.Forms.Button();
            this.gbAddSchedule = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpActionTo = new System.Windows.Forms.DateTimePicker();
            this.dtpActionFrom = new System.Windows.Forms.DateTimePicker();
            this.tbStantionSchedule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTrainNSchedule = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTimeArrive = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeLeave = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainsInStantion)).BeginInit();
            this.gbAddSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Stantion";
            // 
            // tbSeachByStantion
            // 
            this.tbSeachByStantion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSeachByStantion.Location = new System.Drawing.Point(12, 56);
            this.tbSeachByStantion.Multiline = true;
            this.tbSeachByStantion.Name = "tbSeachByStantion";
            this.tbSeachByStantion.Size = new System.Drawing.Size(170, 38);
            this.tbSeachByStantion.TabIndex = 1;
            // 
            // btnSearchByStantion
            // 
            this.btnSearchByStantion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchByStantion.Location = new System.Drawing.Point(132, 12);
            this.btnSearchByStantion.Name = "btnSearchByStantion";
            this.btnSearchByStantion.Size = new System.Drawing.Size(50, 38);
            this.btnSearchByStantion.TabIndex = 2;
            this.btnSearchByStantion.Text = "S";
            this.btnSearchByStantion.UseVisualStyleBackColor = true;
            this.btnSearchByStantion.Click += new System.EventHandler(this.btnSearchByStantion_Click);
            // 
            // dgvTrainsInStantion
            // 
            this.dgvTrainsInStantion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainsInStantion.Location = new System.Drawing.Point(220, 12);
            this.dgvTrainsInStantion.Name = "dgvTrainsInStantion";
            this.dgvTrainsInStantion.ReadOnly = true;
            this.dgvTrainsInStantion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTrainsInStantion.RowTemplate.Height = 24;
            this.dgvTrainsInStantion.Size = new System.Drawing.Size(359, 147);
            this.dgvTrainsInStantion.TabIndex = 3;
            // 
            // btnAddScheduleForCurrRow
            // 
            this.btnAddScheduleForCurrRow.Location = new System.Drawing.Point(45, 113);
            this.btnAddScheduleForCurrRow.Name = "btnAddScheduleForCurrRow";
            this.btnAddScheduleForCurrRow.Size = new System.Drawing.Size(119, 33);
            this.btnAddScheduleForCurrRow.TabIndex = 4;
            this.btnAddScheduleForCurrRow.Text = "Add Schedule";
            this.btnAddScheduleForCurrRow.UseVisualStyleBackColor = true;
            this.btnAddScheduleForCurrRow.Click += new System.EventHandler(this.btnAddScheduleForCurrRow_Click);
            // 
            // gbAddSchedule
            // 
            this.gbAddSchedule.Controls.Add(this.dtpTimeLeave);
            this.gbAddSchedule.Controls.Add(this.dtpTimeArrive);
            this.gbAddSchedule.Controls.Add(this.label8);
            this.gbAddSchedule.Controls.Add(this.label7);
            this.gbAddSchedule.Controls.Add(this.dataGridView1);
            this.gbAddSchedule.Controls.Add(this.label6);
            this.gbAddSchedule.Controls.Add(this.label5);
            this.gbAddSchedule.Controls.Add(this.label4);
            this.gbAddSchedule.Controls.Add(this.dtpActionTo);
            this.gbAddSchedule.Controls.Add(this.dtpActionFrom);
            this.gbAddSchedule.Controls.Add(this.tbStantionSchedule);
            this.gbAddSchedule.Controls.Add(this.label3);
            this.gbAddSchedule.Controls.Add(this.label2);
            this.gbAddSchedule.Controls.Add(this.tbTrainNSchedule);
            this.gbAddSchedule.Location = new System.Drawing.Point(12, 186);
            this.gbAddSchedule.Name = "gbAddSchedule";
            this.gbAddSchedule.Size = new System.Drawing.Size(567, 484);
            this.gbAddSchedule.TabIndex = 5;
            this.gbAddSchedule.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(348, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "In action to:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(348, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "In action from:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 6;
            // 
            // dtpActionTo
            // 
            this.dtpActionTo.Location = new System.Drawing.Point(352, 101);
            this.dtpActionTo.Name = "dtpActionTo";
            this.dtpActionTo.Size = new System.Drawing.Size(200, 23);
            this.dtpActionTo.TabIndex = 5;
            this.dtpActionTo.Value = new System.DateTime(2016, 6, 17, 0, 0, 0, 0);
            // 
            // dtpActionFrom
            // 
            this.dtpActionFrom.Location = new System.Drawing.Point(352, 42);
            this.dtpActionFrom.Name = "dtpActionFrom";
            this.dtpActionFrom.Size = new System.Drawing.Size(200, 23);
            this.dtpActionFrom.TabIndex = 4;
            this.dtpActionFrom.Value = new System.DateTime(2016, 6, 17, 0, 0, 0, 0);
            // 
            // tbStantionSchedule
            // 
            this.tbStantionSchedule.Location = new System.Drawing.Point(6, 42);
            this.tbStantionSchedule.Name = "tbStantionSchedule";
            this.tbStantionSchedule.Size = new System.Drawing.Size(146, 23);
            this.tbStantionSchedule.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stantion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(169, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TrainN";
            // 
            // tbTrainNSchedule
            // 
            this.tbTrainNSchedule.Location = new System.Drawing.Point(173, 42);
            this.tbTrainNSchedule.Name = "tbTrainNSchedule";
            this.tbTrainNSchedule.Size = new System.Drawing.Size(146, 23);
            this.tbTrainNSchedule.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Time Arrive";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(169, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Time Leave";
            // 
            // dtpTimeArrive
            // 
            this.dtpTimeArrive.Location = new System.Drawing.Point(6, 101);
            this.dtpTimeArrive.Name = "dtpTimeArrive";
            this.dtpTimeArrive.Size = new System.Drawing.Size(146, 23);
            this.dtpTimeArrive.TabIndex = 12;
            this.dtpTimeArrive.Value = new System.DateTime(2016, 6, 17, 0, 0, 0, 0);
            // 
            // dtpTimeLeave
            // 
            this.dtpTimeLeave.Location = new System.Drawing.Point(173, 101);
            this.dtpTimeLeave.Name = "dtpTimeLeave";
            this.dtpTimeLeave.Size = new System.Drawing.Size(146, 23);
            this.dtpTimeLeave.TabIndex = 13;
            this.dtpTimeLeave.Value = new System.DateTime(2016, 6, 17, 0, 0, 0, 0);
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 682);
            this.Controls.Add(this.gbAddSchedule);
            this.Controls.Add(this.btnAddScheduleForCurrRow);
            this.Controls.Add(this.dgvTrainsInStantion);
            this.Controls.Add(this.btnSearchByStantion);
            this.Controls.Add(this.tbSeachByStantion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AddScheduleForm";
            this.Text = "AddScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainsInStantion)).EndInit();
            this.gbAddSchedule.ResumeLayout(false);
            this.gbAddSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSeachByStantion;
        private System.Windows.Forms.Button btnSearchByStantion;
        private System.Windows.Forms.DataGridView dgvTrainsInStantion;
        private System.Windows.Forms.Button btnAddScheduleForCurrRow;
        private System.Windows.Forms.GroupBox gbAddSchedule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpActionTo;
        private System.Windows.Forms.DateTimePicker dtpActionFrom;
        private System.Windows.Forms.TextBox tbStantionSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTrainNSchedule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTimeLeave;
        private System.Windows.Forms.DateTimePicker dtpTimeArrive;
    }
}