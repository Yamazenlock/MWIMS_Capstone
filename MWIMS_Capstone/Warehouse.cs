/*
 * This Warehouse Class acts as the "Warehouse" for the Management System. 
 * The Warehouse contains Aisles which in turn contains all the rows and items in the inventory
 * The 
*/
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MWIMS_Capstone {

    [DataContract(Name = "Warehouse")]
    class Warehouse {
       //List of Aisles
       private static List<Aisle> aisles = new();

       //Get Set Methods
       public static List<Aisle> Aisles {
            get { return aisles; }
            set { aisles = value; }
        }

        //Update Aisle and Row Numbers
        public static void UpdateAisleAndRowNumbers() {
            for (int i = 0; i < Aisles.Count; i++) {//aisles
                Aisles[i].AisleNumber = i + 1;
            }
            for (int i = 0; i < Aisles.Count; i++) {//rows
                for(int j = 0; j < Aisles[i].Rows.Count; j++) {
                    Aisles[i].Rows[j].RowNumber = j + 1;
                }
            }
        }
    }
}
