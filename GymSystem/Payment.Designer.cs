
namespace GymSystem
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.Periode = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NameCB = new System.Windows.Forms.ComboBox();
            this.PaymentDGV = new System.Windows.Forms.DataGridView();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(513, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pagamento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(513, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "GYM SYSTEM\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1226, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 39);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mensalidade:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 39);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nome:";
            // 
            // AmountTb
            // 
            this.AmountTb.Location = new System.Drawing.Point(23, 435);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(250, 31);
            this.AmountTb.TabIndex = 32;
            // 
            // Periode
            // 
            this.Periode.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Periode.Location = new System.Drawing.Point(23, 227);
            this.Periode.Name = "Periode";
            this.Periode.Size = new System.Drawing.Size(193, 31);
            this.Periode.TabIndex = 33;
            this.Periode.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 39);
            this.label6.TabIndex = 49;
            this.label6.Text = "Pagamento Mensal";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(240, 581);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 53);
            this.button3.TabIndex = 52;
            this.button3.Text = "VOLTAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 53);
            this.button1.TabIndex = 51;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(134, 581);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 53);
            this.button2.TabIndex = 50;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NameCB
            // 
            this.NameCB.FormattingEnabled = true;
            this.NameCB.Items.AddRange(new object[] {
            "6h-8h",
            "8h-10h",
            "18h-20h",
            "20h-22h"});
            this.NameCB.Location = new System.Drawing.Point(25, 313);
            this.NameCB.Name = "NameCB";
            this.NameCB.Size = new System.Drawing.Size(228, 33);
            this.NameCB.TabIndex = 53;
            // 
            // PaymentDGV
            // 
            this.PaymentDGV.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PaymentDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentDGV.GridColor = System.Drawing.Color.CadetBlue;
            this.PaymentDGV.Location = new System.Drawing.Point(382, 204);
            this.PaymentDGV.Name = "PaymentDGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PaymentDGV.RowHeadersWidth = 62;
            this.PaymentDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PaymentDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PaymentDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.PaymentDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            this.PaymentDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.PaymentDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentDGV.RowTemplate.Height = 25;
            this.PaymentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaymentDGV.Size = new System.Drawing.Size(885, 493);
            this.PaymentDGV.TabIndex = 54;
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(382, 155);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(319, 31);
            this.SearchName.TabIndex = 55;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(730, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 53);
            this.button4.TabIndex = 56;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(847, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 53);
            this.button5.TabIndex = 57;
            this.button5.Text = "LIMPAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1279, 797);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.PaymentDGV);
            this.Controls.Add(this.NameCB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Periode);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "e";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.DateTimePicker Periode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox NameCB;
        private System.Windows.Forms.DataGridView PaymentDGV;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}