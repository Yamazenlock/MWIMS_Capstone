/*
 * Subclass of Item
*/

using System.Runtime.Serialization;

namespace MWIMS_Capstone {
    [DataContract(Name = "Accessory")]
    [KnownType(typeof(Accessory))]
    class Accessory : Item {

        //Constructors
        public Accessory() { }
        public Accessory(int id, string name, string manufacturer, int[] location, double height, string palletSize) {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Location = location;
            Height = height;
            if (palletSize == "Half TwinXL") {
                Width = HalfTwinXL;
            }
            else if (palletSize == "TwinXL") {
                Width = TwinXL;
            }
            else if (palletSize == "Queen") {
                Width = Queen;
            }
            else if (palletSize == "King") {
                Width = King;
            }
        }
        public Accessory(int id, string name, string manufacturer, int[] location, double height, double width) {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Location = location;
            Height = height;
            Width = width;
        }
    }
}
