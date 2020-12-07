using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhasmoRandomizer
{
    public partial class MainWindow : Form
    {
        private List<Item> AllItems = new List<Item>() {
            new Item("EMF Reader", 2), 
            new Item("Flashlight", 4, true, true), 
            new Item("Photo Camera", 3),
            new Item("Lighter", 2, true),
            new Item("Candle", 4, true),
            new Item("UV Light", 2, true),
            new Item("Crucifix", 2),
            new Item("Video Camera", 6),
            new Item("Spirit Box", 2),
            new Item("Salt", 2),
            new Item("Smudge Stick", 4),
            new Item("Tripod", 5),
            new Item("Strong Flashlight", 4, true, true),
            new Item("Motion Sensor", 4),
            new Item("Sound Sensor", 4),
            new Item("Sanity Pills", 4),
            new Item("Thermometer", 3),
            new Item("Ghost Writing Book", 2), 
            new Item("Infrared Light Sensor",4),
            new Item("Parabolic Microphone", 2),
            new Item("Glowstick", 2, true),
            new Item("Head Mounted Camera", 4)
        };

        private List<NumericUpDown> ItemNums = new List<NumericUpDown>();

        private ucPlayer[] UcPlayers;

        public MainWindow()
        {
            InitializeComponent();

            gbSettings.Visible = false;
            UcPlayers = new ucPlayer[] {this.ucPlayer1, this.ucPlayer2, this.ucPlayer3, this.ucPlayer4 };
        }

        public class Item
        {
            public string Name { get; set; }
            public int MaxQty { get; set; }
            public int DefaultMaxQty { get; set; }
            public bool IsLight { get; set; }
            public bool IsFlashlight { get; set; }

            public int QtyLeft { get; set; }

            public Item(string name, int qty, bool isLight = false, bool isFlashlight = false)
            {
                this.Name = name;
                this.MaxQty = this.DefaultMaxQty = qty;
                this.IsLight = isLight;
                this.IsFlashlight = isFlashlight;
            }

            public override string ToString()
            {
                return this.Name;
            }
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            for(int i = 0; i < AllItems.Count; i++)
            {
                AllItems[i].QtyLeft = (int)ItemNums[i].Value;
            }

            int numPlayers = (int)numNbPlayers.Value;
            List<List<Item>> selectedItems = new List<List<Item>>();
            List<Item> randomItems = AllItems.Where(x => x.QtyLeft > 0).ToList();

            for (int i = 0; i < numPlayers; i++)
            {
                UcPlayers[i].lblItem1Result.Text = UcPlayers[i].lblItem2Result.Text = UcPlayers[i].lblItem3Result.Text = "";
                selectedItems.Add(new List<Item>());
            }

            if (chkForceFlashlight.Checked)
            {
                List<Item> flashLights = AllItems.Where(x => x.QtyLeft > 0 && x.IsFlashlight).ToList();
                randomItems.RemoveAll(x => flashLights.Contains(x));

                for(int i = 0; i < numPlayers && flashLights.Count > 0; i++)
                {
                    Item item = flashLights[r.Next(0, flashLights.Count)];
                    selectedItems[i].Add(item);
                    item.QtyLeft--;

                    if (item.QtyLeft == 0) flashLights.Remove(item);
                }
            }

            if (chkIncludeLight.Checked)
            {
                List<Item> lights = AllItems.Where(x => x.QtyLeft > 0 && x.IsLight).ToList();
                randomItems.RemoveAll(x => lights.Contains(x));

                for (int i=0;i<numPlayers && lights.Count > 0; i++)
                {
                    if (selectedItems[i].Any(x => x.IsLight)) continue;

                    Item item = lights[r.Next(0, lights.Count)];
                    selectedItems[i].Add(item);
                    item.QtyLeft--;

                    if (item.QtyLeft == 0) lights.Remove(item);
                }
            }

            for(int i = 0; i < numPlayers; i++)
            {
                List<Item> possibleItems = new List<Item>(randomItems);
                possibleItems.RemoveAll(x => selectedItems[i].Contains(x));

                for(int n = selectedItems[i].Count; n < numItemsPerPlayers.Value && possibleItems.Count > 0; n++)
                {
                    Item item = possibleItems[r.Next(0, possibleItems.Count)];
                    selectedItems[i].Add(item);

                    item.QtyLeft--;
                    possibleItems.Remove(item);
                    if(item.QtyLeft == 0)
                    {
                        randomItems.Remove(item);
                    }
                }
            }

            //Display the results
            for(int i = 0; i < selectedItems.Count; i++)
            {
                for(int n = 0; n < selectedItems[i].Count; n++)
                {
                    switch (n)
                    {
                        case 0: this.UcPlayers[i].lblItem1Result.Text = selectedItems[i][n].Name; break;
                        case 1: this.UcPlayers[i].lblItem2Result.Text = selectedItems[i][n].Name; break;
                        case 2: this.UcPlayers[i].lblItem3Result.Text = selectedItems[i][n].Name; break;
                    }
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            gbSettings.Visible = true;
            panTeam.Visible = false;
            btnRandomize.Visible = false;
        }

        private void numNbPlayers_ValueChanged(object sender, EventArgs e)
        {
            ucPlayer2.Visible = numNbPlayers.Value >= 2;
            ucPlayer3.Visible = numNbPlayers.Value >= 3;
            ucPlayer4.Visible = numNbPlayers.Value >= 4;
        }

        private void numItemsPerPlayers_ValueChanged(object sender, EventArgs e)
        {
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
            UpdateUI();
        }

        private void UpdateUI()
        {
            foreach (ucPlayer player in flpPlayers.Controls)
            {
                player.lblItem1Result.ForeColor = chkForceFlashlight.Checked ? Color.Gold : Color.LightGreen;

                player.lblItem2.Visible = player.lblItem2Result.Visible = numItemsPerPlayers.Value >= 2;
                player.lblItem3.Visible = player.lblItem3Result.Visible = numItemsPerPlayers.Value >= 3;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Upgrade();

            ucPlayer1.lblPlayerNumber.Text = "Player 1";
            ucPlayer2.lblPlayerNumber.Text = "Player 2";
            ucPlayer3.lblPlayerNumber.Text = "Player 3";
            ucPlayer4.lblPlayerNumber.Text = "Player 4";

            string strQuantities = Properties.Settings.Default.Quantities;
            int[] quantities = null;

            if (!String.IsNullOrEmpty(strQuantities))
            {
                quantities = strQuantities.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

                for (int i = 0; i < quantities.Length; i++)
                {
                    this.AllItems[i].MaxQty = quantities[i];
                }
            }

            for (int i = 0; i < AllItems.Count; i++)
            {
                Label lbl = new Label() { Text = AllItems[i].Name, ForeColor = Color.White };
                NumericUpDown num = new NumericUpDown()
                {
                    TextAlign = HorizontalAlignment.Center,
                    Width = 50,
                    BackColor = Color.FromArgb(60, 60, 60),
                    ForeColor = Color.White,
                    Minimum = 0,
                    Maximum = AllItems[i].DefaultMaxQty,
                    Value = AllItems[i].MaxQty,
                    Tag = i
                };

                tblItems.Controls.Add(lbl);
                tblItems.Controls.Add(num);

                this.ItemNums.Add(num);
            }

            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text += " " + version.ToString();
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
    }
}
