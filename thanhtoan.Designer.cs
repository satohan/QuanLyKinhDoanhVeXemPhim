
namespace phanmemquanlibanve
{
    partial class thanhtoan
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnCustomer = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.chkCustomer = new System.Windows.Forms.CheckBox();
            this.grpLoaiVe = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.rdoAdult = new System.Windows.Forms.RadioButton();
            this.rdoChild = new System.Windows.Forms.RadioButton();
            this.lblPlusPoint = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnquaylai2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnCustomer.SuspendLayout();
            this.grpLoaiVe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnCancel);
            this.panel6.Controls.Add(this.lblTotal);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.btnPayment);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.lblPayment);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.lblDiscount);
            this.panel6.Location = new System.Drawing.Point(836, 402);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(461, 204);
            this.panel6.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(340, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(195, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(254, 29);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "In hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(190, 149);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(134, 35);
            this.btnPayment.TabIndex = 11;
            this.btnPayment.Text = "Thanh Toán";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số tiền giảm:";
            // 
            // lblPayment
            // 
            this.lblPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayment.BackColor = System.Drawing.Color.White;
            this.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.Red;
            this.lblPayment.Location = new System.Drawing.Point(195, 95);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(254, 29);
            this.lblPayment.TabIndex = 10;
            this.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tổng Tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-2, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số tiền cần trả:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.BackColor = System.Drawing.Color.White;
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Red;
            this.lblDiscount.Location = new System.Drawing.Point(195, 54);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(254, 29);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(830, 705);
            this.dataGridView1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnCustomer);
            this.groupBox1.Controls.Add(this.chkCustomer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(830, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 198);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thành Viên:";
            // 
            // pnCustomer
            // 
            this.pnCustomer.Controls.Add(this.label7);
            this.pnCustomer.Controls.Add(this.lblPlusPoint);
            this.pnCustomer.Controls.Add(this.label4);
            this.pnCustomer.Controls.Add(this.lblCustomerName);
            this.pnCustomer.Controls.Add(this.lblPoint);
            this.pnCustomer.Location = new System.Drawing.Point(6, 54);
            this.pnCustomer.Name = "pnCustomer";
            this.pnCustomer.Size = new System.Drawing.Size(446, 141);
            this.pnCustomer.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tên Khách Hàng:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(172, 2);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(193, 25);
            this.lblCustomerName.TabIndex = 19;
            // 
            // lblPoint
            // 
            this.lblPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPoint.BackColor = System.Drawing.Color.White;
            this.lblPoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.Color.Red;
            this.lblPoint.Location = new System.Drawing.Point(192, 33);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(237, 30);
            this.lblPoint.TabIndex = 17;
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkCustomer
            // 
            this.chkCustomer.AutoSize = true;
            this.chkCustomer.Location = new System.Drawing.Point(6, 29);
            this.chkCustomer.Name = "chkCustomer";
            this.chkCustomer.Size = new System.Drawing.Size(208, 24);
            this.chkCustomer.TabIndex = 0;
            this.chkCustomer.Text = "Khách Hàng Thành Viên";
            this.chkCustomer.UseVisualStyleBackColor = true;
            // 
            // grpLoaiVe
            // 
            this.grpLoaiVe.Controls.Add(this.label12);
            this.grpLoaiVe.Controls.Add(this.rdoStudent);
            this.grpLoaiVe.Controls.Add(this.lblTicketPrice);
            this.grpLoaiVe.Controls.Add(this.rdoAdult);
            this.grpLoaiVe.Controls.Add(this.rdoChild);
            this.grpLoaiVe.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpLoaiVe.Location = new System.Drawing.Point(830, 198);
            this.grpLoaiVe.Name = "grpLoaiVe";
            this.grpLoaiVe.Size = new System.Drawing.Size(480, 198);
            this.grpLoaiVe.TabIndex = 25;
            this.grpLoaiVe.TabStop = false;
            this.grpLoaiVe.Text = "Loại Vé:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(86, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 29);
            this.label12.TabIndex = 10;
            this.label12.Text = "Giá Vé:";
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStudent.Location = new System.Drawing.Point(198, 25);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(140, 33);
            this.rdoStudent.TabIndex = 5;
            this.rdoStudent.TabStop = true;
            this.rdoStudent.Text = "Sinh Viên";
            this.rdoStudent.UseVisualStyleBackColor = true;
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTicketPrice.BackColor = System.Drawing.Color.White;
            this.lblTicketPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTicketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTicketPrice.Location = new System.Drawing.Point(212, 126);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(235, 30);
            this.lblTicketPrice.TabIndex = 9;
            this.lblTicketPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdoAdult
            // 
            this.rdoAdult.AutoSize = true;
            this.rdoAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdult.Location = new System.Drawing.Point(28, 25);
            this.rdoAdult.Name = "rdoAdult";
            this.rdoAdult.Size = new System.Drawing.Size(149, 33);
            this.rdoAdult.TabIndex = 4;
            this.rdoAdult.TabStop = true;
            this.rdoAdult.Text = "Người Lớn";
            this.rdoAdult.UseVisualStyleBackColor = true;
            // 
            // rdoChild
            // 
            this.rdoChild.AutoSize = true;
            this.rdoChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChild.Location = new System.Drawing.Point(198, 73);
            this.rdoChild.Name = "rdoChild";
            this.rdoChild.Size = new System.Drawing.Size(267, 33);
            this.rdoChild.TabIndex = 3;
            this.rdoChild.TabStop = true;
            this.rdoChild.Text = "Trẻ Em (Dưới 12 tuổi)";
            this.rdoChild.UseVisualStyleBackColor = true;
            // 
            // lblPlusPoint
            // 
            this.lblPlusPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlusPoint.BackColor = System.Drawing.Color.White;
            this.lblPlusPoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlusPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusPoint.ForeColor = System.Drawing.Color.Red;
            this.lblPlusPoint.Location = new System.Drawing.Point(192, 86);
            this.lblPlusPoint.Name = "lblPlusPoint";
            this.lblPlusPoint.Size = new System.Drawing.Size(237, 30);
            this.lblPlusPoint.TabIndex = 21;
            this.lblPlusPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // btnquaylai2
            // 
            this.btnquaylai2.Location = new System.Drawing.Point(1032, 622);
            this.btnquaylai2.Name = "btnquaylai2";
            this.btnquaylai2.Size = new System.Drawing.Size(136, 42);
            this.btnquaylai2.TabIndex = 26;
            this.btnquaylai2.Text = "Quay lại";
            this.btnquaylai2.UseVisualStyleBackColor = true;
            this.btnquaylai2.Click += new System.EventHandler(this.btnquaylai2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1189, 622);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 42);
            this.button2.TabIndex = 26;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 705);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnquaylai2);
            this.Controls.Add(this.grpLoaiVe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel6);
            this.Name = "thanhtoan";
            this.Text = "thanhtoan";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnCustomer.ResumeLayout(false);
            this.pnCustomer.PerformLayout();
            this.grpLoaiVe.ResumeLayout(false);
            this.grpLoaiVe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.CheckBox chkCustomer;
        private System.Windows.Forms.Label lblPlusPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpLoaiVe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.Label lblTicketPrice;
        private System.Windows.Forms.RadioButton rdoAdult;
        private System.Windows.Forms.RadioButton rdoChild;
        private System.Windows.Forms.Button btnquaylai2;
        private System.Windows.Forms.Button button2;
    }
}