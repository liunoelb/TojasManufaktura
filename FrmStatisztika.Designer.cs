namespace TojasManufaktura
{
    partial class FrmStatisztika
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.tbMaxColor = new System.Windows.Forms.TextBox();
            this.tbSumWeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Munkás neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kiválasztott hónap sorszáma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Termelési napló";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDate,
            this.ColColor,
            this.ColAmount});
            this.dgv.Location = new System.Drawing.Point(25, 112);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(613, 298);
            this.dgv.TabIndex = 3;
            // 
            // ColDate
            // 
            this.ColDate.FillWeight = 111.9289F;
            this.ColDate.HeaderText = "Dátum";
            this.ColDate.Name = "ColDate";
            // 
            // ColColor
            // 
            this.ColColor.FillWeight = 111.9289F;
            this.ColColor.HeaderText = "Szín";
            this.ColColor.Name = "ColColor";
            // 
            // ColAmount
            // 
            this.ColAmount.FillWeight = 76.14214F;
            this.ColAmount.HeaderText = "Mennyiség";
            this.ColAmount.Name = "ColAmount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "A hónapban legtöbbet gyártott tojás színe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adott hónapban termelt tojások összsúlya";
            // 
            // cbWorker
            // 
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(152, 27);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(203, 24);
            this.cbWorker.TabIndex = 6;
            this.cbWorker.SelectedIndexChanged += new System.EventHandler(this.CbWorker_SelectedIndexChanged);
            // 
            // nudMonth
            // 
            this.nudMonth.Location = new System.Drawing.Point(597, 28);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(41, 23);
            this.nudMonth.TabIndex = 7;
            this.nudMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.ValueChanged += new System.EventHandler(this.NudMonth_ValueChanged);
            // 
            // tbMaxColor
            // 
            this.tbMaxColor.Location = new System.Drawing.Point(538, 437);
            this.tbMaxColor.Name = "tbMaxColor";
            this.tbMaxColor.Size = new System.Drawing.Size(100, 23);
            this.tbMaxColor.TabIndex = 8;
            // 
            // tbSumWeight
            // 
            this.tbSumWeight.Location = new System.Drawing.Point(538, 479);
            this.tbSumWeight.Name = "tbSumWeight";
            this.tbSumWeight.Size = new System.Drawing.Size(100, 23);
            this.tbSumWeight.TabIndex = 9;
            // 
            // FrmStatisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(669, 535);
            this.Controls.Add(this.tbSumWeight);
            this.Controls.Add(this.tbMaxColor);
            this.Controls.Add(this.nudMonth);
            this.Controls.Add(this.cbWorker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStatisztika";
            this.Text = "FrmStatisztika";
            this.Load += new System.EventHandler(this.FrmStatisztika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbWorker;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.TextBox tbMaxColor;
        private System.Windows.Forms.TextBox tbSumWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAmount;
    }
}