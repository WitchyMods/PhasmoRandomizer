namespace PhasmoRandomizer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.tblItems = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.chkIncludeLight = new System.Windows.Forms.CheckBox();
            this.chkForceFlashlight = new System.Windows.Forms.CheckBox();
            this.flpPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.numItemsPerPlayers = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numNbPlayers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panTeam = new System.Windows.Forms.Panel();
            this.ucPlayer1 = new PhasmoRandomizer.ucPlayer();
            this.ucPlayer2 = new PhasmoRandomizer.ucPlayer();
            this.ucPlayer3 = new PhasmoRandomizer.ucPlayer();
            this.ucPlayer4 = new PhasmoRandomizer.ucPlayer();
            this.btnRestoreDefaults = new System.Windows.Forms.Button();
            this.btnSetAllTo1 = new System.Windows.Forms.Button();
            this.gbSettings.SuspendLayout();
            this.flpPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemsPerPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbPlayers)).BeginInit();
            this.panTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.tblItems);
            this.gbSettings.Controls.Add(this.btnSetAllTo1);
            this.gbSettings.Controls.Add(this.btnRestoreDefaults);
            this.gbSettings.Controls.Add(this.btnSaveSettings);
            this.gbSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSettings.ForeColor = System.Drawing.Color.White;
            this.gbSettings.Location = new System.Drawing.Point(0, 0);
            this.gbSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSettings.Size = new System.Drawing.Size(438, 252);
            this.gbSettings.TabIndex = 1;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // tblItems
            // 
            this.tblItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblItems.AutoScroll = true;
            this.tblItems.ColumnCount = 4;
            this.tblItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblItems.Location = new System.Drawing.Point(6, 22);
            this.tblItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblItems.Name = "tblItems";
            this.tblItems.RowCount = 2;
            this.tblItems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblItems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblItems.Size = new System.Drawing.Size(425, 190);
            this.tblItems.TabIndex = 1;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSaveSettings.Location = new System.Drawing.Point(356, 218);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 26);
            this.btnSaveSettings.TabIndex = 0;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // chkIncludeLight
            // 
            this.chkIncludeLight.AutoSize = true;
            this.chkIncludeLight.Location = new System.Drawing.Point(295, 42);
            this.chkIncludeLight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIncludeLight.Name = "chkIncludeLight";
            this.chkIncludeLight.Size = new System.Drawing.Size(140, 19);
            this.chkIncludeLight.TabIndex = 7;
            this.chkIncludeLight.Text = "Include 1 lightsource";
            this.chkIncludeLight.UseVisualStyleBackColor = true;
            // 
            // chkForceFlashlight
            // 
            this.chkForceFlashlight.AutoSize = true;
            this.chkForceFlashlight.Location = new System.Drawing.Point(164, 42);
            this.chkForceFlashlight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkForceFlashlight.Name = "chkForceFlashlight";
            this.chkForceFlashlight.Size = new System.Drawing.Size(114, 19);
            this.chkForceFlashlight.TabIndex = 6;
            this.chkForceFlashlight.Text = "Force Flashlight";
            this.chkForceFlashlight.UseVisualStyleBackColor = true;
            this.chkForceFlashlight.CheckedChanged += new System.EventHandler(this.chkForceFlashlight_CheckedChanged);
            // 
            // flpPlayers
            // 
            this.flpPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpPlayers.AutoScroll = true;
            this.flpPlayers.Controls.Add(this.ucPlayer1);
            this.flpPlayers.Controls.Add(this.ucPlayer2);
            this.flpPlayers.Controls.Add(this.ucPlayer3);
            this.flpPlayers.Controls.Add(this.ucPlayer4);
            this.flpPlayers.Location = new System.Drawing.Point(3, 68);
            this.flpPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpPlayers.Name = "flpPlayers";
            this.flpPlayers.Size = new System.Drawing.Size(432, 182);
            this.flpPlayers.TabIndex = 5;
            // 
            // numItemsPerPlayers
            // 
            this.numItemsPerPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.numItemsPerPlayers.ForeColor = System.Drawing.Color.White;
            this.numItemsPerPlayers.Location = new System.Drawing.Point(118, 38);
            this.numItemsPerPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numItemsPerPlayers.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numItemsPerPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemsPerPlayers.Name = "numItemsPerPlayers";
            this.numItemsPerPlayers.Size = new System.Drawing.Size(38, 21);
            this.numItemsPerPlayers.TabIndex = 1;
            this.numItemsPerPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numItemsPerPlayers.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numItemsPerPlayers.ValueChanged += new System.EventHandler(this.numItemsPerPlayers_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Items Per Player:";
            // 
            // numNbPlayers
            // 
            this.numNbPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.numNbPlayers.ForeColor = System.Drawing.Color.White;
            this.numNbPlayers.Location = new System.Drawing.Point(118, 8);
            this.numNbPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numNbPlayers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numNbPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNbPlayers.Name = "numNbPlayers";
            this.numNbPlayers.Size = new System.Drawing.Size(38, 21);
            this.numNbPlayers.TabIndex = 1;
            this.numNbPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNbPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNbPlayers.ValueChanged += new System.EventHandler(this.numNbPlayers_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nb Players:";
            // 
            // btnRandomize
            // 
            this.btnRandomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRandomize.ForeColor = System.Drawing.Color.White;
            this.btnRandomize.Location = new System.Drawing.Point(164, 4);
            this.btnRandomize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(87, 26);
            this.btnRandomize.TabIndex = 3;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.UseVisualStyleBackColor = false;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::PhasmoRandomizer.Properties.Resources.gear;
            this.btnSettings.Location = new System.Drawing.Point(396, 3);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(31, 30);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panTeam
            // 
            this.panTeam.Controls.Add(this.btnSettings);
            this.panTeam.Controls.Add(this.btnRandomize);
            this.panTeam.Controls.Add(this.label1);
            this.panTeam.Controls.Add(this.chkIncludeLight);
            this.panTeam.Controls.Add(this.numNbPlayers);
            this.panTeam.Controls.Add(this.chkForceFlashlight);
            this.panTeam.Controls.Add(this.label2);
            this.panTeam.Controls.Add(this.flpPlayers);
            this.panTeam.Controls.Add(this.numItemsPerPlayers);
            this.panTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTeam.Location = new System.Drawing.Point(0, 0);
            this.panTeam.Name = "panTeam";
            this.panTeam.Size = new System.Drawing.Size(438, 252);
            this.panTeam.TabIndex = 3;
            // 
            // ucPlayer1
            // 
            this.ucPlayer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ucPlayer1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPlayer1.ForeColor = System.Drawing.Color.White;
            this.ucPlayer1.Location = new System.Drawing.Point(3, 4);
            this.ucPlayer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucPlayer1.MinimumSize = new System.Drawing.Size(200, 0);
            this.ucPlayer1.Name = "ucPlayer1";
            this.ucPlayer1.Padding = new System.Windows.Forms.Padding(2);
            this.ucPlayer1.Size = new System.Drawing.Size(200, 73);
            this.ucPlayer1.TabIndex = 0;
            // 
            // ucPlayer2
            // 
            this.ucPlayer2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ucPlayer2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPlayer2.ForeColor = System.Drawing.Color.White;
            this.ucPlayer2.Location = new System.Drawing.Point(209, 4);
            this.ucPlayer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucPlayer2.MinimumSize = new System.Drawing.Size(200, 0);
            this.ucPlayer2.Name = "ucPlayer2";
            this.ucPlayer2.Padding = new System.Windows.Forms.Padding(2);
            this.ucPlayer2.Size = new System.Drawing.Size(200, 73);
            this.ucPlayer2.TabIndex = 1;
            this.ucPlayer2.Visible = false;
            // 
            // ucPlayer3
            // 
            this.ucPlayer3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucPlayer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ucPlayer3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPlayer3.ForeColor = System.Drawing.Color.White;
            this.ucPlayer3.Location = new System.Drawing.Point(3, 85);
            this.ucPlayer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucPlayer3.MinimumSize = new System.Drawing.Size(200, 0);
            this.ucPlayer3.Name = "ucPlayer3";
            this.ucPlayer3.Padding = new System.Windows.Forms.Padding(2);
            this.ucPlayer3.Size = new System.Drawing.Size(200, 73);
            this.ucPlayer3.TabIndex = 2;
            this.ucPlayer3.Visible = false;
            // 
            // ucPlayer4
            // 
            this.ucPlayer4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucPlayer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ucPlayer4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPlayer4.ForeColor = System.Drawing.Color.White;
            this.ucPlayer4.Location = new System.Drawing.Point(209, 85);
            this.ucPlayer4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucPlayer4.MinimumSize = new System.Drawing.Size(200, 0);
            this.ucPlayer4.Name = "ucPlayer4";
            this.ucPlayer4.Padding = new System.Windows.Forms.Padding(2);
            this.ucPlayer4.Size = new System.Drawing.Size(200, 73);
            this.ucPlayer4.TabIndex = 3;
            this.ucPlayer4.Visible = false;
            // 
            // btnRestoreDefaults
            // 
            this.btnRestoreDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreDefaults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRestoreDefaults.Location = new System.Drawing.Point(6, 218);
            this.btnRestoreDefaults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestoreDefaults.Name = "btnRestoreDefaults";
            this.btnRestoreDefaults.Size = new System.Drawing.Size(125, 26);
            this.btnRestoreDefaults.TabIndex = 0;
            this.btnRestoreDefaults.Text = "Restore Defaults";
            this.btnRestoreDefaults.UseVisualStyleBackColor = false;
            this.btnRestoreDefaults.Click += new System.EventHandler(this.btnRestoreDefaults_Click);
            // 
            // btnSetAllTo1
            // 
            this.btnSetAllTo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetAllTo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSetAllTo1.Location = new System.Drawing.Point(137, 218);
            this.btnSetAllTo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetAllTo1.Name = "btnSetAllTo1";
            this.btnSetAllTo1.Size = new System.Drawing.Size(75, 26);
            this.btnSetAllTo1.TabIndex = 0;
            this.btnSetAllTo1.Text = "Set All To 1";
            this.btnSetAllTo1.UseVisualStyleBackColor = false;
            this.btnSetAllTo1.Click += new System.EventHandler(this.btnSetAllTo1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(438, 252);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.panTeam);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Phasmophobia Randomizer by WitchyMods";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSettings.ResumeLayout(false);
            this.flpPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numItemsPerPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbPlayers)).EndInit();
            this.panTeam.ResumeLayout(false);
            this.panTeam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.TableLayoutPanel tblItems;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.NumericUpDown numItemsPerPlayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numNbPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpPlayers;
        private ucPlayer ucPlayer1;
        private ucPlayer ucPlayer2;
        private ucPlayer ucPlayer3;
        private ucPlayer ucPlayer4;
        private System.Windows.Forms.CheckBox chkForceFlashlight;
        private System.Windows.Forms.CheckBox chkIncludeLight;
        private System.Windows.Forms.Panel panTeam;
        private System.Windows.Forms.Button btnSetAllTo1;
        private System.Windows.Forms.Button btnRestoreDefaults;
    }
}

