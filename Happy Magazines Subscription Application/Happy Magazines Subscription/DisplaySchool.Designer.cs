namespace Happy_Magazines_Subscription
{
    partial class DisplaySchool
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
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.listSchool = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDisplayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAll.Location = new System.Drawing.Point(141, 206);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(133, 44);
            this.btnDisplayAll.TabIndex = 24;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = false;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // listSchool
            // 
            this.listSchool.FormattingEnabled = true;
            this.listSchool.Location = new System.Drawing.Point(12, 53);
            this.listSchool.Name = "listSchool";
            this.listSchool.ScrollAlwaysVisible = true;
            this.listSchool.Size = new System.Drawing.Size(444, 147);
            this.listSchool.TabIndex = 25;
            // 
            // DisplaySchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(468, 273);
            this.Controls.Add(this.listSchool);
            this.Controls.Add(this.btnDisplayAll);
            this.Name = "DisplaySchool";
            this.Text = "DisplaySchool";
            this.Load += new System.EventHandler(this.DisplaySchool_Load);
            this.Controls.SetChildIndex(this.btnDisplayAll, 0);
            this.Controls.SetChildIndex(this.listSchool, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.ListBox listSchool;
    }
}
