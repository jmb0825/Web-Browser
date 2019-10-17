namespace JacobBabiksBrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.openCalc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openUC = new System.Windows.Forms.Button();
            this.currencybtn = new System.Windows.Forms.Button();
            this.gameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1, 40);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1157, 617);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 9);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(570, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "https://";
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Location = new System.Drawing.Point(588, 9);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.Location = new System.Drawing.Point(711, 9);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(36, 23);
            this.forwardBtn.TabIndex = 3;
            this.forwardBtn.Text = "->";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(669, 9);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(36, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "<-";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(753, 9);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(53, 23);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // openCalc
            // 
            this.openCalc.Location = new System.Drawing.Point(1093, 9);
            this.openCalc.Name = "openCalc";
            this.openCalc.Size = new System.Drawing.Size(65, 23);
            this.openCalc.TabIndex = 6;
            this.openCalc.Text = "Calculator";
            this.openCalc.UseVisualStyleBackColor = true;
            this.openCalc.Click += new System.EventHandler(this.openCalc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 10);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openUC
            // 
            this.openUC.Location = new System.Drawing.Point(999, 9);
            this.openUC.Margin = new System.Windows.Forms.Padding(1);
            this.openUC.Name = "openUC";
            this.openUC.Size = new System.Drawing.Size(90, 23);
            this.openUC.TabIndex = 8;
            this.openUC.Text = "Unit Conversion";
            this.openUC.UseVisualStyleBackColor = true;
            this.openUC.Click += new System.EventHandler(this.openUC_Click);
            // 
            // currencybtn
            // 
            this.currencybtn.Location = new System.Drawing.Point(879, 9);
            this.currencybtn.Name = "currencybtn";
            this.currencybtn.Size = new System.Drawing.Size(116, 23);
            this.currencybtn.TabIndex = 9;
            this.currencybtn.Text = "Currency Conversion";
            this.currencybtn.UseVisualStyleBackColor = true;
            this.currencybtn.Click += new System.EventHandler(this.currencybtn_Click);
            // 
            // gameBtn
            // 
            this.gameBtn.Location = new System.Drawing.Point(827, 9);
            this.gameBtn.Name = "gameBtn";
            this.gameBtn.Size = new System.Drawing.Size(46, 23);
            this.gameBtn.TabIndex = 10;
            this.gameBtn.Text = "Game";
            this.gameBtn.UseVisualStyleBackColor = true;
            this.gameBtn.Click += new System.EventHandler(this.gameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1158, 654);
            this.Controls.Add(this.gameBtn);
            this.Controls.Add(this.currencybtn);
            this.Controls.Add(this.openUC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openCalc);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.forwardBtn);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Jacob Babik\'s Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button openCalc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button openUC;
        private System.Windows.Forms.Button currencybtn;
        private System.Windows.Forms.Button gameBtn;
    }
}

