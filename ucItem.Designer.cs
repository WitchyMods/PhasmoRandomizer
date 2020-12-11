namespace PhasmoRandomizer
{
    partial class ucItem
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
            this.lblItemPos = new System.Windows.Forms.Label();
            this.lblItemResult = new System.Windows.Forms.Label();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItemPos
            // 
            this.lblItemPos.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblItemPos.Location = new System.Drawing.Point(0, 0);
            this.lblItemPos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemPos.Name = "lblItemPos";
            this.lblItemPos.Size = new System.Drawing.Size(52, 19);
            this.lblItemPos.TabIndex = 3;
            this.lblItemPos.Text = "Item 1:";
            this.lblItemPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemResult
            // 
            this.lblItemResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemResult.ForeColor = System.Drawing.Color.LightGreen;
            this.lblItemResult.Location = new System.Drawing.Point(52, 0);
            this.lblItemResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemResult.Name = "lblItemResult";
            this.lblItemResult.Size = new System.Drawing.Size(287, 19);
            this.lblItemResult.TabIndex = 4;
            this.lblItemResult.Text = "[Item1]";
            this.lblItemResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnRandomize.Location = new System.Drawing.Point(339, 0);
            this.btnRandomize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(18, 19);
            this.btnRandomize.TabIndex = 5;
            this.btnRandomize.UseVisualStyleBackColor = false;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // ucItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.lblItemResult);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.lblItemPos);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ucItem";
            this.Size = new System.Drawing.Size(357, 19);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblItemPos;
        public System.Windows.Forms.Label lblItemResult;
        private System.Windows.Forms.Button btnRandomize;
    }
}
