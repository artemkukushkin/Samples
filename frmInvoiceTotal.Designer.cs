namespace InvoiceTotal
{
    partial class frmInvoiceTotal
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
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscPercent = new System.Windows.Forms.Label();
            this.lblDiscAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.tbDiscPercent = new System.Windows.Forms.TextBox();
            this.tbDiscAmount = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(37, 45);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "&Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscPercent
            // 
            this.lblDiscPercent.AutoSize = true;
            this.lblDiscPercent.Location = new System.Drawing.Point(37, 92);
            this.lblDiscPercent.Name = "lblDiscPercent";
            this.lblDiscPercent.Size = new System.Drawing.Size(92, 13);
            this.lblDiscPercent.TabIndex = 1;
            this.lblDiscPercent.Text = "Discount Percent:";
            this.lblDiscPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscAmount
            // 
            this.lblDiscAmount.AutoSize = true;
            this.lblDiscAmount.Location = new System.Drawing.Point(37, 143);
            this.lblDiscAmount.Name = "lblDiscAmount";
            this.lblDiscAmount.Size = new System.Drawing.Size(91, 13);
            this.lblDiscAmount.TabIndex = 2;
            this.lblDiscAmount.Text = "Discount Amount:";
            this.lblDiscAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(37, 189);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Location = new System.Drawing.Point(160, 42);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(100, 20);
            this.tbSubtotal.TabIndex = 1;
            // 
            // tbDiscPercent
            // 
            this.tbDiscPercent.Location = new System.Drawing.Point(160, 89);
            this.tbDiscPercent.Name = "tbDiscPercent";
            this.tbDiscPercent.ReadOnly = true;
            this.tbDiscPercent.Size = new System.Drawing.Size(100, 20);
            this.tbDiscPercent.TabIndex = 1;
            this.tbDiscPercent.TabStop = false;
            // 
            // tbDiscAmount
            // 
            this.tbDiscAmount.Location = new System.Drawing.Point(160, 140);
            this.tbDiscAmount.Name = "tbDiscAmount";
            this.tbDiscAmount.ReadOnly = true;
            this.tbDiscAmount.Size = new System.Drawing.Size(100, 20);
            this.tbDiscAmount.TabIndex = 6;
            this.tbDiscAmount.TabStop = false;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(160, 186);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 7;
            this.tbTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(40, 229);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(185, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(304, 290);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbDiscAmount);
            this.Controls.Add(this.tbDiscPercent);
            this.Controls.Add(this.tbSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscAmount);
            this.Controls.Add(this.lblDiscPercent);
            this.Controls.Add(this.lblSubtotal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscPercent;
        private System.Windows.Forms.Label lblDiscAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.TextBox tbDiscPercent;
        private System.Windows.Forms.TextBox tbDiscAmount;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

