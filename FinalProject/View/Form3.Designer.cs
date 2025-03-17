namespace view
{
    partial class Form3
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
            txtFirstName = new TextBox();
            btnBack = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            dgvProductName = new DataGridViewTextBoxColumn();
            dgvProductId = new DataGridViewTextBoxColumn();
            dgvProductPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(138, 129);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(229, 23);
            txtFirstName.TabIndex = 12;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(638, 26);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 37);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(488, 26);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 37);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(337, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 37);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(189, 26);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 37);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(49, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 37);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 132);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 13;
            label1.Text = "Product Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 190);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 15;
            label2.Text = "Product Id :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 247);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 17;
            label3.Text = "Product Price :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 244);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 23);
            textBox2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvProductName, dgvProductId, dgvProductPrice });
            dataGridView1.Location = new Point(388, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(340, 138);
            dataGridView1.TabIndex = 18;
            // 
            // dgvProductName
            // 
            dgvProductName.HeaderText = "ProductName";
            dgvProductName.Name = "dgvProductName";
            // 
            // dgvProductId
            // 
            dgvProductId.HeaderText = "Product Id";
            dgvProductId.Name = "dgvProductId";
            // 
            // dgvProductPrice
            // 
            dgvProductPrice.HeaderText = "Price";
            dgvProductPrice.Name = "dgvProductPrice";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private Button btnBack;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dgvProductName;
        private DataGridViewTextBoxColumn dgvProductId;
        private DataGridViewTextBoxColumn dgvProductPrice;
    }
}