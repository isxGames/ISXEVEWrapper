namespace ISXEVEWrapperTest
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
            this.btn_AssetTest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MyOrderTest = new System.Windows.Forms.Button();
            this.btn_MarketOrderTest = new System.Windows.Forms.Button();
            this.btnMoveItemsTo = new System.Windows.Forms.Button();
            this.btnTargeting = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AssetTest
            // 
            this.btn_AssetTest.Location = new System.Drawing.Point(12, 42);
            this.btn_AssetTest.Name = "btn_AssetTest";
            this.btn_AssetTest.Size = new System.Drawing.Size(116, 23);
            this.btn_AssetTest.TabIndex = 0;
            this.btn_AssetTest.Text = "Asset Test";
            this.btn_AssetTest.UseVisualStyleBackColor = true;
            this.btn_AssetTest.Click += new System.EventHandler(this.btn_AssetTest_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 36);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add a button for the feature you wish to test!";
            // 
            // btn_MyOrderTest
            // 
            this.btn_MyOrderTest.Location = new System.Drawing.Point(12, 71);
            this.btn_MyOrderTest.Name = "btn_MyOrderTest";
            this.btn_MyOrderTest.Size = new System.Drawing.Size(116, 23);
            this.btn_MyOrderTest.TabIndex = 3;
            this.btn_MyOrderTest.Text = "MyOrder Test";
            this.btn_MyOrderTest.UseVisualStyleBackColor = true;
            this.btn_MyOrderTest.Click += new System.EventHandler(this.btn_MyOrderTest_Click);
            // 
            // btn_MarketOrderTest
            // 
            this.btn_MarketOrderTest.Location = new System.Drawing.Point(12, 100);
            this.btn_MarketOrderTest.Name = "btn_MarketOrderTest";
            this.btn_MarketOrderTest.Size = new System.Drawing.Size(116, 23);
            this.btn_MarketOrderTest.TabIndex = 4;
            this.btn_MarketOrderTest.Text = "MarketOrder Test";
            this.btn_MarketOrderTest.UseVisualStyleBackColor = true;
            this.btn_MarketOrderTest.Click += new System.EventHandler(this.btn_MarketOrderTest_Click);
            // 
            // btnMoveItemsTo
            // 
            this.btnMoveItemsTo.Location = new System.Drawing.Point(12, 129);
            this.btnMoveItemsTo.Name = "btnMoveItemsTo";
            this.btnMoveItemsTo.Size = new System.Drawing.Size(116, 23);
            this.btnMoveItemsTo.TabIndex = 5;
            this.btnMoveItemsTo.Text = "MoveItemsTo Test";
            this.btnMoveItemsTo.UseVisualStyleBackColor = true;
            this.btnMoveItemsTo.Click += new System.EventHandler(this.btnMoveItemsTo_Click);
            // 
            // btnTargeting
            // 
            this.btnTargeting.Location = new System.Drawing.Point(12, 158);
            this.btnTargeting.Name = "btnTargeting";
            this.btnTargeting.Size = new System.Drawing.Size(116, 23);
            this.btnTargeting.TabIndex = 6;
            this.btnTargeting.Text = "Targeting Test";
            this.btnTargeting.UseVisualStyleBackColor = true;
            this.btnTargeting.Click += new System.EventHandler(this.btnTargeting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 266);
            this.Controls.Add(this.btnTargeting);
            this.Controls.Add(this.btnMoveItemsTo);
            this.Controls.Add(this.btn_MarketOrderTest);
            this.Controls.Add(this.btn_MyOrderTest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_AssetTest);
            this.Name = "Form1";
            this.Text = "ISXEVE Wrapper Test Application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_AssetTest;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_MyOrderTest;
		private System.Windows.Forms.Button btn_MarketOrderTest;
		private System.Windows.Forms.Button btnMoveItemsTo;
        private System.Windows.Forms.Button btnTargeting;
	}
}