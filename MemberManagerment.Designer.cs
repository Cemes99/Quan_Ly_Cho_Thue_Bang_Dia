
namespace Project
{
    partial class MemberManagerment
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
            this.idField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneNumberField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.addMember = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.idCardField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(139, 9);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(150, 22);
            this.idField.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "id card";
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(487, 50);
            this.addressField.Multiline = true;
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(301, 22);
            this.addressField.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "address";
            // 
            // phoneNumberField
            // 
            this.phoneNumberField.Location = new System.Drawing.Point(139, 97);
            this.phoneNumberField.Name = "phoneNumberField";
            this.phoneNumberField.Size = new System.Drawing.Size(150, 22);
            this.phoneNumberField.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "phone number";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(139, 50);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(150, 22);
            this.nameField.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Id";
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(619, 197);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(125, 30);
            this.remove.TabIndex = 20;
            this.remove.Text = "Xóa";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(329, 197);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(125, 30);
            this.save.TabIndex = 19;
            this.save.Text = "Lưu";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // addMember
            // 
            this.addMember.Location = new System.Drawing.Point(42, 197);
            this.addMember.Name = "addMember";
            this.addMember.Size = new System.Drawing.Size(125, 30);
            this.addMember.TabIndex = 18;
            this.addMember.Text = "Thêm thành viên";
            this.addMember.UseVisualStyleBackColor = true;
            this.addMember.Click += new System.EventHandler(this.addMember_Click);
            // 
            // table
            // 
            this.table.ColumnHeadersHeight = 29;
            this.table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table.Location = new System.Drawing.Point(0, 240);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(800, 206);
            this.table.TabIndex = 17;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            // 
            // idCardField
            // 
            this.idCardField.Location = new System.Drawing.Point(487, 9);
            this.idCardField.Name = "idCardField";
            this.idCardField.Size = new System.Drawing.Size(200, 22);
            this.idCardField.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MemberManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idCardField);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNumberField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.save);
            this.Controls.Add(this.addMember);
            this.Controls.Add(this.table);
            this.Name = "MemberManagerment";
            this.Text = "MemberManagerment";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneNumberField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button addMember;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.TextBox idCardField;
        private System.Windows.Forms.Button button1;
    }
}