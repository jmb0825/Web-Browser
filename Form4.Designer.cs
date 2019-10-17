namespace JacobBabiksBrowser
{
    partial class Form4
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
            this.input = new System.Windows.Forms.TextBox();
            this.fromBox = new System.Windows.Forms.ComboBox();
            this.toBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.getResults = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(10, 44);
            this.input.Margin = new System.Windows.Forms.Padding(1);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(82, 20);
            this.input.TabIndex = 0;
            this.input.Text = "Enter value";
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // fromBox
            // 
            this.fromBox.FormattingEnabled = true;
            this.fromBox.Items.AddRange(new object[] {
            "U.S. Dollars",
            "Mexican Pesos",
            "Euros",
            "Canadian Dollars",
            "Chinese Yuan",
            "Japanese Yen"});
            this.fromBox.Location = new System.Drawing.Point(94, 44);
            this.fromBox.Margin = new System.Windows.Forms.Padding(1);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(100, 21);
            this.fromBox.TabIndex = 1;
            this.fromBox.Text = "Make selection";
            this.fromBox.SelectedIndexChanged += new System.EventHandler(this.fromBox_SelectedIndexChanged);
            // 
            // toBox
            // 
            this.toBox.FormattingEnabled = true;
            this.toBox.Items.AddRange(new object[] {
            "U.S. Dollars",
            "Mexican Pesos",
            "Euros",
            "Canadian Dollars",
            "Chinese Yuan",
            "Japanese Yen"});
            this.toBox.Location = new System.Drawing.Point(218, 44);
            this.toBox.Margin = new System.Windows.Forms.Padding(1);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(100, 21);
            this.toBox.TabIndex = 2;
            this.toBox.Text = "Make selection";
            this.toBox.SelectedIndexChanged += new System.EventHandler(this.toBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // getResults
            // 
            this.getResults.Location = new System.Drawing.Point(342, 66);
            this.getResults.Margin = new System.Windows.Forms.Padding(1);
            this.getResults.Name = "getResults";
            this.getResults.Size = new System.Drawing.Size(74, 25);
            this.getResults.TabIndex = 4;
            this.getResults.Text = "Calculate";
            this.getResults.UseVisualStyleBackColor = true;
            this.getResults.Click += new System.EventHandler(this.getResults_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "in";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Currency Conversion";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 98);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getResults);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.input);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form4";
            this.Text = "Currency Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.ComboBox fromBox;
        private System.Windows.Forms.ComboBox toBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button getResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}