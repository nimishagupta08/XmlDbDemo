namespace XmlDbDemo
{
    public class AddressDetail
    {
        private int id;
        private int houseNumber;
        private string houseName;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int HouseNumber {
            get { return houseNumber; }
            set { houseNumber = value; } 
        }
        public string HouseName
        {
            get { return houseName; }
            set { houseName = value; }
        }
    }
}