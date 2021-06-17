namespace XmlDbDemo
{
    public class Department
    {
        private int id;

        private int departmentId;
        private string departmentName;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
    }
}