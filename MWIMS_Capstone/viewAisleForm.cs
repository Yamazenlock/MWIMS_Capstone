/*
 * A form to view the items in an Aisle
*/

using System;
using System.Windows.Forms;

namespace MWIMS_Capstone {
    public partial class viewAisleForm : Form {
        public viewAisleForm() {
            InitializeComponent();
        }

        private void ViewAisleForm_Load(object sender, EventArgs e) {
            //Populate removeAisleListBox with aisles in List<Aisle> aisles
            for (int i = 0; i < Warehouse.Aisles.Count; i++) {
                aislesListBox.Items.Add(Warehouse.Aisles[i].AisleNumber);
            }
        }

        private void AislesListBox_SelectedIndexChanged(object sender, EventArgs e) {
            itemsListView.Items.Clear();
            //Populate Items to itemsListView
            int i = Convert.ToInt32(aislesListBox.SelectedItem) - 1;
            for (int j = 0; j < Warehouse.Aisles[i].Rows.Count; j++) { //loop through rows list
                for (int k = 0; k < Warehouse.Aisles[i].Rows[j].Items.Count; k++) { //loop through items list
                    string[] itemsListViewRow = { Warehouse.Aisles[i].Rows[j].Items[k].Id.ToString(), Warehouse.Aisles[i].Rows[j].Items[k].Name,
                        Warehouse.Aisles[i].Rows[j].Items[k].Manufacturer, Warehouse.Aisles[i].Rows[j].Items[k].Location[0].ToString(), Warehouse.Aisles[i].Rows[j].Items[k].Location[1].ToString() };
                    itemsListView.Items.Add(new ListViewItem(itemsListViewRow));
                }
            }
        }
    }
}
