namespace TTCSDL1
{
    partial class LOPHP
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtthp = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.txttl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTV_LHP = new System.Windows.Forms.DataGridView();
            this.txtml = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.qLPhongMayDataSet = new TTCSDL1.QLPhongMayDataSet();
            this.qLPhongMayDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DTV_LHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMayDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(700, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtthp
            // 
            this.txtthp.Location = new System.Drawing.Point(116, 149);
            this.txtthp.Multiline = true;
            this.txtthp.Name = "txtthp";
            this.txtthp.Size = new System.Drawing.Size(233, 20);
            this.txtthp.TabIndex = 1;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(461, 120);
            this.txttk.Multiline = true;
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(233, 20);
            this.txttk.TabIndex = 1;
            // 
            // txttl
            // 
            this.txttl.Location = new System.Drawing.Point(116, 94);
            this.txttl.Multiline = true;
            this.txttl.Name = "txttl";
            this.txttl.Size = new System.Drawing.Size(233, 20);
            this.txttl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên lớp ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên học phần";
            // 
            // DTV_LHP
            // 
            this.DTV_LHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTV_LHP.Location = new System.Drawing.Point(23, 206);
            this.DTV_LHP.Name = "DTV_LHP";
            this.DTV_LHP.Size = new System.Drawing.Size(470, 216);
            this.DTV_LHP.TabIndex = 5;
            this.DTV_LHP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTV_LHP_CellContentClick);
            // 
            // txtml
            // 
            this.txtml.Location = new System.Drawing.Point(116, 43);
            this.txtml.Multiline = true;
            this.txtml.Name = "txtml";
            this.txtml.Size = new System.Drawing.Size(233, 20);
            this.txtml.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập để tìm kiếm";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(700, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(602, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Chi tiết học phần";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(619, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Hiện thị";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(619, 333);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Nghiệp vụ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            // LOPHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTV_LHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttl);
            this.Controls.Add(this.txtml);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.txtthp);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "LOPHP";
            this.Text = "LOPHP";
            this.Load += new System.EventHandler(this.LOPHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTV_LHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMayDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtthp;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txttl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DTV_LHP;
        private System.Windows.Forms.TextBox txtml;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource qLPhongMayDataSetBindingSource;
        private QLPhongMayDataSet qLPhongMayDataSet;
    }
}