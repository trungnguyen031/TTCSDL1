namespace TTCSDL1
{
    partial class SINHVIEN
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
            this.components = new System.ComponentModel.Container();
            this.THEM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DTV_SV = new System.Windows.Forms.DataGridView();
            this.txtmsv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.qLPhongMayDataSet = new TTCSDL1.QLPhongMayDataSet();
            this.qLPhongMayDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.BTNTK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTV_SV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMayDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // THEM
            // 
            this.THEM.Location = new System.Drawing.Point(495, 54);
            this.THEM.Name = "THEM";
            this.THEM.Size = new System.Drawing.Size(75, 53);
            this.THEM.TabIndex = 0;
            this.THEM.Text = "Thêm";
            this.THEM.UseVisualStyleBackColor = true;
            this.THEM.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // DTV_SV
            // 
            this.DTV_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTV_SV.Location = new System.Drawing.Point(12, 215);
            this.DTV_SV.Name = "DTV_SV";
            this.DTV_SV.Size = new System.Drawing.Size(558, 223);
            this.DTV_SV.TabIndex = 2;
            this.DTV_SV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTV_SV_CellContentClick);
            // 
            // txtmsv
            // 
            this.txtmsv.Location = new System.Drawing.Point(112, 57);
            this.txtmsv.Multiline = true;
            this.txtmsv.Name = "txtmsv";
            this.txtmsv.Size = new System.Drawing.Size(123, 20);
            this.txtmsv.TabIndex = 3;
            this.txtmsv.TextChanged += new System.EventHandler(this.txtmsv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(112, 103);
            this.txtten.Multiline = true;
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(123, 20);
            this.txtten.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Sinh";
            // 
            // txtns
            // 
            this.txtns.Location = new System.Drawing.Point(314, 57);
            this.txtns.Multiline = true;
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(141, 20);
            this.txtns.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới Tính";
            // 
            // txtgt
            // 
            this.txtgt.Location = new System.Drawing.Point(314, 103);
            this.txtgt.Multiline = true;
            this.txtgt.Name = "txtgt";
            this.txtgt.Size = new System.Drawing.Size(141, 20);
            this.txtgt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(112, 154);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(343, 23);
            this.txtdiachi.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(603, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 53);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(482, 154);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(214, 26);
            this.txttimkiem.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(627, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 67);
            this.button4.TabIndex = 8;
            this.button4.Text = "Hiển Thị";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // qLPhongMayDataSet
            // 
            this.qLPhongMayDataSet.DataSetName = "QLPhongMayDataSet";
            this.qLPhongMayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLPhongMayDataSetBindingSource
            // 
            this.qLPhongMayDataSetBindingSource.DataSource = this.qLPhongMayDataSet;
            this.qLPhongMayDataSetBindingSource.Position = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nhập để tìm kiếm";
            // 
            // BTNTK
            // 
            this.BTNTK.Location = new System.Drawing.Point(713, 154);
            this.BTNTK.Name = "BTNTK";
            this.BTNTK.Size = new System.Drawing.Size(75, 26);
            this.BTNTK.TabIndex = 10;
            this.BTNTK.Text = "Tìm Kiếm";
            this.BTNTK.UseVisualStyleBackColor = true;
            this.BTNTK.Click += new System.EventHandler(this.BTNTK_Click);
            // 
            // SINHVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNTK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtgt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmsv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTV_SV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.THEM);
            this.Name = "SINHVIEN";
            this.Text = "Sinh Viên";
            this.Load += new System.EventHandler(this.SINHVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTV_SV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMayDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button THEM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DTV_SV;
        private System.Windows.Forms.TextBox txtmsv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource qLPhongMayDataSetBindingSource;
        private QLPhongMayDataSet qLPhongMayDataSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTNTK;
    }
}

