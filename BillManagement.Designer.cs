
namespace Project
{
    partial class BillManagement
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
            this.diskIdField = new System.Windows.Forms.TextBox();
            this.idField = new System.Windows.Forms.TextBox();
            this.priceField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rentalDateField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.memberIdField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Button();
            this.searchByMember = new System.Windows.Forms.Button();
            this.createBill = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.toHome = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.amountField = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // diskIdField
            // 
            this.diskIdField.Location = new System.Drawing.Point(522, 8);
            this.diskIdField.Name = "diskIdField";
            this.diskIdField.Size = new System.Drawing.Size(250, 22);
            this.diskIdField.TabIndex = 33;
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(102, 8);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(250, 22);
            this.idField.TabIndex = 32;
            // 
            // priceField
            // 
            this.priceField.Location = new System.Drawing.Point(522, 97);
            this.priceField.Multiline = true;
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(250, 22);
            this.priceField.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "disk id";
            // 
            // rentalDateField
            // 
            this.rentalDateField.Location = new System.Drawing.Point(522, 50);
            this.rentalDateField.Name = "rentalDateField";
            this.rentalDateField.Size = new System.Drawing.Size(250, 22);
            this.rentalDateField.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "rental date";
            // 
            // memberIdField
            // 
            this.memberIdField.Location = new System.Drawing.Point(102, 97);
            this.memberIdField.Name = "memberIdField";
            this.memberIdField.Size = new System.Drawing.Size(250, 22);
            this.memberIdField.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "member id";
            // 
            // dateField
            // 
            this.dateField.Location = new System.Drawing.Point(102, 50);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(250, 22);
            this.dateField.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id";
            // 
            // payment
            // 
            this.payment.Location = new System.Drawing.Point(619, 197);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(125, 30);
            this.payment.TabIndex = 21;
            this.payment.Text = "Thanh toán";
            this.payment.UseVisualStyleBackColor = true;
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // searchByMember
            // 
            this.searchByMember.Location = new System.Drawing.Point(329, 197);
            this.searchByMember.Name = "searchByMember";
            this.searchByMember.Size = new System.Drawing.Size(125, 30);
            this.searchByMember.TabIndex = 20;
            this.searchByMember.Text = "Tìm kiếm";
            this.searchByMember.UseVisualStyleBackColor = true;
            this.searchByMember.Click += new System.EventHandler(this.searchByMember_Click);
            // 
            // createBill
            // 
            this.createBill.Location = new System.Drawing.Point(42, 197);
            this.createBill.Name = "createBill";
            this.createBill.Size = new System.Drawing.Size(125, 30);
            this.createBill.TabIndex = 19;
            this.createBill.Text = "Lập phiếu thuê";
            this.createBill.UseVisualStyleBackColor = true;
            this.createBill.Click += new System.EventHandler(this.createBill_Click);
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table.ColumnHeadersHeight = 29;
            this.table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Location = new System.Drawing.Point(0, 240);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(800, 206);
            this.table.TabIndex = 18;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            // 
            // toHome
            // 
            this.toHome.Location = new System.Drawing.Point(42, 147);
            this.toHome.Name = "toHome";
            this.toHome.Size = new System.Drawing.Size(125, 30);
            this.toHome.TabIndex = 34;
            this.toHome.Text = "Quay lại";
            this.toHome.UseVisualStyleBackColor = true;
            this.toHome.Click += new System.EventHandler(this.toHome_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "amout";
            // 
            // amountField
            // 
            this.amountField.Location = new System.Drawing.Point(522, 144);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(250, 22);
            this.amountField.TabIndex = 36;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(208, 147);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(125, 30);
            this.refresh.TabIndex = 37;
            this.refresh.Text = "Làm mới";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // BillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toHome);
            this.Controls.Add(this.diskIdField);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rentalDateField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.memberIdField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.searchByMember);
            this.Controls.Add(this.createBill);
            this.Controls.Add(this.table);
            this.Name = "BillManagement";
            this.Text = "BillManagement";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diskIdField;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rentalDateField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox memberIdField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button payment;
        private System.Windows.Forms.Button searchByMember;
        private System.Windows.Forms.Button createBill;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button toHome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox amountField;
        private System.Windows.Forms.Button refresh;
    }
}