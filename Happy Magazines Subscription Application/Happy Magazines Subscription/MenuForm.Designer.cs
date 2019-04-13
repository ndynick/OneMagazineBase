namespace Happy_Magazines_Subscription
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.btnMember = new System.Windows.Forms.Button();
            this.btnSchool = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.Location = new System.Drawing.Point(251, 66);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(197, 72);
            this.btnMember.TabIndex = 17;
            this.btnMember.Text = "Member Subscription";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnSchool
            // 
            this.btnSchool.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchool.Location = new System.Drawing.Point(251, 165);
            this.btnSchool.Name = "btnSchool";
            this.btnSchool.Size = new System.Drawing.Size(197, 72);
            this.btnSchool.TabIndex = 16;
            this.btnSchool.Text = "School Subscription";
            this.btnSchool.UseVisualStyleBackColor = false;
            this.btnSchool.Click += new System.EventHandler(this.btnSchool_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 214);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(468, 273);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnSchool);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Controls.SetChildIndex(this.btnSchool, 0);
            this.Controls.SetChildIndex(this.btnMember, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnSchool;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}
