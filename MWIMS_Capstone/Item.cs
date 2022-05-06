/*
 * Item class defining attributes for all items
*/
using System.Runtime.Serialization;

namespace MWIMS_Capstone {
    [DataContract(Name = "Item")]
    class Item {
        //Constants for size. Integer number assignment denotes height in inches.
        public const int HalfTwinXL = 40;
        public const int Twin = 75;
        public const int TwinXL = 80;
        public const int Full = 75;
        public const int Queen = 80;
        public const int King = 85;

        //Fields
        [DataMember]
        private int id;
        [DataMember]
        private string name;
        [DataMember]
        private string manufacturer;
        [DataMember]
        private double width; //in inches
        [DataMember]
        private double height; //in inches
        [DataMember]
        private int[] location = new int[2]; //{aisle, row}

        //Get Set Methods
        public int Id {
            get { return id; }
            set { id = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Manufacturer {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public double Width {
            get { return width; }
            set { width = value; }
        }
        public double Height {
            get { return height; }
            set { height = value; }
        }
        public int[] Location {
            get { return location; }
            set { location = value; }
        }
    }
}