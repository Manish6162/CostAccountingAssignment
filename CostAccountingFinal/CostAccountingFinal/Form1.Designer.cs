
namespace CostAccountingFinal
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
            this.sharesTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.remainingSharesLabel = new System.Windows.Forms.Label();
            this.soldCostBasisLabel = new System.Windows.Forms.Label();
            this.remainingCostBasisLabel = new System.Windows.Forms.Label();
            this.profitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sharesTextBox
            // 
            this.sharesTextBox.Location = new System.Drawing.Point(239, 70);
            this.sharesTextBox.Name = "sharesTextBox";
            this.sharesTextBox.Size = new System.Drawing.Size(100, 23);
            this.sharesTextBox.TabIndex = 0;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(239, 116);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 23);
            this.priceTextBox.TabIndex = 1;
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(239, 164);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 23);
            this.sellButton.TabIndex = 2;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // remainingSharesLabel
            // 
            this.remainingSharesLabel.AutoSize = true;
            this.remainingSharesLabel.Location = new System.Drawing.Point(318, 246);
            this.remainingSharesLabel.Name = "remainingSharesLabel";
            this.remainingSharesLabel.Size = new System.Drawing.Size(123, 15);
            this.remainingSharesLabel.TabIndex = 3;
            this.remainingSharesLabel.Text = "remainingSharesLabel";
            // 
            // soldCostBasisLabel
            // 
            this.soldCostBasisLabel.AutoSize = true;
            this.soldCostBasisLabel.Location = new System.Drawing.Point(318, 278);
            this.soldCostBasisLabel.Name = "soldCostBasisLabel";
            this.soldCostBasisLabel.Size = new System.Drawing.Size(107, 15);
            this.soldCostBasisLabel.TabIndex = 4;
            this.soldCostBasisLabel.Text = "soldCostBasisLabel";
            // 
            // remainingCostBasisLabel
            // 
            this.remainingCostBasisLabel.AutoSize = true;
            this.remainingCostBasisLabel.Location = new System.Drawing.Point(318, 297);
            this.remainingCostBasisLabel.Name = "remainingCostBasisLabel";
            this.remainingCostBasisLabel.Size = new System.Drawing.Size(139, 15);
            this.remainingCostBasisLabel.TabIndex = 5;
            this.remainingCostBasisLabel.Text = "remainingCostBasisLabel";
            // 
            // profitLabel
            // 
            this.profitLabel.AutoSize = true;
            this.profitLabel.Location = new System.Drawing.Point(318, 316);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(64, 15);
            this.profitLabel.TabIndex = 6;
            this.profitLabel.Text = "profitLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Price Per Share";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of Shares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Remaining Shares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sold Cost Basis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Remaining Cost Basis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Profit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profitLabel);
            this.Controls.Add(this.remainingCostBasisLabel);
            this.Controls.Add(this.soldCostBasisLabel);
            this.Controls.Add(this.remainingSharesLabel);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.sharesTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sharesTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label remainingSharesLabel;
        private System.Windows.Forms.Label soldCostBasisLabel;
        private System.Windows.Forms.Label remainingCostBasisLabel;
        private System.Windows.Forms.Label profitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

