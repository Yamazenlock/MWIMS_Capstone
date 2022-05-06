using System;
using System.Windows.Forms;

namespace MWIMS_Capstone {
    public partial class HomeForm : Form {
        public HomeForm() {
            InitializeComponent();
        }

        //Home Form Buttons
        private void AisleManagementTabButton_Click(object sender, EventArgs e) {
            tabControl.SelectedTab = aisleManagementTab;
        }
        private void ItemManagementTabButton_Click(object sender, EventArgs e) {
            tabControl.SelectedTab = itemManagementTab;
        }
        private void ItemSearchTabButton_Click(object sender, EventArgs e) {
            tabControl.SelectedTab = itemSearchTab;
        }
        
        //Aisle Management Tab Buttons
        private void AisleManagementHomeButton_Click(object sender, EventArgs e) {
            tabControl.SelectedTab = homeTab;
        }
        private void AddAisleFormButton_Click(object sender, EventArgs e) {
            AddAisleForm addAisleForm = new();
            addAisleForm.Show();
        }
        private void RemoveAisleFormButton_Click(object sender, EventArgs e) {
            removeAisleForm removeAisleForm = new();
            removeAisleForm.Show();
        }
        private void ConfigureAisleFormButton_Click(object sender, EventArgs e) {
            ConfigureAisleForm configureAisleForm = new();
            configureAisleForm.Show();
        }
        private void ViewAisleFormButton_Click(object sender, EventArgs e) {
            viewAisleForm viewAisleForm = new();
            viewAisleForm.Show();
        }

        //Item Management Tab Buttons
        private void ItemManagementHomeButton_Click(object sender, EventArgs e) {
            tabControl.SelectedTab = homeTab;
        }
        private void AddItemFormButton_Click(object sender, EventArgs e) {
            AddItemForm addItemForm = new();
            addItemForm.Show();
        }
        private void RemoveItemFormButton_Click(object sender, EventArgs e) {
            removeItemForm removeItemForm = new();
            removeItemForm.Show();
        }
        private void MoveItemFormButton_Click(object sender, EventArgs e) {
            moveItemForm moveItemForm = new();
            moveItemForm.Show();
        }
        
        //Item Search Tab Buttons
        private void ItemSearchHomeButton_Click(object sender, EventArgs e) {
            tabControl.SelectedTab = homeTab;
        }
    }
}
