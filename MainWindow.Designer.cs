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
            this.btnSetAllTo1 = new System.Windows.Forms.Button();
            this.btnRestoreDefaults = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.chkIncludeLight = new System.Windows.Forms.CheckBox();
            this.chkForceFlashlight = new System.Windows.Forms.CheckBox();
            this.flpPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.numItemsPerPlayers = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numNbPlayers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.panTeam = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkDiscord = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkTwitch = new System.Windows.Forms.LinkLabel();
            this.lnkDownload = new System.Windows.Forms.LinkLabel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemsPerPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbPlayers)).BeginInit();
            this.panTeam.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.tblItems);
            this.gbSettings.Controls.Add(this.btnSetAllTo1);
            this.gbSettings.Controls.Add(this.btnRestoreDefaults);
            this.gbSettings.Controls.Add(this.btnSaveSettings);
            this.gbSettings.Controls.Add(this.chkIncludeLight);
            this.gbSettings.Controls.Add(this.chkForceFlashlight);
            this.gbSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSettings.ForeColor = System.Drawing.Color.White;
            this.gbSettings.Location = new System.Drawing.Point(0, 0);
            this.gbSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSettings.Size = new System.Drawing.Size(438, 397);
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
            this.tblItems.Location = new System.Drawing.Point(6, 52);
            this.tblItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblItems.Name = "tblItems";
            this.tblItems.RowCount = 2;
            this.tblItems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblItems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblItems.Size = new System.Drawing.Size(421, 298);
            this.tblItems.TabIndex = 1;
            // 
            // btnSetAllTo1
            // 
            this.btnSetAllTo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetAllTo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSetAllTo1.Location = new System.Drawing.Point(133, 356);
            this.btnSetAllTo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetAllTo1.Name = "btnSetAllTo1";
            this.btnSetAllTo1.Size = new System.Drawing.Size(75, 28);
            this.btnSetAllTo1.TabIndex = 0;
            this.btnSetAllTo1.Text = "Set All To 1";
            this.btnSetAllTo1.UseVisualStyleBackColor = false;
            this.btnSetAllTo1.Click += new System.EventHandler(this.btnSetAllTo1_Click);
            // 
            // btnRestoreDefaults
            // 
            this.btnRestoreDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestoreDefaults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRestoreDefaults.Location = new System.Drawing.Point(2, 356);
            this.btnRestoreDefaults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestoreDefaults.Name = "btnRestoreDefaults";
            this.btnRestoreDefaults.Size = new System.Drawing.Size(125, 28);
            this.btnRestoreDefaults.TabIndex = 0;
            this.btnRestoreDefaults.Text = "Restore Defaults";
            this.btnRestoreDefaults.UseVisualStyleBackColor = false;
            this.btnRestoreDefaults.Click += new System.EventHandler(this.btnRestoreDefaults_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSaveSettings.Location = new System.Drawing.Point(352, 356);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 28);
            this.btnSaveSettings.TabIndex = 0;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // chkIncludeLight
            // 
            this.chkIncludeLight.AutoSize = true;
            this.chkIncludeLight.Location = new System.Drawing.Point(140, 23);
            this.chkIncludeLight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIncludeLight.Name = "chkIncludeLight";
            this.chkIncludeLight.Size = new System.Drawing.Size(146, 20);
            this.chkIncludeLight.TabIndex = 7;
            this.chkIncludeLight.Text = "Include 1 lightsource";
            this.chkIncludeLight.UseVisualStyleBackColor = true;
            this.chkIncludeLight.CheckedChanged += new System.EventHandler(this.chkIncludeLight_CheckedChanged);
            // 
            // chkForceFlashlight
            // 
            this.chkForceFlashlight.AutoSize = true;
            this.chkForceFlashlight.Location = new System.Drawing.Point(9, 23);
            this.chkForceFlashlight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkForceFlashlight.Name = "chkForceFlashlight";
            this.chkForceFlashlight.Size = new System.Drawing.Size(120, 20);
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
            this.flpPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpPlayers.Location = new System.Drawing.Point(3, 73);
            this.flpPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpPlayers.Name = "flpPlayers";
            this.flpPlayers.Size = new System.Drawing.Size(432, 243);
            this.flpPlayers.TabIndex = 5;
            // 
            // numItemsPerPlayers
            // 
            this.numItemsPerPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.numItemsPerPlayers.ForeColor = System.Drawing.Color.White;
            this.numItemsPerPlayers.Location = new System.Drawing.Point(118, 41);
            this.numItemsPerPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numItemsPerPlayers.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numItemsPerPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemsPerPlayers.Name = "numItemsPerPlayers";
            this.numItemsPerPlayers.Size = new System.Drawing.Size(38, 22);
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
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Items Per Player:";
            // 
            // numNbPlayers
            // 
            this.numNbPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.numNbPlayers.ForeColor = System.Drawing.Color.White;
            this.numNbPlayers.Location = new System.Drawing.Point(118, 9);
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
            this.numNbPlayers.Size = new System.Drawing.Size(38, 22);
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
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
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
            this.btnRandomize.Size = new System.Drawing.Size(87, 28);
            this.btnRandomize.TabIndex = 3;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.UseVisualStyleBackColor = false;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // panTeam
            // 
            this.panTeam.Controls.Add(this.panel1);
            this.panTeam.Controls.Add(this.btnSettings);
            this.panTeam.Controls.Add(this.btnRandomize);
            this.panTeam.Controls.Add(this.label1);
            this.panTeam.Controls.Add(this.numNbPlayers);
            this.panTeam.Controls.Add(this.label2);
            this.panTeam.Controls.Add(this.flpPlayers);
            this.panTeam.Controls.Add(this.numItemsPerPlayers);
            this.panTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTeam.Location = new System.Drawing.Point(0, 0);
            this.panTeam.Name = "panTeam";
            this.panTeam.Size = new System.Drawing.Size(438, 397);
            this.panTeam.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lnkDiscord);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lnkTwitch);
            this.panel1.Controls.Add(this.lnkDownload);
            this.panel1.Location = new System.Drawing.Point(3, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 74);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Discord:";
            // 
            // lnkDiscord
            // 
            this.lnkDiscord.AutoSize = true;
            this.lnkDiscord.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDiscord.LinkColor = System.Drawing.Color.MediumPurple;
            this.lnkDiscord.Location = new System.Drawing.Point(133, 44);
            this.lnkDiscord.Name = "lnkDiscord";
            this.lnkDiscord.Size = new System.Drawing.Size(179, 15);
            this.lnkDiscord.TabIndex = 12;
            this.lnkDiscord.TabStop = true;
            this.lnkDiscord.Text = "https://discord.gg/fHYM2KXffm";
            this.lnkDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDiscord_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Please give a follow :)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Download link:";
            // 
            // lnkTwitch
            // 
            this.lnkTwitch.AutoSize = true;
            this.lnkTwitch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTwitch.LinkColor = System.Drawing.Color.MediumPurple;
            this.lnkTwitch.Location = new System.Drawing.Point(134, 0);
            this.lnkTwitch.Name = "lnkTwitch";
            this.lnkTwitch.Size = new System.Drawing.Size(198, 15);
            this.lnkTwitch.TabIndex = 8;
            this.lnkTwitch.TabStop = true;
            this.lnkTwitch.Text = "https://www.twitch.tv/witchymods";
            this.lnkTwitch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTwitch_LinkClicked);
            // 
            // lnkDownload
            // 
            this.lnkDownload.AutoSize = true;
            this.lnkDownload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDownload.LinkColor = System.Drawing.Color.MediumPurple;
            this.lnkDownload.Location = new System.Drawing.Point(133, 20);
            this.lnkDownload.Name = "lnkDownload";
            this.lnkDownload.Size = new System.Drawing.Size(299, 15);
            this.lnkDownload.TabIndex = 10;
            this.lnkDownload.TabStop = true;
            this.lnkDownload.Text = "https://github.com/WitchyMods/PhasmoRandomizer";
            this.lnkDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDownload_LinkClicked);
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
            this.btnSettings.Size = new System.Drawing.Size(31, 32);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(438, 397);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.panTeam);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1064);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(100, 104);
            this.Name = "MainWindow";
            this.Text = "Phasmophobia Randomizer by WitchyMods";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.MainWindow_ResizeEnd);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemsPerPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbPlayers)).EndInit();
            this.panTeam.ResumeLayout(false);
            this.panTeam.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkForceFlashlight;
        private System.Windows.Forms.CheckBox chkIncludeLight;
        private System.Windows.Forms.Panel panTeam;
        private System.Windows.Forms.Button btnSetAllTo1;
        private System.Windows.Forms.Button btnRestoreDefaults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkTwitch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkDownload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkDiscord;
    }
}

