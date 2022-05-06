/*
 * A form to move an item from one location to another. Aisle and row location of the item can be changed.
*/

using System;
using System.Windows.Forms;

namespace MWIMS_Capstone {
    public partial class moveItemForm : Form {
        public moveItemForm() {
            InitializeComponent();
        }

        private void removeItemButton_Click(object sender, EventArgs e) {
            //Moving an item will involve creating a new exact copy of the item to the new aisle and row locations,
            //then removing the original item from the old location

            //Create new copy
            int copyItemID = Convert.ToInt32(itemsListView.SelectedItems[0].SubItems[0].Text); //get item id of selected item
            int copyItemAisle = Convert.ToInt32(itemsListView.SelectedItems[0].SubItems[3].Text);
            int copyItemRow = Convert.ToInt32(itemsListView.SelectedItems[0].SubItems[4].Text);
            var copyItem = Warehouse.Aisles[copyItemAisle - 1].Rows[copyItemRow - 1].Items.Find(item => item.Id == copyItemID);

            if (copyItem.GetType() == typeof(Mattress)) { //make new mattress item
                int[] location = { Convert.ToInt32(newAisleTextBox.Text), Convert.ToInt32(newRowTextBox.Text) };
                Warehouse.Aisles[Convert.ToInt32(newAisleTextBox.Text) - 1].Rows[Convert.ToInt32(newRowTextBox.Text) - 1].Items.Add
                    (new Mattress(copyItem.Id, copyItem.Name, copyItem.Manufacturer, location, copyItem.Height, copyItem.Width));
            }
            else if (copyItem.GetType() == typeof(Foundation)) { //make a new foundation
                int[] location = { Convert.ToInt32(newAisleTextBox.Text), Convert.ToInt32(newRowTextBox.Text) };
                Warehouse.Aisles[Convert.ToInt32(newAisleTextBox.Text) - 1].Rows[Convert.ToInt32(newRowTextBox.Text) - 1].
                    Items.Add(new Foundation(copyItem.Id, copyItem.Name, copyItem.Manufacturer, location, copyItem.Height, copyItem.Width));
            }
            else if (copyItem.GetType() == typeof(Base)) { //make a new base
                int[] location = { Convert.ToInt32(newAisleTextBox.Text), Convert.ToInt32(newRowTextBox.Text) };
                Warehouse.Aisles[Convert.ToInt32(newAisleTextBox.Text) - 1].Rows[Convert.ToInt32(newRowTextBox.Text) - 1].
                    Items.Add(new Base(copyItem.Id, copyItem.Name, copyItem.Manufacturer, location, copyItem.Height, copyItem.Width));
            }
            else if (copyItem.GetType() == typeof(Accessory)) { //make a new accessory
                int[] location = { Convert.ToInt32(newAisleTextBox.Text), Convert.ToInt32(newRowTextBox.Text) };
                Warehouse.Aisles[Convert.ToInt32(newAisleTextBox.Text) - 1].Rows[Convert.ToInt32(newRowTextBox.Text) - 1].
                    Items.Add(new Accessory(copyItem.Id, copyItem.Name, copyItem.Manufacturer, location, copyItem.Height, copyItem.Width));
            }

            //Remove original item
            int oldItemID = Convert.ToInt32(itemsListView.SelectedItems[0].SubItems[0].Text); //get item id of selected item
            int oldItemAisle = Convert.ToInt32(itemsListView.SelectedItems[0].SubItems[3].Text);
            int oldItemRow = Convert.ToInt32(itemsListView.SelectedItems[0].SubItems[4].Text);

            //Remove item from List<Item>
            var item = Warehouse.Aisles[oldItemAisle - 1].Rows[oldItemRow - 1].Items.Find(x => x.Id == oldItemID);
            Warehouse.Aisles[oldItemAisle - 1].Rows[oldItemRow - 1].Items.Remove(item);

            //Remove item from itemsListView
            itemsListView.SelectedItems[0].Remove();

            //Update Items List View
            for (int i = 0; i < Warehouse.Aisles.Count; i++) { //loop through aisles list
                for (int j = 0; j < Warehouse.Aisles[i].Rows.Count; j++) { //loop through rows list
                    for (int k = 0; k < Warehouse.Aisles[i].Rows[j].Items.Count; k++) { //loop through items list
                        string[] itemsListViewRow = { Warehouse.Aisles[i].Rows[j].Items[k].Id.ToString(), Warehouse.Aisles[i].Rows[j].Items[k].Name,
                            Warehouse.Aisles[i].Rows[j].Items[k].Manufacturer, Warehouse.Aisles[i].Rows[j].Items[k].Location[0].ToString(),
                            Warehouse.Aisles[i].Rows[j].Items[k].Location[1].ToString() };
                        itemsListView.Items.Add(new ListViewItem(itemsListViewRow));
                    }
                }
            }
        }

        private void moveItemForm_Load(object sender, EventArgs e) {
            //Populate Items to itemsListView
            for (int i = 0; i < Warehouse.Aisles.Count; i++) { //loop through aisles list
                for (int j = 0; j < Warehouse.Aisles[i].Rows.Count; j++) { //loop through rows list
                    for (int k = 0; k < Warehouse.Aisles[i].Rows[j].Items.Count; k++) { //loop through items list
                        string[] itemsListViewRow = { Warehouse.Aisles[i].Rows[j].Items[k].Id.ToString(), Warehouse.Aisles[i].Rows[j].Items[k].Name,
                            Warehouse.Aisles[i].Rows[j].Items[k].Manufacturer, Warehouse.Aisles[i].Rows[j].Items[k].Location[0].ToString(), 
                            Warehouse.Aisles[i].Rows[j].Items[k].Location[1].ToString() };
                        itemsListView.Items.Add(new ListViewItem(itemsListViewRow));
                    }
                }
            }
        }
    }
}
