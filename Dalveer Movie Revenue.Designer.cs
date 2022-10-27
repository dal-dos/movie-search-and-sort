namespace Assignment_4
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
            this.sortNameBtn = new System.Windows.Forms.Button();
            this.sortRevBtn = new System.Windows.Forms.Button();
            this.sortLstBx = new System.Windows.Forms.ListBox();
            this.searchGrpBx = new System.Windows.Forms.GroupBox();
            this.searchTxtBx = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.nameRdBtn = new System.Windows.Forms.RadioButton();
            this.revenueRdBtn = new System.Windows.Forms.RadioButton();
            this.searchGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortNameBtn
            // 
            this.sortNameBtn.Location = new System.Drawing.Point(12, 12);
            this.sortNameBtn.Name = "sortNameBtn";
            this.sortNameBtn.Size = new System.Drawing.Size(90, 65);
            this.sortNameBtn.TabIndex = 0;
            this.sortNameBtn.Text = "Sort By\r\nName";
            this.sortNameBtn.UseVisualStyleBackColor = true;
            this.sortNameBtn.Click += new System.EventHandler(this.sortNameBtn_Click);
            // 
            // sortRevBtn
            // 
            this.sortRevBtn.Location = new System.Drawing.Point(12, 83);
            this.sortRevBtn.Name = "sortRevBtn";
            this.sortRevBtn.Size = new System.Drawing.Size(90, 65);
            this.sortRevBtn.TabIndex = 1;
            this.sortRevBtn.Text = "Sort by Revenue";
            this.sortRevBtn.UseVisualStyleBackColor = true;
            this.sortRevBtn.Click += new System.EventHandler(this.sortRevBtn_Click);
            // 
            // sortLstBx
            // 
            this.sortLstBx.FormattingEnabled = true;
            this.sortLstBx.Location = new System.Drawing.Point(128, 12);
            this.sortLstBx.Name = "sortLstBx";
            this.sortLstBx.Size = new System.Drawing.Size(355, 134);
            this.sortLstBx.TabIndex = 2;
            // 
            // searchGrpBx
            // 
            this.searchGrpBx.Controls.Add(this.revenueRdBtn);
            this.searchGrpBx.Controls.Add(this.nameRdBtn);
            this.searchGrpBx.Controls.Add(this.searchBtn);
            this.searchGrpBx.Controls.Add(this.searchTxtBx);
            this.searchGrpBx.Location = new System.Drawing.Point(128, 164);
            this.searchGrpBx.Name = "searchGrpBx";
            this.searchGrpBx.Size = new System.Drawing.Size(355, 122);
            this.searchGrpBx.TabIndex = 3;
            this.searchGrpBx.TabStop = false;
            this.searchGrpBx.Text = "Search";
            // 
            // searchTxtBx
            // 
            this.searchTxtBx.Location = new System.Drawing.Point(19, 35);
            this.searchTxtBx.Name = "searchTxtBx";
            this.searchTxtBx.Size = new System.Drawing.Size(168, 20);
            this.searchTxtBx.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(228, 33);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // nameRdBtn
            // 
            this.nameRdBtn.AutoSize = true;
            this.nameRdBtn.Location = new System.Drawing.Point(19, 86);
            this.nameRdBtn.Name = "nameRdBtn";
            this.nameRdBtn.Size = new System.Drawing.Size(86, 17);
            this.nameRdBtn.TabIndex = 2;
            this.nameRdBtn.TabStop = true;
            this.nameRdBtn.Text = "Within Name";
            this.nameRdBtn.UseVisualStyleBackColor = true;
            // 
            // revenueRdBtn
            // 
            this.revenueRdBtn.AutoSize = true;
            this.revenueRdBtn.Location = new System.Drawing.Point(150, 86);
            this.revenueRdBtn.Name = "revenueRdBtn";
            this.revenueRdBtn.Size = new System.Drawing.Size(84, 17);
            this.revenueRdBtn.TabIndex = 3;
            this.revenueRdBtn.TabStop = true;
            this.revenueRdBtn.Text = "By Revenue";
            this.revenueRdBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 320);
            this.Controls.Add(this.searchGrpBx);
            this.Controls.Add(this.sortLstBx);
            this.Controls.Add(this.sortRevBtn);
            this.Controls.Add(this.sortNameBtn);
            this.Name = "Form1";
            this.Text = "Dalveer Movie Revenue";
            this.searchGrpBx.ResumeLayout(false);
            this.searchGrpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sortNameBtn;
        private System.Windows.Forms.Button sortRevBtn;
        private System.Windows.Forms.ListBox sortLstBx;
        private System.Windows.Forms.GroupBox searchGrpBx;
        private System.Windows.Forms.RadioButton revenueRdBtn;
        private System.Windows.Forms.RadioButton nameRdBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxtBx;
    }
}

