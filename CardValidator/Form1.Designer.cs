
namespace CardValidator
{
    partial class CardValidator
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
            this.CardNumberText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpiryDateText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CVVText = new System.Windows.Forms.TextBox();
            this.Validation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CardNumberText
            // 
            this.CardNumberText.Location = new System.Drawing.Point(128, 48);
            this.CardNumberText.Margin = new System.Windows.Forms.Padding(2);
            this.CardNumberText.Name = "CardNumberText";
            this.CardNumberText.Size = new System.Drawing.Size(241, 20);
            this.CardNumberText.TabIndex = 1;
            this.CardNumberText.TextChanged += new System.EventHandler(this.CardNumberText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expiry Date";
            // 
            // ExpiryDateText
            // 
            this.ExpiryDateText.Location = new System.Drawing.Point(128, 86);
            this.ExpiryDateText.Margin = new System.Windows.Forms.Padding(2);
            this.ExpiryDateText.Name = "ExpiryDateText";
            this.ExpiryDateText.Size = new System.Drawing.Size(76, 20);
            this.ExpiryDateText.TabIndex = 3;
            this.ExpiryDateText.TextChanged += new System.EventHandler(this.ExpiryDateText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CVV";
            // 
            // CVVText
            // 
            this.CVVText.Location = new System.Drawing.Point(305, 88);
            this.CVVText.Margin = new System.Windows.Forms.Padding(2);
            this.CVVText.Name = "CVVText";
            this.CVVText.Size = new System.Drawing.Size(63, 20);
            this.CVVText.TabIndex = 5;
            this.CVVText.TextChanged += new System.EventHandler(this.CVVText_TextChanged);
            // 
            // Validation
            // 
            this.Validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validation.Location = new System.Drawing.Point(467, 49);
            this.Validation.Margin = new System.Windows.Forms.Padding(2);
            this.Validation.Name = "Validation";
            this.Validation.Size = new System.Drawing.Size(80, 19);
            this.Validation.TabIndex = 6;
            this.Validation.Text = "Validate";
            this.Validation.UseVisualStyleBackColor = true;
            this.Validation.Click += new System.EventHandler(this.Validation_Click);
            // 
            // CardValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 131);
            this.Controls.Add(this.Validation);
            this.Controls.Add(this.CVVText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExpiryDateText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CardNumberText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CardValidator";
            this.Text = "Validate your card";
            this.Load += new System.EventHandler(this.CardValidator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CardNumberText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExpiryDateText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CVVText;
        private System.Windows.Forms.Button Validation;
    }
}

