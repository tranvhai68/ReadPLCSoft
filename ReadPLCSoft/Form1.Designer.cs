namespace ReadPLCSoft
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_quycach20 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NguoiTT87 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NguoiTT80 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NguoiTT83 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_quycach23 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.address52 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.address54 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.625F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_main, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_read, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(641, 485);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_main
            // 
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_main, 3);
            this.dgv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_main.Location = new System.Drawing.Point(3, 32);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.Size = new System.Drawing.Size(635, 450);
            this.dgv_main.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Setting";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(421, 3);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(130, 23);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 485);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.address54);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.address52);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_quycach23);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_quycach20);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_NguoiTT87);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_NguoiTT80);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_NguoiTT83);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 485);
            this.panel1.TabIndex = 0;
            // 
            // txt_quycach20
            // 
            this.txt_quycach20.Location = new System.Drawing.Point(15, 200);
            this.txt_quycach20.Name = "txt_quycach20";
            this.txt_quycach20.Size = new System.Drawing.Size(122, 20);
            this.txt_quycach20.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quy cách(20)";
            // 
            // txt_NguoiTT87
            // 
            this.txt_NguoiTT87.Location = new System.Drawing.Point(15, 150);
            this.txt_NguoiTT87.Name = "txt_NguoiTT87";
            this.txt_NguoiTT87.Size = new System.Drawing.Size(122, 20);
            this.txt_NguoiTT87.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Người TT (87)";
            // 
            // txt_NguoiTT80
            // 
            this.txt_NguoiTT80.Location = new System.Drawing.Point(15, 57);
            this.txt_NguoiTT80.Name = "txt_NguoiTT80";
            this.txt_NguoiTT80.Size = new System.Drawing.Size(122, 20);
            this.txt_NguoiTT80.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Người TT (80)";
            // 
            // txt_NguoiTT83
            // 
            this.txt_NguoiTT83.Location = new System.Drawing.Point(15, 107);
            this.txt_NguoiTT83.Name = "txt_NguoiTT83";
            this.txt_NguoiTT83.Size = new System.Drawing.Size(122, 20);
            this.txt_NguoiTT83.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người TT (83)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quy cách(23)";
            // 
            // txt_quycach23
            // 
            this.txt_quycach23.Location = new System.Drawing.Point(15, 243);
            this.txt_quycach23.Name = "txt_quycach23";
            this.txt_quycach23.Size = new System.Drawing.Size(122, 20);
            this.txt_quycach23.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "address(52)";
            // 
            // address52
            // 
            this.address52.Location = new System.Drawing.Point(15, 298);
            this.address52.Name = "address52";
            this.address52.Size = new System.Drawing.Size(122, 20);
            this.address52.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "address(54)";
            // 
            // address54
            // 
            this.address54.Location = new System.Drawing.Point(15, 359);
            this.address54.Name = "address54";
            this.address54.Size = new System.Drawing.Size(122, 20);
            this.address54.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_quycach20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NguoiTT87;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NguoiTT83;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NguoiTT80;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address54;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox address52;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_quycach23;
        private System.Windows.Forms.Label label5;
    }
}

