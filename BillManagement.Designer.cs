
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
            this.statusField = new System.Windows.Forms.TextBox();
            this.idField = new System.Windows.Forms.TextBox();
            this.noteField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.companyField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.addDisk = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // statusField
            // 
            this.statusField.Location = new System.Drawing.Point(487, 8);
            this.statusField.Name = "statusField";
            this.statusField.Size = new System.Drawing.Size(150, 22);
            this.statusField.TabIndex = 33;
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(102, 8);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(150, 22);
            this.idField.TabIndex = 32;
            // 
            // noteField
            // 
            this.noteField.Location = new System.Drawing.Point(487, 97);
            this.noteField.Multiline = true;
            this.noteField.Name = "noteField";
            this.noteField.Size = new System.Drawing.Size(301, 80);
            this.noteField.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "note";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "status";
            // 
            // companyField
            // 
            this.companyField.Location = new System.Drawing.Point(487, 50);
            this.companyField.Name = "companyField";
            this.companyField.Size = new System.Drawing.Size(150, 22);
            this.companyField.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "company";
            // 
            // categoryField
            // 
            this.categoryField.Location = new System.Drawing.Point(102, 97);
            this.categoryField.Name = "categoryField";
            this.categoryField.Size = new System.Drawing.Size(150, 22);
            this.categoryField.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "category";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(102, 50);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(150, 22);
            this.nameField.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id";
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(619, 197);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(125, 30);
            this.remove.TabIndex = 21;
            this.remove.Text = "Xóa";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(329, 197);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(125, 30);
            this.save.TabIndex = 20;
            this.save.Text = "Lưu";
            this.save.UseVisualStyleBackColor = true;
            // 
            // addDisk
            // 
            this.addDisk.Location = new System.Drawing.Point(42, 197);
            this.addDisk.Name = "addDisk";
            this.addDisk.Size = new System.Drawing.Size(125, 30);
            this.addDisk.TabIndex = 19;
            this.addDisk.Text = "Thêm băng đĩa";
            this.addDisk.UseVisualStyleBackColor = true;
            // 
            // table
            // 
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
            // 
            // BillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusField);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.noteField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.companyField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.save);
            this.Controls.Add(this.addDisk);
            this.Controls.Add(this.table);
            this.Name = "BillManagement";
            this.Text = "BillManagement";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox statusField;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.TextBox noteField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox companyField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox categoryField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button addDisk;
        private System.Windows.Forms.DataGridView table;
    }
}