/*
 * Form to remove an item
*/

using System;
using System.Windows.Forms;

namespace MWIMS_Capstone {
    public partial class removeItemForm : Form {
        public removeItemForm() {
            InitializeComponent();
        }

        private void removeItemForm_Load(object sender, EventArgs e) {
            //Populate Items to itemsListView
            for (int i = 0; i < Warehouse.Aisles.Count; i++) { //loop through aisles list
                for (int j = 0; j < Warehouse.Aisles[i].Rows.Count; j++) { //loop through rows list
                    for (int k = 0; k < Warehouse.Aisles[i].Rows[j].Items.Count; k++) { //loop through items list
                        string[] itemsListViewRow = { Warehouse.Aisles[i].Rows[j].Items[k].Id.ToString(), Warehouse.Aisles[i].Rows[j].Items[k].Name,
                            Warehouse.Aisles[i].Rows[j].Items[k].Manufacturer, Warehouse.Aisles[i].Rows[j].Items[k].Location[0].ToString(), Warehouse.Aisles[i].Rows[j].Items[k].Location[1].ToString() };
                        itemsListView.Items.Add(new ListViewItem(itemsListViewRow));
                    }
                }
            }
        }

        private void removeItemButton_Click(object sender, EventArgs e) {
            int itemID = Convert.ToInt32(itemsListView.SelectedItems[0].SubItems[0].Text); //get item id of selected item
            int itemAisle = Convert.ToInt32(itemsListView.SelectedItems[0].SubItems[3].Text);
            int itemRow = Convert.ToInt32(itemsListView.SelectedItems[0].SubItems[4].Text);

            //Remove item from List<Item>
            var item = Warehouse.Aisles[itemAisle - 1].Rows[itemRow - 1].Items.Find(x => x.Id == itemID);
            Warehouse.Aisles[itemAisle - 1].Rows[itemRow - 1].Items.Remove(item);

            //Remove item from itemsListView
            itemsListView.SelectedItems[0].Remove();
        }
    }
}
