/*
 * A subclass of Item
*/

using System.Runtime.Serialization;

namespace MWIMS_Capstone {
    [DataContract(Name = "Foundation")]
    [KnownType(typeof(Foundation))]
    class Foundation : Item {
        //Fields
        [DataMember]
        private string size; //Twin, TwinXL. Full, or Queen

        //Constructor
        public Foundation() { }
        public Foundation(int id, string name, string manufacturer, int[] location, string size, double width) {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Location = location;
            this.size = size;
            if(size == "Twin") {
                Height = Twin;
            } else if (size == "TwinXL") {
                Height = TwinXL;
            } else if (size == "Full") {
                Height = Full;
            } else if(size == "Queen") {
                Height = Queen;
            }
            Width = width;
        }
        public Foundation(int id, string name, string manufacturer, int[] location, double height, double width) {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Location = location;
            Height = height;
            Width = width;
        }
        //Get Set Methods
        public string Size {
            get { return size; }
            set { size = value; }
        }
    }
}
