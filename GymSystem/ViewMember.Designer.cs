
namespace GymSystem
{
    partial class ViewMember
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MemberSDGV = new System.Windows.Forms.DataGridView();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberSDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1221, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 40);
            this.label10.TabIndex = 45;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(575, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 39);
            this.label2.TabIndex = 44;
            this.label2.Text = "Membros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(541, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 38);
            this.label1.TabIndex = 43;
            this.label1.Text = "GYM SYSTEM\r\n";
            // 
            // MemberSDGV
            // 
            this.MemberSDGV.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MemberSDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MemberSDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberSDGV.GridColor = System.Drawing.Color.CadetBlue;
            this.MemberSDGV.Location = new System.Drawing.Point(12, 186);
            this.MemberSDGV.Name = "MemberSDGV";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberSDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.MemberSDGV.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MemberSDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.MemberSDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MemberSDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MemberSDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.MemberSDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            this.MemberSDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MemberSDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberSDGV.RowTemplate.Height = 30;
            this.MemberSDGV.Size = new System.Drawing.Size(1264, 493);
            this.MemberSDGV.TabIndex = 46;
            this.MemberSDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(426, 134);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(278, 31);
            this.SearchName.TabIndex = 47;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(699, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 60);
            this.button2.TabIndex = 48;
            this.button2.Text = "PROCURAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(864, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 60);
            this.button1.TabIndex = 49;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(597, 708);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 60);
            this.button3.TabIndex = 50;
            this.button3.Text = "VOLTAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1307, 809);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.MemberSDGV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMember";
            this.Text = "ViewMember";
            this.Load += new System.EventHandler(this.ViewMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberSDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MemberSDGV;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}