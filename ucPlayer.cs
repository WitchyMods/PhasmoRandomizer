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
        private string _PlayerName = string.Empty;

        private List<ucItem> ItemControls = new List<ucItem>();
        public int PlayerIndex { get; private set; }

        public ucPlayer()
        {
            InitializeComponent();
        }

        public ucPlayer(int playerIndex) : this()
        {
            this.PlayerIndex = playerIndex;
            UpdatePlayerName();
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
            for (int i = 0; i < 6; i++)
            {
                ucItem ucItem = new ucItem(this, i);
                panItems.Controls.Add(ucItem);
                ucItem.Dock = DockStyle.Top;
                ucItem.BringToFront();
                ItemControls.Add(ucItem);
            }
        }

        private void txtPlayerName_Leave(object sender, EventArgs e)
        {
            _PlayerName = txtPlayerName.Text.Trim();
            UpdatePlayerName();
        }

        private void txtPlayerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)(int)Keys.Enter)
            {
                _PlayerName = txtPlayerName.Text.Trim();
                UpdatePlayerName();
            }
        }

        private void lblPlayerNumber_Click(object sender, EventArgs e)
        {
            lblPlayerNumber.Visible = false;
            txtPlayerName.Visible = true;
            txtPlayerName.Select();
            txtPlayerName.Focus();
        }

        private void UpdatePlayerName()
        {
            lblPlayerNumber.Visible = true;
            txtPlayerName.Visible = false;

            if (String.IsNullOrEmpty(_PlayerName))
                lblPlayerNumber.Text = $"Player {this.PlayerIndex + 1}";
            else
                lblPlayerNumber.Text = _PlayerName;
        }
    }
}
