using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhasmoRandomizer
{
    public partial class ucPlayer : UserControl
    {
        private List<ucItem> ItemControls = new List<ucItem>();
        public int PlayerIndex { get; private set; }

        public ucPlayer()
        {
            InitializeComponent();
        }

        public ucPlayer(int playerIndex) : this()
        {
            this.PlayerIndex = playerIndex;
            lblPlayerNumber.Text = $"Player {this.PlayerIndex + 1}";
        }

        public void UpdateUI()
        {
            if (this.PlayerIndex < Randomizer.NbPlayers)
            {
                this.Visible = true;
                foreach (var ctrl in this.ItemControls)
                    ctrl.UpdateUI();
            }
            else
                this.Visible = false;
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Randomizer.NbItemsPerPlayer; i++)
            {
                if (Randomizer.SelectedItems[this.PlayerIndex][i] >= 0)
                {
                    Item.AllItems[Randomizer.SelectedItems[this.PlayerIndex][i]].QtyLeft++;
                    Randomizer.SelectedItems[this.PlayerIndex][i] = -1;
                }
            }

            Randomizer.Randomize(Randomizer.SelectedItems[this.PlayerIndex]);
            this.UpdateUI();
        }

        private void ucPlayer_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                ucItem ucItem = new ucItem(this, i);
                panItems.Controls.Add(ucItem);
                ucItem.Dock = DockStyle.Top;
                ucItem.BringToFront();
                ItemControls.Add(ucItem);
            }
        }
    }
}
