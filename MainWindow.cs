using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhasmoRandomizer
{
    public partial class MainWindow : Form
    {
        private List<NumericUpDown> ItemNums = new List<NumericUpDown>();

        private List<Dictionary<int, bool>> SelectedItems = new List<Dictionary<int, bool>>();

        private List<ucPlayer> UcPlayers = new List<ucPlayer>();

        public static MainWindow Instance = null;

        public MainWindow()
        {
            InitializeComponent();

            Instance = this;

            gbSettings.Visible = false;
            
            for(int i = 0; i < 4; i++)
            {
                ucPlayer ctrl = new ucPlayer(i);
                this.flpPlayers.Controls.Add(ctrl);
                this.UcPlayers.Add(ctrl);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Upgrade();

            string strQuantities = Properties.Settings.Default.Quantities;
            int[] quantities = null;

            if (!String.IsNullOrEmpty(strQuantities))
            {
                quantities = strQuantities.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

                for (int i = 0; i < quantities.Length; i++)
                {
                    Item.AllItems[i].MaxQty = quantities[i];
                }
            }

            for (int i = 0; i < Item.AllItems.Count; i++)
            {
                Label lbl = new Label() { Text = Item.AllItems[i].Name, ForeColor = Color.White };
                NumericUpDown num = new NumericUpDown()
                {
                    TextAlign = HorizontalAlignment.Center,
                    Width = 50,
                    BackColor = Color.FromArgb(60, 60, 60),
                    ForeColor = Color.White,
                    Minimum = 0,
                    Maximum = Item.AllItems[i].DefaultMaxQty,
                    Value = Item.AllItems[i].MaxQty,
                    Tag = i
                };

                tblItems.Controls.Add(lbl);
                tblItems.Controls.Add(num);

                this.ItemNums.Add(num);
            }

            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text += " " + version.ToString();

            Randomizer.Randomize();
            this.UpdateUI();
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            Randomizer.Randomize();
            this.UpdateUI();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            gbSettings.Visible = true;
            panTeam.Visible = false;
            btnRandomize.Visible = false;
        }

        private void numNbPlayers_ValueChanged(object sender, EventArgs e)
        {
            Randomizer.SetNbPlayers((int)numNbPlayers.Value);
            this.UpdateUI();
        }

        private void numItemsPerPlayers_ValueChanged(object sender, EventArgs e)
        {
            Randomizer.SetNbItemsPerPlayer((int)numItemsPerPlayers.Value);
            UpdateUI();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            gbSettings.Visible = false;
            panTeam.Visible = true;
            btnRandomize.Visible = true;

            string strQuantities = String.Join(";", this.ItemNums.Select(x => x.Value));
            Properties.Settings.Default.Quantities = strQuantities;
            Properties.Settings.Default.Save();
        }

        private void chkForceFlashlight_CheckedChanged(object sender, EventArgs e)
        {
            Randomizer.ForceFlashlight = chkForceFlashlight.Checked;

            if (Randomizer.ForceFlashlight)
            {
                Randomizer.Randomize();
                this.UpdateUI();
            }
        }

        private void chkIncludeLight_CheckedChanged(object sender, EventArgs e)
        {
            Randomizer.ForceLightsource = chkIncludeLight.Checked;

            if (Randomizer.ForceLightsource)
            {
                Randomizer.Randomize();
                this.UpdateUI();
            }
        }

        private void btnRestoreDefaults_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.ItemNums.Count; i++)
            {
                this.ItemNums[i].Value = this.ItemNums[i].Maximum;
            }
        }

        private void btnSetAllTo1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.ItemNums.Count; i++)
            {
                this.ItemNums[i].Value = 1;
            }
        }

        private void UpdateUI()
        {
            foreach(var ctrl in this.UcPlayers)
            {
                ctrl.UpdateUI();
            }
        }

        private void lnkTwitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.twitch.tv/witchymods");
        }

        private void lnkDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/WitchyMods/PhasmoRandomizer/releases");
        }

        private void lnkDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/fHYM2KXffm");
        }
    }
}
