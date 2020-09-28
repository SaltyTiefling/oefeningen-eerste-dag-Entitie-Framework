namespace personbadge_oef
{
    partial class EditBadge
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
            this.lbxCurrentBadges = new System.Windows.Forms.ListBox();
            this.lbxPossibleBadges = new System.Windows.Forms.ListBox();
            this.btnDeleteBadge = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // lbxCurrentBadges
            // 
            this.lbxCurrentBadges.FormattingEnabled = true;
            this.lbxCurrentBadges.Location = new System.Drawing.Point(15, 25);
            this.lbxCurrentBadges.Name = "lbxCurrentBadges";
            this.lbxCurrentBadges.Size = new System.Drawing.Size(285, 134);
            this.lbxCurrentBadges.TabIndex = 1;
            // 
            // lbxPossibleBadges
            // 
            this.lbxPossibleBadges.FormattingEnabled = true;
            this.lbxPossibleBadges.Location = new System.Drawing.Point(386, 25);
            this.lbxPossibleBadges.Name = "lbxPossibleBadges";
            this.lbxPossibleBadges.Size = new System.Drawing.Size(160, 134);
            this.lbxPossibleBadges.TabIndex = 2;
            // 
            // btnDeleteBadge
            // 
            this.btnDeleteBadge.Location = new System.Drawing.Point(305, 90);
            this.btnDeleteBadge.Name = "btnDeleteBadge";
            this.btnDeleteBadge.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBadge.TabIndex = 3;
            this.btnDeleteBadge.Text = "=>";
            this.btnDeleteBadge.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(305, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "<=";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // EditBadge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 184);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDeleteBadge);
            this.Controls.Add(this.lbxPossibleBadges);
            this.Controls.Add(this.lbxCurrentBadges);
            this.Controls.Add(this.label1);
            this.Name = "EditBadge";
            this.Text = "EditBadge";
            this.Load += new System.EventHandler(this.EditBadge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxCurrentBadges;
        private System.Windows.Forms.ListBox lbxPossibleBadges;
        private System.Windows.Forms.Button btnDeleteBadge;
        private System.Windows.Forms.Button btnAdd;
    }
}