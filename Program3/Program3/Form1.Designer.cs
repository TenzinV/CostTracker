
namespace Program3
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
            this.farmCombo = new System.Windows.Forms.ComboBox();
            this.farmLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.initialLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.shipmentLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.initialOutput = new System.Windows.Forms.Label();
            this.itemInput = new System.Windows.Forms.TextBox();
            this.quantInput = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.discountOutput = new System.Windows.Forms.Label();
            this.shipmentOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // farmCombo
            // 
            this.farmCombo.FormattingEnabled = true;
            this.farmCombo.Items.AddRange(new object[] {
            "NE",
            "NW",
            "SE",
            "SW"});
            this.farmCombo.Location = new System.Drawing.Point(365, 56);
            this.farmCombo.Name = "farmCombo";
            this.farmCombo.Size = new System.Drawing.Size(121, 28);
            this.farmCombo.TabIndex = 0;
            // 
            // farmLabel
            // 
            this.farmLabel.AutoSize = true;
            this.farmLabel.Location = new System.Drawing.Point(276, 56);
            this.farmLabel.Name = "farmLabel";
            this.farmLabel.Size = new System.Drawing.Size(50, 20);
            this.farmLabel.TabIndex = 1;
            this.farmLabel.Text = "Farm:";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(276, 88);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(45, 20);
            this.itemLabel.TabIndex = 2;
            this.itemLabel.Text = "Item:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(242, 128);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(106, 20);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantity (lbs):";
            // 
            // initialLabel
            // 
            this.initialLabel.AutoSize = true;
            this.initialLabel.Location = new System.Drawing.Point(276, 191);
            this.initialLabel.Name = "initialLabel";
            this.initialLabel.Size = new System.Drawing.Size(87, 20);
            this.initialLabel.TabIndex = 4;
            this.initialLabel.Text = "Initial Cost:";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(232, 221);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(131, 20);
            this.discountLabel.TabIndex = 5;
            this.discountLabel.Text = "Discounted Cost:";
            // 
            // shipmentLabel
            // 
            this.shipmentLabel.AutoSize = true;
            this.shipmentLabel.Location = new System.Drawing.Point(245, 252);
            this.shipmentLabel.Name = "shipmentLabel";
            this.shipmentLabel.Size = new System.Drawing.Size(118, 20);
            this.shipmentLabel.TabIndex = 6;
            this.shipmentLabel.Text = "Shipment Cost:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(276, 284);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(87, 20);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total Price:";
            // 
            // initialOutput
            // 
            this.initialOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialOutput.Location = new System.Drawing.Point(365, 190);
            this.initialOutput.Name = "initialOutput";
            this.initialOutput.Size = new System.Drawing.Size(84, 20);
            this.initialOutput.TabIndex = 9;
            // 
            // itemInput
            // 
            this.itemInput.Location = new System.Drawing.Point(365, 90);
            this.itemInput.Name = "itemInput";
            this.itemInput.Size = new System.Drawing.Size(100, 26);
            this.itemInput.TabIndex = 12;
            // 
            // quantInput
            // 
            this.quantInput.Location = new System.Drawing.Point(365, 122);
            this.quantInput.Name = "quantInput";
            this.quantInput.Size = new System.Drawing.Size(100, 26);
            this.quantInput.TabIndex = 13;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(365, 158);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(99, 29);
            this.calcButton.TabIndex = 14;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // discountOutput
            // 
            this.discountOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountOutput.Location = new System.Drawing.Point(365, 221);
            this.discountOutput.Name = "discountOutput";
            this.discountOutput.Size = new System.Drawing.Size(84, 20);
            this.discountOutput.TabIndex = 15;
            // 
            // shipmentOutput
            // 
            this.shipmentOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shipmentOutput.Location = new System.Drawing.Point(369, 251);
            this.shipmentOutput.Name = "shipmentOutput";
            this.shipmentOutput.Size = new System.Drawing.Size(84, 20);
            this.shipmentOutput.TabIndex = 16;
            // 
            // totalOutput
            // 
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutput.Location = new System.Drawing.Point(369, 283);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(84, 20);
            this.totalOutput.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.shipmentOutput);
            this.Controls.Add(this.discountOutput);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.quantInput);
            this.Controls.Add(this.itemInput);
            this.Controls.Add(this.initialOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.shipmentLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.initialLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.farmLabel);
            this.Controls.Add(this.farmCombo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox farmCombo;
        private System.Windows.Forms.Label farmLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label initialLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label shipmentLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label initialOutput;
        private System.Windows.Forms.TextBox itemInput;
        private System.Windows.Forms.TextBox quantInput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label discountOutput;
        private System.Windows.Forms.Label shipmentOutput;
        private System.Windows.Forms.Label totalOutput;
    }
}

