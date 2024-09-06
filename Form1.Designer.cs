namespace LeChucGiang_Buoi1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            a = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            txta = new TextBox();
            txtb = new TextBox();
            txtc = new TextBox();
            txtkq = new TextBox();
            label6 = new Label();
            btngiai = new Button();
            btnxoa = new Button();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Tahoma", 24F);
            label1.Location = new Point(211, 23);
            label1.Name = "label1";
            label1.Size = new Size(353, 41);
            label1.TabIndex = 0;
            label1.Text = "Giải phương trình bậc 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13F);
            label2.Location = new Point(45, 95);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 1;
            label2.Text = "Nhập a,b,c";
            label2.Click += label2_Click;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Tahoma", 13F);
            a.Location = new Point(172, 172);
            a.Name = "a";
            a.Size = new Size(25, 22);
            a.TabIndex = 2;
            a.Text = "a:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13F);
            label4.Location = new Point(172, 218);
            label4.Name = "label4";
            label4.Size = new Size(26, 22);
            label4.TabIndex = 2;
            label4.Text = "b:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13F);
            label5.Location = new Point(172, 261);
            label5.Name = "label5";
            label5.Size = new Size(24, 22);
            label5.TabIndex = 2;
            label5.Text = "c:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13F);
            label3.Location = new Point(323, 312);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 2;
            label3.Text = "Kết Quả";
            // 
            // txta
            // 
            txta.Font = new Font("Tahoma", 13F);
            txta.Location = new Point(211, 174);
            txta.Name = "txta";
            txta.Size = new Size(318, 28);
            txta.TabIndex = 3;
            // 
            // txtb
            // 
            txtb.Font = new Font("Tahoma", 13F);
            txtb.Location = new Point(211, 218);
            txtb.Name = "txtb";
            txtb.Size = new Size(318, 28);
            txtb.TabIndex = 3;
            // 
            // txtc
            // 
            txtc.Font = new Font("Tahoma", 13F);
            txtc.Location = new Point(211, 261);
            txtc.Name = "txtc";
            txtc.Size = new Size(318, 28);
            txtc.TabIndex = 3;
            // 
            // txtkq
            // 
            txtkq.Font = new Font("Tahoma", 13F);
            txtkq.Location = new Point(211, 337);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(318, 28);
            txtkq.TabIndex = 3;
            txtkq.TextChanged += txtkq_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13F);
            label6.Location = new Point(45, 409);
            label6.Name = "label6";
            label6.Size = new Size(121, 22);
            label6.TabIndex = 1;
            label6.Text = "Chọn thao tác";
            label6.Click += label2_Click;
            // 
            // btngiai
            // 
            btngiai.Font = new Font("Tahoma", 13F);
            btngiai.Location = new Point(172, 460);
            btngiai.Name = "btngiai";
            btngiai.Size = new Size(91, 33);
            btngiai.TabIndex = 4;
            btngiai.Text = "Giải";
            btngiai.UseVisualStyleBackColor = true;
            btngiai.Click += btngiai_Click;
            // 
            // btnxoa
            // 
            btnxoa.Font = new Font("Tahoma", 13F);
            btnxoa.Location = new Point(306, 460);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(101, 33);
            btnxoa.TabIndex = 4;
            btnxoa.Text = "Xóa trắng";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Tahoma", 13F);
            btnthoat.Location = new Point(438, 460);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(91, 33);
            btnthoat.TabIndex = 4;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 537);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btngiai);
            Controls.Add(txtkq);
            Controls.Add(txtc);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(a);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label label2;
        private Label a;
        private Label label4;
        private Label label5;
        private Label label3;
        private TextBox txta;
        private TextBox txtb;
        private TextBox txtc;
        private TextBox txtkq;
        public Label label6;
        private Button btngiai;
        private Button btnxoa;
        private Button btnthoat;
    }
}
