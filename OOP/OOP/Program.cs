using System;

namespace OOP
{
    public class People
    {
        String name;
        String id;
        String country;
        String note;

        //Constructor
        public People() { }
        public People(String name, String id, String country, String note)
        {
            this.name = name;
            this.id = id;
            this.country = country;
            this.note = note;
        }
        //Get & set
        public String Name { get { return name; } set { name = value; } }
        public String Id { get { return id; } set { id = value; } }
        public String Country { get { return country; } set { country = value; } }
        public String Note { get { return note; } set { note = value; } }
        //InputInfor
        public void inputInfor()
        {
            Console.Write("Name: ");
            this.name = Console.ReadLine();
            Console.Write("Id: ");
            this.id = Console.ReadLine();
            Console.Write("Country: ");
            this.country = Console.ReadLine();
            Console.Write("Note: ");
            this.note = Console.ReadLine();
        }
        //ToString method
        public override String ToString()
        {
            return "Name: " + Name
                    + "\nID: " + Id
                    + "\nCountry: " + Country
                    + "\nNote: " + Note;
        }
    }
    public class SV1 : People
    {
        String StudentId;
        //Constructor
        public SV1() { }
        public SV1(string name, string StudentId, string id, string country, string note) : base(name, id, country, note)
        {
            this.StudentId = StudentId;
        }
        //Get & Set
        public String StudentID { get { return StudentId; } set { StudentId = value; } }
        public void setStudent()
        {
            Console.WriteLine("Nhap thong tin sinh vien: ");
            Console.Write("Student ID: ");
            this.StudentID = Console.ReadLine();
            Console.Write("Name: ");
            this.Name = Console.ReadLine();
            Console.Write("Id: ");
            this.Id = Console.ReadLine();
            Console.Write("Country: ");
            this.Country = Console.ReadLine();
            Console.Write("Note: ");
            this.Note = Console.ReadLine();
        }
        public override String ToString()
        {
            return "Name: " + Name
                    + "\nStudentID: " + StudentID
                    + "\nID: " + Id
                    + "\nCountry: " + Country
                    + "\nNote: " + Note;
        }
    }
    public class SV2 : People
    {
        String StudentId;
        String prStudent;
        //Constructor
        public SV2() { }
        public SV2(string name, string StudentId, string id, string country, string note, string prStudent ) : base(name, id, country, note)
        {
            this.StudentId = StudentId;
            this.prStudent = prStudent;
        }
        //Get & Set
        public String StudentID { get { return StudentId; } set { StudentId = value; } }
        public String PrStudent { get { return PrStudent; } set { PrStudent = value; } }
        public void setStudent()
        {
            Console.WriteLine("Nhap thong tin sinh vien: ");
            Console.Write("Student ID: ");
            this.StudentID = Console.ReadLine();
            Console.Write("Name: ");
            this.Name = Console.ReadLine();
            Console.Write("Id: ");
            this.Id = Console.ReadLine();
            Console.Write("Country: ");
            this.Country = Console.ReadLine();
            Console.Write("Note: ");
            this.Note = Console.ReadLine();
            Console.Write("Student private: ");
            this.prStudent = Console.ReadLine();
        }
        public override String ToString()
        {
            return "Name: " + Name
                    + "\nStudentID: " + StudentID
                    + "\nID: " + Id
                    + "\nCountry: " + Country
                    + "\nNote: " + Note
                    + "\nStudent infor: " + prStudent;
        }

    }
    public class Program
    {
        public static void Main(String[] args)
        {
            
            // Student 1
            SV1 sv1 = new SV1();
            sv1.setStudent();
            Console.WriteLine("Thong tin sinh vien: \n");
            Console.WriteLine(sv1.ToString());

            // Student 2
            SV2 sv2 = new SV2();
            sv2.setStudent();
            Console.WriteLine("Thong tin sinh vien: \n");
            Console.WriteLine(sv2.ToString());
            Console.ReadKey();
        }
    }
}

