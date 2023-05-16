using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class BusinessLayerClass
    {
        public BusinessLayerClass() { }
        DataLayerClass dataLayerClass = new DataLayerClass();
        string name, surname, email, idnumber;
        int age;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Surname
        {
            set { surname = value; }
            get { return surname; }
        }
        public string IdNumber
        {
            set { idnumber = value; }
            get { return idnumber; }
        }
        public void DataFromPresentation(string idnumber, string name, string surname, string email, int age)
        {
            dataLayerClass.InsertToTable(idnumber, name, surname, email, age);//inserts the data from the presentation and sends it to datalayer into the table
        }
        public string emailCal()//why cant i do this without the getters and setters 
        {
            return (string.Concat(name + surname + "@gmail.com"));
        }
        public int ageCal()//how come you dont have to pass int idnumber
        {
            string idYear = idnumber.Substring(0, 2);
            if (int.Parse(idYear) > int.Parse(DateTime.Now.Year.ToString().Substring(2)))//Turning idyear to an int because substring requries a string then using a method that takes todays day taking the substring of first two digits
            {
                idYear = "19" + idYear;
            }
            else
            {
                idYear = "20" + idYear;
            }
            int thisyear = DateTime.Now.Year; //showing what year we are in 
            int yourYear = int.Parse(idYear);//converting your year into int for calculation
            int age = thisyear - yourYear;
            return age;
        }
        public List<string> DataToPresentation()
        {
            List<string> staffs = new List<string>();
            DataTable table = dataLayerClass.SelectTable();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string row = "";
                var rows = table.Rows[i].ItemArray;
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    row += rows[j] + "; ";
                }
                staffs.Add(row);
            }
            return staffs;

        }
    }
}