namespace Baithicau1_NguyenMinhKhang_02PM16B1D1
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_hangxe = new TextBox();
            txt_bienso = new TextBox();
            txt_namsanxuat = new TextBox();
            txt_BTC = new TextBox();
            dt1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            txt_giaban = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dt1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 64);
            label1.Name = "label1";
            label1.Size = new Size(92, 27);
            label1.TabIndex = 0;
            label1.Text = "Hãng xe";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(237, 9);
            label2.Name = "label2";
            label2.Size = new Size(216, 42);
            label2.TabIndex = 0;
            label2.Text = "Quảng lý ô tô";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 104);
            label3.Name = "label3";
            label3.Size = new Size(84, 27);
            label3.TabIndex = 0;
            label3.Text = "Biển số";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 144);
            label4.Name = "label4";
            label4.Size = new Size(144, 27);
            label4.TabIndex = 0;
            label4.Text = "Năm sản xuất";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 234);
            label5.Name = "label5";
            label5.Size = new Size(170, 27);
            label5.TabIndex = 0;
            label5.Text = "BatteryCapacity";
            label5.Click += label1_Click;
            // 
            // txt_hangxe
            // 
            txt_hangxe.Location = new Point(215, 59);
            txt_hangxe.Name = "txt_hangxe";
            txt_hangxe.Size = new Size(265, 35);
            txt_hangxe.TabIndex = 1;
            // 
            // txt_bienso
            // 
            txt_bienso.Location = new Point(215, 103);
            txt_bienso.Name = "txt_bienso";
            txt_bienso.Size = new Size(265, 35);
            txt_bienso.TabIndex = 1;
            // 
            // txt_namsanxuat
            // 
            txt_namsanxuat.Location = new Point(215, 143);
            txt_namsanxuat.Name = "txt_namsanxuat";
            txt_namsanxuat.Size = new Size(265, 35);
            txt_namsanxuat.TabIndex = 1;
            // 
            // txt_BTC
            // 
            txt_BTC.Location = new Point(215, 231);
            txt_BTC.Name = "txt_BTC";
            txt_BTC.Size = new Size(265, 35);
            txt_BTC.TabIndex = 1;
            // 
            // dt1
            // 
            dt1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt1.Location = new Point(21, 272);
            dt1.Name = "dt1";
            dt1.Size = new Size(736, 160);
            dt1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(570, 59);
            button1.Name = "button1";
            button1.Size = new Size(111, 51);
            button1.TabIndex = 3;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(570, 131);
            button2.Name = "button2";
            button2.Size = new Size(111, 56);
            button2.TabIndex = 4;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(570, 210);
            button3.Name = "button3";
            button3.Size = new Size(111, 51);
            button3.TabIndex = 5;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 193);
            label6.Name = "label6";
            label6.Size = new Size(91, 27);
            label6.TabIndex = 6;
            label6.Text = "Giá Bán";
            // 
            // txt_giaban
            // 
            txt_giaban.Location = new Point(215, 190);
            txt_giaban.Name = "txt_giaban";
            txt_giaban.Size = new Size(265, 35);
            txt_giaban.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 444);
            Controls.Add(txt_giaban);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dt1);
            Controls.Add(txt_BTC);
            Controls.Add(txt_namsanxuat);
            Controls.Add(txt_bienso);
            Controls.Add(txt_hangxe);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "BatteryCapacity";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dt1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_hangxe;
        private TextBox txt_bienso;
        private TextBox txt_namsanxuat;
        private TextBox txt_BTC;
        private DataGridView dt1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label6;
        private TextBox txt_giaban;
    }
}
