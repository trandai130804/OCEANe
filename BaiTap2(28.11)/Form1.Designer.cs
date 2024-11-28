namespace BaiTap2_28._11_
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
            this.lv1 = new System.Windows.Forms.ListView();
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtSlot1 = new System.Windows.Forms.TextBox();
            this.txtSlot2 = new System.Windows.Forms.TextBox();
            this.txtSlot3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LastName,
            this.FirstName,
            this.Phone});
            this.lv1.FullRowSelect = true;
            this.lv1.GridLines = true;
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(63, 62);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(469, 299);
            this.lv1.TabIndex = 0;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            this.lv1.Click += new System.EventHandler(this.lv1_Click);
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(178, 393);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 26);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(341, 392);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 24);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(488, 393);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtSlot1
            // 
            this.txtSlot1.Location = new System.Drawing.Point(609, 117);
            this.txtSlot1.Name = "txtSlot1";
            this.txtSlot1.Size = new System.Drawing.Size(160, 22);
            this.txtSlot1.TabIndex = 4;
            // 
            // txtSlot2
            // 
            this.txtSlot2.Location = new System.Drawing.Point(609, 193);
            this.txtSlot2.Name = "txtSlot2";
            this.txtSlot2.Size = new System.Drawing.Size(160, 22);
            this.txtSlot2.TabIndex = 5;
            // 
            // txtSlot3
            // 
            this.txtSlot3.Location = new System.Drawing.Point(609, 265);
            this.txtSlot3.Name = "txtSlot3";
            this.txtSlot3.Size = new System.Drawing.Size(160, 22);
            this.txtSlot3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSlot3);
            this.Controls.Add(this.txtSlot2);
            this.Controls.Add(this.txtSlot1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtSlot1;
        private System.Windows.Forms.TextBox txtSlot2;
        private System.Windows.Forms.TextBox txtSlot3;
    }
}

