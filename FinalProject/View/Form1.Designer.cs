namespace view
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
            btnPerson = new Button();
            btnProduct = new Button();
            SuspendLayout();
            // 
            // btnPerson
            // 
            btnPerson.Location = new Point(362, 153);
            btnPerson.Name = "btnPerson";
            btnPerson.Size = new Size(182, 86);
            btnPerson.TabIndex = 0;
            btnPerson.Text = "Person";
            btnPerson.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(705, 153);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(182, 86);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 450);
            Controls.Add(btnProduct);
            Controls.Add(btnPerson);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPerson;
        private Button btnProduct;
    }
}
