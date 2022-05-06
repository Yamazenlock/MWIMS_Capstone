/*
 * Form to add a new item, or add an item from a list of existing items.
*/

using System;
using System.Windows.Forms;

namespace MWIMS_Capstone {
    public partial class AddItemForm : Form {
        public AddItemForm() {
            InitializeComponent();
        }

        private void AddItemForm_Load(object sender, EventArgs e) {
            //Populate Items to itemsListView
            for(int i = 0; i < Warehouse.Aisles.Count; i++) { //loop through aisles list
                for(int j = 0; j < Warehouse.Aisles[i].Rows.Count; j++) { //loop through rows list
                    for(int k = 0; k < Warehouse.Aisles[i].Rows[j].Items.Count; k++) { //loop through items list
                        string[] itemsListViewRow = { Warehouse.Aisles[i].Rows[j].Items[k].Id.ToString(), Warehouse.Aisles[i].Rows[j].Items[k].Name, 
                            Warehouse.Aisles[i].Rows[j].Items[k].Manufacturer, Warehouse.Aisles[i].Rows[j].Items[k].Location[0].ToString(), 
                            Warehouse.Aisles[i].Rows[j].Items[k].Location[1].ToString() };
                        itemsListView.Items.Add(new ListViewItem(itemsListViewRow));
                    }
                }
            }

            //Add Sizes to sizeListBox
            string[] sizes = { "Twin", "TwinXL", "Full", "Queen", "King" };
            for(int i = 0; i < sizes.Length; i++) {
                sizeListBox.Items.Add(sizes[i]);
            }
            //Add Sizes to palletSizeListBox
            string[] palletSizes = { "Half TwinXL", "TwinXL", "Queen", "King" };
            for (int i = 0; i < palletSizes.Length; i++) {
                palletSizeListBox.Items.Add(palletSizes[i]);
            }
        }

        //Add from existing items
        private void AddItemButton1_Click(object sender, EventArgs e) {
            int itemID = Convert.ToInt32(itemsListView.SelectedItems[0].SubItems[0].Text); //get item id of selected item
            int itemAisle = Convert.ToInt32(itemsListView.SelectedItems[0].SubItems[3].Text);
            int itemRow = Convert.ToInt32(itemsListView.SelectedItems[0].SubItems[4].Text);
            var item = Warehouse.Aisles[itemAisle - 1].Rows[itemRow - 1].Items.Find(item => item.Id == itemID);

            if (item.GetType() == typeof(Mattress)) { //make new mattress item
                for (int i = 0; i < quantityNumericUpDown1.Value; i++) {
                    int[] location = { Convert.ToInt32(aisleLocationTextBox1.Text), Convert.ToInt32(rowLocationTextBox1.Text) };
                    Warehouse.Aisles[Convert.ToInt32(aisleLocationTextBox1.Text) - 1].Rows[Convert.ToInt32(rowLocationTextBox1.Text) - 1].Items.Add
                        (new Mattress(item.Id, item.Name, item.Manufacturer, location, item.Height, item.Width));
                }
            }
            else if (item.GetType() == typeof(Foundation)) { //make a new foundation
                for (int i = 0; i < quantityNumericUpDown1.Value; i++) {
                    int[] location = { Convert.ToInt32(aisleLocationTextBox1.Text), Convert.ToInt32(rowLocationTextBox1.Text) };
                    Warehouse.Aisles[Convert.ToInt32(aisleLocationTextBox1.Text) - 1].Rows[Convert.ToInt32(rowLocationTextBox1.Text) - 1].
                        Items.Add(new Foundation(item.Id, item.Name, item.Manufacturer, location, item.Height, item.Width));
                }
            }
            else if (item.GetType() == typeof(Base)) { //make a new base
                for (int i = 0; i < quantityNumericUpDown1.Value; i++) {
                    int[] location = { Convert.ToInt32(aisleLocationTextBox1.Text), Convert.ToInt32(rowLocationTextBox1.Text) };
                    Warehouse.Aisles[Convert.ToInt32(aisleLocationTextBox1.Text) - 1].Rows[Convert.ToInt32(rowLocationTextBox1.Text) - 1].
                        Items.Add(new Base(item.Id, item.Name, item.Manufacturer, location, item.Height, item.Width));
                }
            }
            else if (item.GetType() == typeof(Accessory)) { //make a new accessory
                for (int i = 0; i < quantityNumericUpDown1.Value; i++) {
                    int[] location = { Convert.ToInt32(aisleLocationTextBox1.Text), Convert.ToInt32(rowLocationTextBox1.Text) };
                    Warehouse.Aisles[Convert.ToInt32(aisleLocationTextBox1.Text) - 1].Rows[Convert.ToInt32(rowLocationTextBox1.Text) - 1].
                        Items.Add(new Accessory(item.Id, item.Name, item.Manufacturer, location, item.Height, item.Width));
                }
            }
        }

