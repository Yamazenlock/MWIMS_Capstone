/*
 * This form allows the user to add a row to an aisle with a specified height in inches.
 * The user can also delete rows from a specified aisle
*/

using System;
using System.Windows.Forms;

namespace MWIMS_Capstone {
    public partial class ConfigureAisleForm : Form {
        public ConfigureAisleForm() {
            InitializeComponent();
        }

        private void ConfigureAisleForm_Load(object sender, EventArgs e) {
            //Populate configureAisleListBox with aisles in List<Aisle> aisles
            for (int i = 0; i < Warehouse.Aisles.Count; i++) {
                configureAisleListBox.Items.Add(Warehouse.Aisles[i].AisleNumber);
            }
            
            //Update Aisle and Row Numbers
            Warehouse.UpdateAisleAndRowNumbers();
        }

        int i = 0;//used in AddRowButton_Click
        private void AddRowButton_Click(object sender, EventArgs e) {
            //Add Row
            Warehouse.Aisles[Convert.ToInt32(configureAisleListBox.SelectedItem) - 1].Rows.Add(new Row(i + 1, Convert.ToDouble(rowHeightTextbox.Text), 
                Warehouse.Aisles[Convert.ToInt32(configureAisleListBox.SelectedItem) - 1].Lenght));
            i++;
            
            //Update Rows List Box
            rowListBox.Items.Clear();
            foreach (var row in Warehouse.Aisles[Convert.ToInt32(configureAisleListBox.SelectedItem) - 1].Rows) {
                rowListBox.Items.Add(row.RowNumber);
            }
            
            //Update Row Numbers
            Warehouse.UpdateAisleAndRowNumbers();
        }

        private void RemoveRowButton_Click(object sender, EventArgs e) {
            //Remove selected row from List<Column> columns
            Warehouse.Aisles[Convert.ToInt32(configureAisleListBox.SelectedItem) - 1].Rows.RemoveAt(Convert.ToInt32(rowListBox.SelectedItem) - 1);
            
            //Remove selected row from listbox
            rowListBox.Items.Remove(rowListBox.SelectedItem);
            
            //Update Row Numbers
            Warehouse.UpdateAisleAndRowNumbers();
        }

        private void ConfigureAisleListBox_SelectedIndexChanged(object sender, EventArgs e) {
            //Clear rowsListBox
            rowListBox.Items.Clear();
            
            //Populate rowsListBox with rows from selected aisle
            foreach(var row in Warehouse.Aisles[Convert.ToInt32(configureAisleListBox.SelectedItem) - 1].Rows){
                rowListBox.Items.Add(row.RowNumber);
            }
            
            //Update Aisle and Row Numbers
            Warehouse.UpdateAisleAndRowNumbers();
        }
    }
}
