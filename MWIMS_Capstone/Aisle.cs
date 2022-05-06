/*
 * Aisle instances contain Row instances, which they themselves contain Item instances.
*/

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MWIMS_Capstone {
    
    [DataContract(Name = "Aisle")]
    class Aisle {

        //Fields
        [DataMember]
        private int aisleNumber;
        [DataMember]
        private int length; //in feet
        [DataMember]
        private List<Row> rows = new();

        //Constructor
        public Aisle(int aisleNumber, int length) {
            this.aisleNumber = aisleNumber;
            this.length = length * 12; //convert feet to inches
        }

        //Get Set Methods
        public int AisleNumber {
            get { return aisleNumber; }
            set { aisleNumber = value; }
        }
        public int Lenght {
            get { return length; }
            set { length = value; }
        }
        public List<Row> Rows {
            get { return rows; }
            set { rows = value; }
        }
    }
}
