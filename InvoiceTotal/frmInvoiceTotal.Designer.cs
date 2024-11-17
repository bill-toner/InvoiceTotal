namespace InvoiceTotal
{
    partial class frmInvoiceTotal
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSubtotal = new TextBox();
            txtDiscountPercent = new TextBox();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            txtDiscountAmount = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 32);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "&Subtotal: ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 88);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 1;
            label2.Text = "Discount percent: ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 137);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 2;
            label3.Text = "Discount amount:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 185);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 3;
            label4.Text = "Total: ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubtotal.Location = new Point(195, 32);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(150, 31);
            txtSubtotal.TabIndex = 1;
            // 
            // txtDiscountPercent
            // 
            txtDiscountPercent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiscountPercent.Location = new Point(195, 88);
            txtDiscountPercent.Name = "txtDiscountPercent";
            txtDiscountPercent.ReadOnly = true;
            txtDiscountPercent.Size = new Size(150, 31);
            txtDiscountPercent.TabIndex = 5;
            txtDiscountPercent.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(195, 185);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(150, 31);
            txtTotal.TabIndex = 7;
            txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(32, 259);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 8;
            btnCalculate.TabStop = false;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(233, 259);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiscountAmount.Location = new Point(195, 137);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new Size(150, 31);
            txtDiscountAmount.TabIndex = 9;
            txtDiscountAmount.TabStop = false;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            CancelButton = btnExit;
            ClientSize = new Size(414, 373);
            Controls.Add(txtDiscountAmount);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscountPercent);
            Controls.Add(txtSubtotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInvoiceTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSubtotal;
        private TextBox txtDiscountPercent;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnExit;
        private TextBox txtDiscountAmount;
    }
}
