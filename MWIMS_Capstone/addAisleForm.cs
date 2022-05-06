/*
 * This form adds an aisle with a specified lenght in feet
*/
using System;
using System.Windows.Forms;

namespace MWIMS_Capstone {
    public partial class AddAisleForm : Form {
        public AddAisleForm() {
            InitializeComponent();
        }

        int i = 0; //used in AddAisleFormButton_Click
        private void AddAisleButton_Click(object sender, EventArgs e) {
            //Add Aisle
            Warehouse.Aisles.Add(new Aisle(i + 1, Convert.ToInt32(lengthTextBox.Text)));
            i++;
            //Update Aisle Numbers
            Warehouse.UpdateAisleAndRowNumbers();
        }
    }
}
