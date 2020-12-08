namespace PhasmoRandomizer
{
    partial class ucPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.panItems = new System.Windows.Forms.Panel();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPlayerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNumber.Location = new System.Drawing.Point(0, 0);
            this.lblPlayerNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(98, 29);
            this.lblPlayerNumber.TabIndex = 0;
            this.lblPlayerNumber.Text = "Player 1";
            this.lblPlayerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panItems
            // 
            this.panItems.AutoSize = true;
            this.panItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panItems.Location = new System.Drawing.Point(2, 32);
            this.panItems.Name = "panItems";
            this.panItems.Size = new System.Drawing.Size(197, 0);
            this.panItems.TabIndex = 1;
            // 
            // btnRandomize
            // 
            this.btnRandomize.BackColor = System.Drawing.Color.Transparent;
            this.btnRandomize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRandomize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRandomize.FlatAppearance.BorderSize = 0;
            this.btnRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomize.ForeColor = System.Drawing.Color.White;
            this.btnRandomize.Image = global::PhasmoRandomizer.Properties.Resources.dicewhite;
            this.btnRandomize.Location = new System.Drawing.Point(167, 0);
            this.btnRandomize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(30, 29);
            this.btnRandomize.TabIndex = 6;
            this.btnRandomize.UseVisualStyleBackColor = false;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRandomize);
            this.panel1.Controls.Add(this.lblPlayerNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 29);
            this.panel1.TabIndex = 7;
            // 
            // ucPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.panItems);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(201, 0);
            this.Name = "ucPlayer";
            this.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Size = new System.Drawing.Size(201, 35);
            this.Load += new System.EventHandler(this.ucPlayer_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.Panel panItems;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Panel panel1;
    }
}
