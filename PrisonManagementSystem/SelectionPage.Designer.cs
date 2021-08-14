namespace PrisonManagementSystem
{
    partial class SelectionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionPage));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_prisoner = new System.Windows.Forms.Button();
            this.btn_guard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(119, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select First";
            // 
            // btn_prisoner
            // 
            this.btn_prisoner.BackColor = System.Drawing.SystemColors.Control;
            this.btn_prisoner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prisoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prisoner.Location = new System.Drawing.Point(137, 120);
            this.btn_prisoner.Name = "btn_prisoner";
            this.btn_prisoner.Size = new System.Drawing.Size(126, 56);
            this.btn_prisoner.TabIndex = 1;
            this.btn_prisoner.Text = "Prisoner";
            this.btn_prisoner.UseVisualStyleBackColor = false;
            this.btn_prisoner.Click += new System.EventHandler(this.btn_prisoner_Click);
            // 
            // btn_guard
            // 
            this.btn_guard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guard.Location = new System.Drawing.Point(137, 211);
            this.btn_guard.Name = "btn_guard";
            this.btn_guard.Size = new System.Drawing.Size(126, 56);
            this.btn_guard.TabIndex = 1;
            this.btn_guard.Text = "Guard";
            this.btn_guard.UseVisualStyleBackColor = true;
            this.btn_guard.Click += new System.EventHandler(this.btn_guard_Click);
            // 
            // SelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 520);
            this.Controls.Add(this.btn_guard);
            this.Controls.Add(this.btn_prisoner);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prison Management Sysytem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectionPage_FormClosed);
            this.Load += new System.EventHandler(this.SelectionPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_prisoner;
        private System.Windows.Forms.Button btn_guard;
    }
}