        //Add a Mattress or Foundation Item
        private void AddItemButton2_Click(object sender, EventArgs e) {
            //Mattress
            if (mattressRadioButton.Checked) {
                for(int i = 0; i < quantityNumericUpDown2.Value; i++) { //Amount of times object is created, tied to quantityUpDown1.Value
                    int[] location = { Convert.ToInt32(aisleLocationTextBox2.Text), Convert.ToInt32(rowLocationTextBox2.Text) }; //an array for the location of a Foundation, made up of an aisle and row number
                    //The following object creation simplified: Warehous.Aisles[Selected Aisle].Rows[Selected Row].Items.Add a new Mattress
                    Warehouse.Aisles[Convert.ToInt32(aisleLocationTextBox2.Text) - 1].Rows[Convert.ToInt32(rowLocationTextBox2.Text) - 1].Items.Add
                        (new Mattress(Convert.ToInt32(idTextBox1.Text), nameTextBox1.Text, manufacturerTextBox1.Text, 
                        location, sizeListBox.SelectedItem.ToString(), Convert.ToDouble(widthTextBox.Text)));
                }
            }
            //Foundaton
            if (foundationRadioButton.Checked) {
                for (int i = 0; i < quantityNumericUpDown2.Value; i++) {
                    int[] location = { Convert.ToInt32(aisleLocationTextBox2.Text), Convert.ToInt32(rowLocationTextBox2.Text) }; //an array for the location of a Mattress, made up of an aisle and row number
                    //The following object creation simplified: Warehous.Aisles[Selected Aisle].Rows[Selected Row].Items.Add a new Foundation
                    Warehouse.Aisles[Convert.ToInt32(aisleLocationTextBox2.Text) - 1].Rows[Convert.ToInt32(rowLocationTextBox2.Text) - 1].Items.Add
                        (new Foundation(Convert.ToInt32(idTextBox1.Text), nameTextBox1.Text, manufacturerTextBox1.Text, 
                        location, sizeListBox.SelectedItem.ToString(), Convert.ToDouble(widthTextBox.Text)));
                }
            }

        }

        //Add a Base or Accessory Item
        private void AddItemButton3_Click(object sender, EventArgs e) {
            //Base
            if (baseRadioButton.Checked) {
                for (int i = 0; i < quantityNumericUpDown3.Value; i++) {
                    int[] location = { Convert.ToInt32(aisleLocationTextBox3.Text), Convert.ToInt32(rowLocationTexBox3.Text) }; //an array for the location of a Base, made up of an aisle and row number
                    Warehouse.Aisles[Convert.ToInt32(aisleLocationTextBox3.Text) - 1].Rows[Convert.ToInt32(rowLocationTexBox3.Text) - 1].Items.Add
                        (new Base(Convert.ToInt32(idTextBox2.Text), nameTextBox2.Text, manufacturerTextBox2.Text, 
                        location, Convert.ToDouble(palletHeightTextBox.Text), palletSizeListBox.SelectedItem.ToString()));
                }
            }
            //Accessory
            if (accessoryRadioButton.Checked) {
                for(int i = 0; i <  quantityNumericUpDown3.Value; i++) {
                    int[] location = { Convert.ToInt32(aisleLocationTextBox3.Text), Convert.ToInt32(rowLocationTexBox3.Text) }; //an array for the location of an Accessory, made up of an aisle and row number
                    Warehouse.Aisles[Convert.ToInt32(aisleLocationTextBox3.Text) - 1].Rows[Convert.ToInt32(rowLocationTexBox3.Text) - 1].Items.Add
                        (new Accessory(Convert.ToInt32(idTextBox2.Text), nameTextBox2.Text, manufacturerTextBox2.Text, 
                        location, Convert.ToDouble(palletHeightTextBox.Text), palletSizeListBox.SelectedItem.ToString()));
                }
            }
        }

        private void ItemsListView_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
