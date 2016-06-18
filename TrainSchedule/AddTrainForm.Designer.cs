namespace TrainSchedule
{
    partial class AddTrainForm
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
            this.dgvListTrains = new System.Windows.Forms.DataGridView();
            this.tbTrainN = new System.Windows.Forms.TextBox();
            this.tbTrainItinerary = new System.Windows.Forms.TextBox();
            this.lbTrainN = new System.Windows.Forms.Label();
            this.lbTrainItinerary = new System.Windows.Forms.Label();
            this.btnAddTrain = new System.Windows.Forms.Button();
            this.btnCancelTrain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTrains)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListTrains
            // 
            this.dgvListTrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTrains.Location = new System.Drawing.Point(12, 12);
            this.dgvListTrains.Name = "dgvListTrains";
            this.dgvListTrains.ReadOnly = true;
            this.dgvListTrains.RowTemplate.Height = 24;
            this.dgvListTrains.Size = new System.Drawing.Size(337, 195);
            this.dgvListTrains.TabIndex = 0;
            // 
            // tbTrainN
            // 
            this.tbTrainN.Location = new System.Drawing.Point(33, 252);
            this.tbTrainN.Name = "tbTrainN";
            this.tbTrainN.Size = new System.Drawing.Size(123, 22);
            this.tbTrainN.TabIndex = 1;
            // 
            // tbTrainItinerary
            // 
            this.tbTrainItinerary.Location = new System.Drawing.Point(212, 252);
            this.tbTrainItinerary.Name = "tbTrainItinerary";
            this.tbTrainItinerary.Size = new System.Drawing.Size(123, 22);
            this.tbTrainItinerary.TabIndex = 2;
            // 
            // lbTrainN
            // 
            this.lbTrainN.AutoSize = true;
            this.lbTrainN.Location = new System.Drawing.Point(46, 232);
            this.lbTrainN.Name = "lbTrainN";
            this.lbTrainN.Size = new System.Drawing.Size(89, 17);
            this.lbTrainN.TabIndex = 3;
            this.lbTrainN.Text = "Enter TrainN";
            // 
            // lbTrainItinerary
            // 
            this.lbTrainItinerary.AutoSize = true;
            this.lbTrainItinerary.Location = new System.Drawing.Point(223, 232);
            this.lbTrainItinerary.Name = "lbTrainItinerary";
            this.lbTrainItinerary.Size = new System.Drawing.Size(97, 17);
            this.lbTrainItinerary.TabIndex = 4;
            this.lbTrainItinerary.Text = "Enter Itinerary";
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.Location = new System.Drawing.Point(33, 307);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(123, 37);
            this.btnAddTrain.TabIndex = 5;
            this.btnAddTrain.Text = "Add";
            this.btnAddTrain.UseVisualStyleBackColor = true;
            this.btnAddTrain.Click += new System.EventHandler(this.btnAddTrain_Click);
            // 
            // btnCancelTrain
            // 
            this.btnCancelTrain.Location = new System.Drawing.Point(212, 307);
            this.btnCancelTrain.Name = "btnCancelTrain";
            this.btnCancelTrain.Size = new System.Drawing.Size(123, 37);
            this.btnCancelTrain.TabIndex = 6;
            this.btnCancelTrain.Text = "Cancel";
            this.btnCancelTrain.UseVisualStyleBackColor = true;
            this.btnCancelTrain.Click += new System.EventHandler(this.btnCancelTrain_Click);
            // 
            // AddTrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 372);
            this.Controls.Add(this.btnCancelTrain);
            this.Controls.Add(this.btnAddTrain);
            this.Controls.Add(this.lbTrainItinerary);
            this.Controls.Add(this.lbTrainN);
            this.Controls.Add(this.tbTrainItinerary);
            this.Controls.Add(this.tbTrainN);
            this.Controls.Add(this.dgvListTrains);
            this.Name = "AddTrainForm";
            this.Text = "Add new train";
            this.Load += new System.EventHandler(this.AddTrainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTrains)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListTrains;
        private System.Windows.Forms.TextBox tbTrainN;
        private System.Windows.Forms.TextBox tbTrainItinerary;
        private System.Windows.Forms.Label lbTrainN;
        private System.Windows.Forms.Label lbTrainItinerary;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.Button btnCancelTrain;
    }
}