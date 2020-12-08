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
    public partial class ucItem : UserControl
    {
        private ucPlayer ParentPlayerControl { get; set; }
        private int ItemIndex { get; set; }
        private int ItemId { get { return Randomizer.SelectedItems[this.ParentPlayerControl.PlayerIndex][this.ItemIndex]; } }

        public ucItem()
        {
            InitializeComponent();
        }

        public ucItem(ucPlayer parent, int itemIndex) : this()
        {
            this.ParentPlayerControl = parent;
            this.ItemIndex = itemIndex;

            lblItemPos.Text = $"Item {this.ItemIndex + 1}";
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            if (this.ItemId >= 0)
                Item.AllItems[this.ItemId].QtyLeft++;

            Randomizer.SelectedItems[this.ParentPlayerControl.PlayerIndex][this.ItemIndex] = -1;
            Randomizer.Randomize(Randomizer.SelectedItems[this.ParentPlayerControl.PlayerIndex]);

            this.UpdateUI();
        }

        public void UpdateUI()
        {
            if (this.ItemIndex < Randomizer.NbItemsPerPlayer)
            {
                this.Visible = true;
                lblItemResult.Text = this.ItemId < 0 ? String.Empty : Item.AllItems[this.ItemId].Name;
            }
            else
                this.Visible = false;    
        }
    }
}
