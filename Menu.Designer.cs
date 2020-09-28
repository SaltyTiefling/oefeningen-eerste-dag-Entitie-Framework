namespace personbadge_oef
{
    partial class Menu
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
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lbPersonen = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnEditBadge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToevoegen.Location = new System.Drawing.Point(254, 12);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(153, 23);
            this.btnToevoegen.TabIndex = 0;
            this.btnToevoegen.Text = "PersoonToevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // lbPersonen
            // 
            this.lbPersonen.FormattingEnabled = true;
            this.lbPersonen.Location = new System.Drawing.Point(13, 13);
            this.lbPersonen.Name = "lbPersonen";
            this.lbPersonen.Size = new System.Drawing.Size(235, 160);
            this.lbPersonen.TabIndex = 1;
            this.lbPersonen.SelectedIndexChanged += new System.EventHandler(this.lbPersonen_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(229, 176);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "00";
            // 
            // btnEditBadge
            // 
            this.btnEditBadge.Location = new System.Drawing.Point(254, 41);
            this.btnEditBadge.Name = "btnEditBadge";
            this.btnEditBadge.Size = new System.Drawing.Size(153, 23);
            this.btnEditBadge.TabIndex = 3;
            this.btnEditBadge.Text = "Edit Badge";
            this.btnEditBadge.UseVisualStyleBackColor = true;
            this.btnEditBadge.Click += new System.EventHandler(this.btnEditBadge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "id:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditBadge);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lbPersonen);
            this.Controls.Add(this.btnToevoegen);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.BindingSource persoonBindingSource;
        private System.Windows.Forms.BindingSource persoonBindingSource1;
        private System.Windows.Forms.ListBox lbPersonen;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnEditBadge;
        private System.Windows.Forms.Label label1;
    }
}

