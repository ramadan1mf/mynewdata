namespace company
{
    partial class frmuser
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnldata = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.cbx_active = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employee_name = new System.Windows.Forms.RadioButton();
            this.employee_id = new System.Windows.Forms.RadioButton();
            this.address = new System.Windows.Forms.RadioButton();
            this.salary = new System.Windows.Forms.RadioButton();
            this.search = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgvemp = new System.Windows.Forms.DataGridView();
            this.pnlsearch = new System.Windows.Forms.Panel();
            this.pnldata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).BeginInit();
            this.pnlsearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "users";
            // 
            // pnldata
            // 
            this.pnldata.Controls.Add(this.btnexit);
            this.pnldata.Controls.Add(this.btndelete);
            this.pnldata.Controls.Add(this.btnupdate);
            this.pnldata.Controls.Add(this.btnadd);
            this.pnldata.Controls.Add(this.cbx_active);
            this.pnldata.Controls.Add(this.label5);
            this.pnldata.Controls.Add(this.txtsalary);
            this.pnldata.Controls.Add(this.txtaddress);
            this.pnldata.Controls.Add(this.txtname);
            this.pnldata.Controls.Add(this.txtid);
            this.pnldata.Controls.Add(this.label4);
            this.pnldata.Controls.Add(this.label3);
            this.pnldata.Controls.Add(this.label2);
            this.pnldata.Location = new System.Drawing.Point(12, 59);
            this.pnldata.Name = "pnldata";
            this.pnldata.Size = new System.Drawing.Size(259, 344);
            this.pnldata.TabIndex = 0;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnexit.Location = new System.Drawing.Point(90, 286);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(141, 27);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "خروج";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btndelete.Location = new System.Drawing.Point(90, 253);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(141, 27);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "حذف";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnupdate.Location = new System.Drawing.Point(90, 220);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(141, 27);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "تحديث";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnadd.Location = new System.Drawing.Point(90, 198);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(141, 27);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "اضافة";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbx_active
            // 
            this.cbx_active.AutoSize = true;
            this.cbx_active.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbx_active.Location = new System.Drawing.Point(90, 171);
            this.cbx_active.Name = "cbx_active";
            this.cbx_active.Size = new System.Drawing.Size(95, 23);
            this.cbx_active.TabIndex = 8;
            this.cbx_active.Text = "is.active";
            this.cbx_active.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(9, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "salary";
            // 
            // txtsalary
            // 
            this.txtsalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsalary.Location = new System.Drawing.Point(89, 143);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(165, 20);
            this.txtsalary.TabIndex = 6;
            // 
            // txtaddress
            // 
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddress.Location = new System.Drawing.Point(89, 108);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(165, 20);
            this.txtaddress.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(89, 71);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(165, 20);
            this.txtname.TabIndex = 4;
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Location = new System.Drawing.Point(90, 30);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(165, 20);
            this.txtid.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "id";
            // 
            // employee_name
            // 
            this.employee_name.AutoSize = true;
            this.employee_name.Checked = true;
            this.employee_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.employee_name.Location = new System.Drawing.Point(213, 21);
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(72, 23);
            this.employee_name.TabIndex = 11;
            this.employee_name.TabStop = true;
            this.employee_name.Text = "name";
            this.employee_name.UseVisualStyleBackColor = true;
            // 
            // employee_id
            // 
            this.employee_id.AutoSize = true;
            this.employee_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.employee_id.Location = new System.Drawing.Point(165, 21);
            this.employee_id.Name = "employee_id";
            this.employee_id.Size = new System.Drawing.Size(42, 23);
            this.employee_id.TabIndex = 10;
            this.employee_id.TabStop = true;
            this.employee_id.Text = "id";
            this.employee_id.UseVisualStyleBackColor = true;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.address.Location = new System.Drawing.Point(307, 21);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(90, 23);
            this.address.TabIndex = 12;
            this.address.TabStop = true;
            this.address.Text = "address";
            this.address.UseVisualStyleBackColor = true;
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.salary.Location = new System.Drawing.Point(403, 23);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(76, 23);
            this.salary.TabIndex = 13;
            this.salary.TabStop = true;
            this.salary.Text = "salary";
            this.salary.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.search.Location = new System.Drawing.Point(56, 21);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(62, 19);
            this.search.TabIndex = 14;
            this.search.Text = "search";
            // 
            // txtsearch
            // 
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Location = new System.Drawing.Point(43, 59);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(436, 20);
            this.txtsearch.TabIndex = 15;
            // 
            // dgvemp
            // 
            this.dgvemp.AllowUserToAddRows = false;
            this.dgvemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemp.Location = new System.Drawing.Point(12, 92);
            this.dgvemp.Name = "dgvemp";
            this.dgvemp.ReadOnly = true;
            this.dgvemp.Size = new System.Drawing.Size(496, 249);
            this.dgvemp.TabIndex = 16;
            // 
            // pnlsearch
            // 
            this.pnlsearch.Controls.Add(this.dgvemp);
            this.pnlsearch.Controls.Add(this.txtsearch);
            this.pnlsearch.Controls.Add(this.search);
            this.pnlsearch.Controls.Add(this.salary);
            this.pnlsearch.Controls.Add(this.address);
            this.pnlsearch.Controls.Add(this.employee_id);
            this.pnlsearch.Controls.Add(this.employee_name);
            this.pnlsearch.Location = new System.Drawing.Point(277, 59);
            this.pnlsearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlsearch.Name = "pnlsearch";
            this.pnlsearch.Size = new System.Drawing.Size(511, 344);
            this.pnlsearch.TabIndex = 1;
            this.pnlsearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlsearch_Paint);
            // 
            // frmuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlsearch);
            this.Controls.Add(this.pnldata);
            this.Controls.Add(this.label1);
            this.Name = "frmuser";
            this.Text = "users";
            this.Load += new System.EventHandler(this.user_Load);
            this.pnldata.ResumeLayout(false);
            this.pnldata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).EndInit();
            this.pnlsearch.ResumeLayout(false);
            this.pnlsearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnldata;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.CheckBox cbx_active;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton employee_name;
        private System.Windows.Forms.RadioButton employee_id;
        private System.Windows.Forms.RadioButton address;
        private System.Windows.Forms.RadioButton salary;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgvemp;
        private System.Windows.Forms.Panel pnlsearch;
        private System.Windows.Forms.Button btnexit;
    }
}

