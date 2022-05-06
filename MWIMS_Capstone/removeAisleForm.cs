/*
 * Form to remove a selected Aisle
*/

using System;
using System.Windows.Forms;

namespace MWIMS_Capstone {
    public partial class removeAisleForm : Form {
        public removeAisleForm() {
            InitializeComponent();
        }

        private void RemoveAisleForm_Load(object sender, EventArgs e) {
            //Populate removeAisleListBox with aisles in List<Aisle> aisles
            for(int i = 0; i < Warehouse.Aisles.Count; i++) {
                removeAisleListBox.Items.Add(Warehouse.Aisles[i].AisleNumber);
            }
        }

        private void RemoveAisle_Click(object sender, EventArgs e) {
            //Remove aisle from List<Aisle> aisles
            Warehouse.Aisles.RemoveAt(Convert.ToInt32(removeAisleListBox.SelectedItem) - 1);
            //Remove selected aisle from listbox
            removeAisleListBox.Items.Remove(removeAisleListBox.SelectedItem);

        }
    }
}
