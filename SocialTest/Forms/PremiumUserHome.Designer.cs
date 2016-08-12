namespace Social_Network.Forms
{
    partial class PremiumUserHome
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
            this.gboxOrder = new System.Windows.Forms.GroupBox();
            this.rdbABCSongs = new System.Windows.Forms.RadioButton();
            this.rdbABCSingers = new System.Windows.Forms.RadioButton();
            this.gboxOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxOrder
            // 
            this.gboxOrder.Controls.Add(this.rdbABCSongs);
            this.gboxOrder.Controls.Add(this.rdbABCSingers);
            this.gboxOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxOrder.Font = new System.Drawing.Font("Bauhaus 93", 8.25F);
            this.gboxOrder.Location = new System.Drawing.Point(789, 364);
            this.gboxOrder.Name = "gboxOrder";
            this.gboxOrder.Size = new System.Drawing.Size(114, 62);
            this.gboxOrder.TabIndex = 29;
            this.gboxOrder.TabStop = false;
            this.gboxOrder.Text = "Order By : ";
            // 
            // rdbABCSongs
            // 
            this.rdbABCSongs.AutoSize = true;
            this.rdbABCSongs.Location = new System.Drawing.Point(6, 39);
            this.rdbABCSongs.Name = "rdbABCSongs";
            this.rdbABCSongs.Size = new System.Drawing.Size(76, 17);
            this.rdbABCSongs.TabIndex = 1;
            this.rdbABCSongs.TabStop = true;
            this.rdbABCSongs.Text = "ABC Songs";
            this.rdbABCSongs.UseVisualStyleBackColor = true;
            this.rdbABCSongs.CheckedChanged += new System.EventHandler(this.rdbABCSongs_CheckedChanged);
            // 
            // rdbABCSingers
            // 
            this.rdbABCSingers.AutoSize = true;
            this.rdbABCSingers.Location = new System.Drawing.Point(3, 16);
            this.rdbABCSingers.Name = "rdbABCSingers";
            this.rdbABCSingers.Size = new System.Drawing.Size(83, 17);
            this.rdbABCSingers.TabIndex = 0;
            this.rdbABCSingers.TabStop = true;
            this.rdbABCSingers.Text = "ABC Singers";
            this.rdbABCSingers.UseVisualStyleBackColor = true;
            this.rdbABCSingers.CheckedChanged += new System.EventHandler(this.rdbABCSingers_CheckedChanged);
            // 
            // PremiumUserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(937, 458);
            this.Controls.Add(this.gboxOrder);
            this.Name = "PremiumUserHome";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Controls.SetChildIndex(this.gboxOrder, 0);
            this.gboxOrder.ResumeLayout(false);
            this.gboxOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gboxOrder;
        private System.Windows.Forms.RadioButton rdbABCSongs;
        private System.Windows.Forms.RadioButton rdbABCSingers;
    }
}
