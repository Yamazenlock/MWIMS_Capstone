/*
 * Row instances hold Item instances
*/

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MWIMS_Capstone {
    
    [DataContract(Name = "Row")]
    class Row {
        //Fields
        [DataMember]
        private int rowNumber;
        [DataMember]
        private double height; //in inches
        [DataMember]
        private double length;
        [DataMember]
        private List<Item> items = new();

        //Constructor
        public Row(int rowNumber, double height, double length) {
            this.rowNumber = rowNumber;
            this.height = height;
            this.length = length;
        }

        //Get Set Methods
        public int RowNumber {
            get { return rowNumber; }
            set { rowNumber = value; }
        }
        public double Height {
            get { return height; }
            set { height = value; }
        }
        public double Length {
            get { return length; }
            set { length = value; }
        }
        public List<Item> Items {
            get { return items; }
            set { items = value; }
        }
    }
}
