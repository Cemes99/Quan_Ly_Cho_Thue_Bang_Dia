
namespace Project
{
    partial class DiskManagement
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
            this.table = new System.Windows.Forms.DataGridView();
            this.addDisk = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.companyField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.noteField = new System.Windows.Forms.TextBox();
            this.idField = new System.Windows.Forms.TextBox();
            this.statusField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.table.ColumnHeadersHeight = 29;
            this.table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Location = new System.Drawing.Point(0, 244);
            this.table.MultiSelect = false;
            this.table.Name = "dataTable";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(800, 206);
            this.table.TabIndex = 0;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            // 
            // addDisk
            // 
            this.addDisk.Location = new System.Drawing.Point(42, 201);
            this.addDisk.Name = "addDisk";
            this.addDisk.Size = new System.Drawing.Size(125, 30);
            this.addDisk.TabIndex = 1;
            this.addDisk.Text = "Thêm băng đĩa";
            this.addDisk.UseVisualStyleBackColor = true;
            this.addDisk.Click += new System.EventHandler(this.addDisk_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(329, 201);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(125, 30);
            this.save.TabIndex = 2;
            this.save.Text = "Lưu";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(619, 201);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(125, 30);
            this.remove.TabIndex = 3;
            this.remove.Text = "Xóa";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "name";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(102, 54);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(150, 22);
            this.nameField.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "category";
            // 
            // categoryField
            // 
            this.categoryField.Location = new System.Drawing.Point(102, 101);
            this.categoryField.Name = "categoryField";
            this.categoryField.Size = new System.Drawing.Size(150, 22);
            this.categoryField.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "company";
            // 
            // companyField
            // 
            this.companyField.Location = new System.Drawing.Point(487, 54);
            this.companyField.Name = "companyField";
            this.companyField.Size = new System.Drawing.Size(150, 22);
            this.companyField.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "note";
            // 
            // noteField
            // 
            this.noteField.Location = new System.Drawing.Point(487, 101);
            this.noteField.Multiline = true;
            this.noteField.Name = "noteField";
            this.noteField.Size = new System.Drawing.Size(301, 80);
            this.noteField.TabIndex = 15;
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(102, 12);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(150, 22);
            this.idField.TabIndex = 16;
            // 
            // statusField
            // 
            this.statusField.Location = new System.Drawing.Point(487, 12);
            this.statusField.Name = "statusField";
            this.statusField.Size = new System.Drawing.Size(150, 22);
            this.statusField.TabIndex = 17;
            // 
            // DiskManagement
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
            this.Name = "DiskManagement";
            this.Text = "DiskManagement";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button addDisk;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox categoryField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox companyField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox noteField;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.TextBox statusField;
    }
}