namespace view
{
    partial class Form2
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnBack = new Button();
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            txtNationalId = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            dgvFirstName = new DataGridViewTextBoxColumn();
            dgvLastName = new DataGridViewTextBoxColumn();
            dgvNationalId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(87, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 37);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(222, 19);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 37);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(372, 19);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 37);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(520, 19);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 37);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(677, 19);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 37);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 126);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 5;
            label1.Text = "First Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(176, 123);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(255, 23);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(176, 180);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(255, 23);
            txtLastName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 183);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 7;
            label2.Text = "Last Name :";
            // 
            // txtNationalId
            // 
            txtNationalId.Location = new Point(176, 238);
            txtNationalId.Name = "txtNationalId";
            txtNationalId.Size = new Size(255, 23);
            txtNationalId.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 241);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 9;
            label3.Text = "National Id :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvFirstName, dgvLastName, dgvNationalId });
            dataGridView1.Location = new Point(492, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 138);
            dataGridView1.TabIndex = 11;
            // 
            // dgvFirstName
            // 
            dgvFirstName.HeaderText = "First Name";
            dgvFirstName.Name = "dgvFirstName";
            // 
            // dgvLastName
            // 
            dgvLastName.HeaderText = "Last Name";
            dgvLastName.Name = "dgvLastName";
            // 
            // dgvNationalId
            // 
            dgvNationalId.HeaderText = "National Id";
            dgvNationalId.Name = "dgvNationalId";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtNationalId);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnBack;
        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtNationalId;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dgvFirstName;
        private DataGridViewTextBoxColumn dgvLastName;
        private DataGridViewTextBoxColumn dgvNationalId;
    }
}