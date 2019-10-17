namespace JacobBabiksBrowser
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Imperial1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.TextBox();
            this.results1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.input2 = new System.Windows.Forms.TextBox();
            this.imperialSelection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metricSelection = new System.Windows.Forms.ComboBox();
            this.results2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Meters",
            "Kilometers",
            "Millimeters",
            "Centimeters"});
            this.comboBox1.Location = new System.Drawing.Point(92, 40);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Tag = "";
            this.comboBox1.Text = "Metric";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Imperial1
            // 
            this.Imperial1.FormattingEnabled = true;
            this.Imperial1.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards",
            "Miles"});
            this.Imperial1.Location = new System.Drawing.Point(195, 40);
            this.Imperial1.Margin = new System.Windows.Forms.Padding(1);
            this.Imperial1.Name = "Imperial1";
            this.Imperial1.Size = new System.Drawing.Size(85, 21);
            this.Imperial1.TabIndex = 2;
            this.Imperial1.Text = "Imperial";
            this.Imperial1.SelectedIndexChanged += new System.EventHandler(this.Imperial1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "to";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // result1
            // 
            this.result1.Location = new System.Drawing.Point(402, 41);
            this.result1.Margin = new System.Windows.Forms.Padding(1);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(86, 20);
            this.result1.TabIndex = 4;
            // 
            // results1
            // 
            this.results1.Location = new System.Drawing.Point(324, 39);
            this.results1.Margin = new System.Windows.Forms.Padding(1);
            this.results1.Name = "results1";
            this.results1.Size = new System.Drawing.Size(76, 22);
            this.results1.TabIndex = 5;
            this.results1.Text = "Get Results:";
            this.results1.UseVisualStyleBackColor = true;
            this.results1.Click += new System.EventHandler(this.results1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Metric length to Imperial length";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(22, 135);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(60, 20);
            this.input2.TabIndex = 7;
            // 
            // imperialSelection
            // 
            this.imperialSelection.FormattingEnabled = true;
            this.imperialSelection.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards",
            "Miles"});
            this.imperialSelection.Location = new System.Drawing.Point(92, 134);
            this.imperialSelection.Name = "imperialSelection";
            this.imperialSelection.Size = new System.Drawing.Size(85, 21);
            this.imperialSelection.TabIndex = 8;
            this.imperialSelection.Text = "Imperial";
            this.imperialSelection.SelectedIndexChanged += new System.EventHandler(this.imperialSelection_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "to";
            // 
            // metricSelection
            // 
            this.metricSelection.FormattingEnabled = true;
            this.metricSelection.Items.AddRange(new object[] {
            "Meters",
            "Kilometers",
            "Millimeters",
            "Centimeters"});
            this.metricSelection.Location = new System.Drawing.Point(195, 134);
            this.metricSelection.Name = "metricSelection";
            this.metricSelection.Size = new System.Drawing.Size(85, 21);
            this.metricSelection.TabIndex = 10;
            this.metricSelection.Text = "Metric";
            this.metricSelection.SelectedIndexChanged += new System.EventHandler(this.metricSelection_SelectedIndexChanged);
            // 
            // results2
            // 
            this.results2.Location = new System.Drawing.Point(324, 135);
            this.results2.Name = "results2";
            this.results2.Size = new System.Drawing.Size(76, 22);
            this.results2.TabIndex = 11;
            this.results2.Text = "Get Results:";
            this.results2.UseVisualStyleBackColor = true;
            this.results2.Click += new System.EventHandler(this.results2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(402, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Imperial length to Metric length";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 178);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.results2);
            this.Controls.Add(this.metricSelection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imperialSelection);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.results1);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Imperial1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form3";
            this.Text = "Unit Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Imperial1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result1;
        private System.Windows.Forms.Button results1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.ComboBox imperialSelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox metricSelection;
        private System.Windows.Forms.Button results2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}