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
            this.gbCheckPeriod = new System.Windows.Forms.GroupBox();
            this.dtpTimeLeave = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeArrive = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpActionTo = new System.Windows.Forms.DateTimePicker();
            this.dtpActionFrom = new System.Windows.Forms.DateTimePicker();
            this.tbStantionSchedule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTrainNSchedule = new System.Windows.Forms.TextBox();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbEvenUnEven = new System.Windows.Forms.RadioButton();
            this.rbOtherDate = new System.Windows.Forms.RadioButton();
            this.btnAddRecordSch = new System.Windows.Forms.Button();
            this.btnDelRecordSch = new System.Windows.Forms.Button();
            this.btnCancelRecordSch = new System.Windows.Forms.Button();
            this.btnOKRecordSch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSearchByItinerary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainsInStantion)).BeginInit();
            this.gbAddSchedule.SuspendLayout();
            this.gbCheckPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Stantion:";
            // 
            // tbSeachByStantion
            // 
            this.tbSeachByStantion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSeachByStantion.Location = new System.Drawing.Point(12, 35);
            this.tbSeachByStantion.Multiline = true;
            this.tbSeachByStantion.Name = "tbSeachByStantion";
            this.tbSeachByStantion.Size = new System.Drawing.Size(170, 22);
            this.tbSeachByStantion.TabIndex = 1;
            // 
            // btnSearchByStantion
            // 
            this.btnSearchByStantion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchByStantion.Location = new System.Drawing.Point(12, 113);
            this.btnSearchByStantion.Name = "btnSearchByStantion";
            this.btnSearchByStantion.Size = new System.Drawing.Size(75, 49);
            this.btnSearchByStantion.TabIndex = 2;
            this.btnSearchByStantion.Text = "Search";
            this.btnSearchByStantion.UseVisualStyleBackColor = true;
            this.btnSearchByStantion.Click += new System.EventHandler(this.btnSearchByStantion_Click);
            // 
            // dgvTrainsInStantion
            // 
            this.dgvTrainsInStantion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainsInStantion.Location = new System.Drawing.Point(214, 12);
            this.dgvTrainsInStantion.Name = "dgvTrainsInStantion";
            this.dgvTrainsInStantion.ReadOnly = true;
            this.dgvTrainsInStantion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTrainsInStantion.RowTemplate.Height = 24;
            this.dgvTrainsInStantion.Size = new System.Drawing.Size(342, 147);
            this.dgvTrainsInStantion.TabIndex = 3;
            // 
            // btnAddScheduleForCurrRow
            // 
            this.btnAddScheduleForCurrRow.Location = new System.Drawing.Point(107, 113);
            this.btnAddScheduleForCurrRow.Name = "btnAddScheduleForCurrRow";
            this.btnAddScheduleForCurrRow.Size = new System.Drawing.Size(75, 49);
            this.btnAddScheduleForCurrRow.TabIndex = 4;
            this.btnAddScheduleForCurrRow.Text = "Add Schedule";
            this.btnAddScheduleForCurrRow.UseVisualStyleBackColor = true;
            this.btnAddScheduleForCurrRow.Click += new System.EventHandler(this.btnAddScheduleForCurrRow_Click);
            // 
            // gbAddSchedule
            // 
            this.gbAddSchedule.Controls.Add(this.btnCancelRecordSch);
            this.gbAddSchedule.Controls.Add(this.btnDelRecordSch);
            this.gbAddSchedule.Controls.Add(this.btnOKRecordSch);
            this.gbAddSchedule.Controls.Add(this.btnAddRecordSch);
            this.gbAddSchedule.Controls.Add(this.gbCheckPeriod);
            this.gbAddSchedule.Controls.Add(this.dtpTimeLeave);
            this.gbAddSchedule.Controls.Add(this.dtpTimeArrive);
            this.gbAddSchedule.Controls.Add(this.label8);
            this.gbAddSchedule.Controls.Add(this.label7);
            this.gbAddSchedule.Controls.Add(this.dgvSchedule);
            this.gbAddSchedule.Controls.Add(this.label6);
            this.gbAddSchedule.Controls.Add(this.label5);
            this.gbAddSchedule.Controls.Add(this.label4);
            this.gbAddSchedule.Controls.Add(this.dtpActionTo);
            this.gbAddSchedule.Controls.Add(this.dtpActionFrom);
            this.gbAddSchedule.Controls.Add(this.tbStantionSchedule);
            this.gbAddSchedule.Controls.Add(this.label3);
            this.gbAddSchedule.Controls.Add(this.label2);
            this.gbAddSchedule.Controls.Add(this.tbTrainNSchedule);
            this.gbAddSchedule.Location = new System.Drawing.Point(12, 165);
            this.gbAddSchedule.Name = "gbAddSchedule";
            this.gbAddSchedule.Size = new System.Drawing.Size(550, 513);
            this.gbAddSchedule.TabIndex = 5;
            this.gbAddSchedule.TabStop = false;
            // 
            // gbCheckPeriod
            // 
            this.gbCheckPeriod.Controls.Add(this.rbOtherDate);
            this.gbCheckPeriod.Controls.Add(this.rbEvenUnEven);
            this.gbCheckPeriod.Controls.Add(this.rbWeekly);
            this.gbCheckPeriod.Controls.Add(this.rbDaily);
            this.gbCheckPeriod.Location = new System.Drawing.Point(6, 130);
            this.gbCheckPeriod.Name = "gbCheckPeriod";
            this.gbCheckPeriod.Size = new System.Drawing.Size(538, 57);
            this.gbCheckPeriod.TabIndex = 14;
            this.gbCheckPeriod.TabStop = false;
            this.gbCheckPeriod.Text = "Select one period:";
            // 
            // dtpTimeLeave
            // 
            this.dtpTimeLeave.Location = new System.Drawing.Point(173, 101);
            this.dtpTimeLeave.Name = "dtpTimeLeave";
            this.dtpTimeLeave.Size = new System.Drawing.Size(146, 23);
            this.dtpTimeLeave.TabIndex = 13;
            this.dtpTimeLeave.Value = new System.DateTime(2016, 6, 17, 0, 0, 0, 0);
            // 
            // dtpTimeArrive
            // 
            this.dtpTimeArrive.Location = new System.Drawing.Point(6, 101);
            this.dtpTimeArrive.Name = "dtpTimeArrive";
            this.dtpTimeArrive.Size = new System.Drawing.Size(146, 23);
            this.dtpTimeArrive.TabIndex = 12;
            this.dtpTimeArrive.Value = new System.DateTime(2016, 6, 17, 0, 0, 0, 0);
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
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(6, 244);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(538, 204);
            this.dgvSchedule.TabIndex = 9;
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
            this.dtpActionTo.Size = new System.Drawing.Size(156, 23);
            this.dtpActionTo.TabIndex = 5;
            this.dtpActionTo.Value = new System.DateTime(2016, 6, 17, 0, 0, 0, 0);
            // 
            // dtpActionFrom
            // 
            this.dtpActionFrom.Location = new System.Drawing.Point(352, 42);
            this.dtpActionFrom.Name = "dtpActionFrom";
            this.dtpActionFrom.Size = new System.Drawing.Size(156, 23);
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
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Location = new System.Drawing.Point(6, 23);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(60, 21);
            this.rbDaily.TabIndex = 15;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "Daily";
            this.rbDaily.UseVisualStyleBackColor = true;
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(134, 22);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(75, 21);
            this.rbWeekly.TabIndex = 16;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            // 
            // rbEvenUnEven
            // 
            this.rbEvenUnEven.AutoSize = true;
            this.rbEvenUnEven.Location = new System.Drawing.Point(268, 23);
            this.rbEvenUnEven.Name = "rbEvenUnEven";
            this.rbEvenUnEven.Size = new System.Drawing.Size(115, 21);
            this.rbEvenUnEven.TabIndex = 18;
            this.rbEvenUnEven.TabStop = true;
            this.rbEvenUnEven.Text = "Even\\UnEven";
            this.rbEvenUnEven.UseVisualStyleBackColor = true;
            // 
            // rbOtherDate
            // 
            this.rbOtherDate.AutoSize = true;
            this.rbOtherDate.Location = new System.Drawing.Point(425, 22);
            this.rbOtherDate.Name = "rbOtherDate";
            this.rbOtherDate.Size = new System.Drawing.Size(99, 21);
            this.rbOtherDate.TabIndex = 19;
            this.rbOtherDate.TabStop = true;
            this.rbOtherDate.Text = "Other Date";
            this.rbOtherDate.UseVisualStyleBackColor = true;
            // 
            // btnAddRecordSch
            // 
            this.btnAddRecordSch.Location = new System.Drawing.Point(12, 193);
            this.btnAddRecordSch.Name = "btnAddRecordSch";
            this.btnAddRecordSch.Size = new System.Drawing.Size(113, 45);
            this.btnAddRecordSch.TabIndex = 15;
            this.btnAddRecordSch.Text = "Add Record In Schedule";
            this.btnAddRecordSch.UseVisualStyleBackColor = true;
            this.btnAddRecordSch.Click += new System.EventHandler(this.btnAddRecordSch_Click);
            // 
            // btnDelRecordSch
            // 
            this.btnDelRecordSch.Location = new System.Drawing.Point(140, 193);
            this.btnDelRecordSch.Name = "btnDelRecordSch";
            this.btnDelRecordSch.Size = new System.Drawing.Size(113, 45);
            this.btnDelRecordSch.TabIndex = 16;
            this.btnDelRecordSch.Text = "Delete Record In Schedule";
            this.btnDelRecordSch.UseVisualStyleBackColor = true;
            this.btnDelRecordSch.Click += new System.EventHandler(this.btnDelRecordSch_Click);
            // 
            // btnCancelRecordSch
            // 
            this.btnCancelRecordSch.Location = new System.Drawing.Point(431, 460);
            this.btnCancelRecordSch.Name = "btnCancelRecordSch";
            this.btnCancelRecordSch.Size = new System.Drawing.Size(113, 45);
            this.btnCancelRecordSch.TabIndex = 17;
            this.btnCancelRecordSch.Text = "Cancel";
            this.btnCancelRecordSch.UseVisualStyleBackColor = true;
            this.btnCancelRecordSch.Click += new System.EventHandler(this.btnCancelRecordSch_Click);
            // 
            // btnOKRecordSch
            // 
            this.btnOKRecordSch.Location = new System.Drawing.Point(312, 460);
            this.btnOKRecordSch.Name = "btnOKRecordSch";
            this.btnOKRecordSch.Size = new System.Drawing.Size(113, 45);
            this.btnOKRecordSch.TabIndex = 18;
            this.btnOKRecordSch.Text = "OK";
            this.btnOKRecordSch.UseVisualStyleBackColor = true;
            this.btnOKRecordSch.Click += new System.EventHandler(this.btnOKRecordSch_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Enter Itinerary:";
            // 
            // tbSearchByItinerary
            // 
            this.tbSearchByItinerary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchByItinerary.Location = new System.Drawing.Point(12, 83);
            this.tbSearchByItinerary.Multiline = true;
            this.tbSearchByItinerary.Name = "tbSearchByItinerary";
            this.tbSearchByItinerary.Size = new System.Drawing.Size(170, 22);
            this.tbSearchByItinerary.TabIndex = 7;
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 682);
            this.Controls.Add(this.tbSearchByItinerary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbAddSchedule);
            this.Controls.Add(this.btnAddScheduleForCurrRow);
            this.Controls.Add(this.dgvTrainsInStantion);
            this.Controls.Add(this.btnSearchByStantion);
            this.Controls.Add(this.tbSeachByStantion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AddScheduleForm";
            this.Text = "AddScheduleForm";
            this.Load += new System.EventHandler(this.AddScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainsInStantion)).EndInit();
            this.gbAddSchedule.ResumeLayout(false);
            this.gbAddSchedule.PerformLayout();
            this.gbCheckPeriod.ResumeLayout(false);
            this.gbCheckPeriod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTimeLeave;
        private System.Windows.Forms.DateTimePicker dtpTimeArrive;
        private System.Windows.Forms.GroupBox gbCheckPeriod;
        private System.Windows.Forms.RadioButton rbOtherDate;
        private System.Windows.Forms.RadioButton rbEvenUnEven;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.Button btnCancelRecordSch;
        private System.Windows.Forms.Button btnDelRecordSch;
        private System.Windows.Forms.Button btnOKRecordSch;
        private System.Windows.Forms.Button btnAddRecordSch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSearchByItinerary;
    }
}