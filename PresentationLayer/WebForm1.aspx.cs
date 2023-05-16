using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
//using System.Windows.Forms;//Why is there an error
namespace PresentationLayer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BusinessLayerClass businessLayerClass = new BusinessLayerClass();

        public object MessageBox { get; private set; }

        protected void readBtn_Click(object sender, EventArgs e)
        {
                List<string> staffs = businessLayerClass.DataToPresentation();
                ListBox1.Items.Clear();
                foreach (string staff in staffs)
                {
                    ListBox1.Items.Add(staff);
                }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void idTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                businessLayerClass.Name =nameTxtbox.Text;
                businessLayerClass.Surname = surnameTxtbox.Text;
                emailTxtbox.Text = businessLayerClass.emailCal().ToString();
                string email = emailTxtbox.Text;
                businessLayerClass.IdNumber = idTxtbox.Text;
                ageTxtbox.Text = businessLayerClass.ageCal().ToString();
                int age = int.Parse(ageTxtbox.Text);
            }
            catch (Exception exception)
            {

                //MessageBox.Show(exception.Message);
            }
        }

        protected void saveBtn_Click(object sender, EventArgs e)
        {
            //businessLayerClass.
            try
            {
                string idnumber = idTxtbox.Text;
                string name = nameTxtbox.Text;
                string surname = surnameTxtbox.Text;
                businessLayerClass.Name = name;
                businessLayerClass.Surname = surname;
                businessLayerClass.IdNumber = idnumber;
                emailTxtbox.Text = businessLayerClass.emailCal().ToString();
                string email = emailTxtbox.Text;
                ageTxtbox.Text = businessLayerClass.ageCal().ToString();
                int age = int.Parse(ageTxtbox.Text);
                businessLayerClass.DataFromPresentation(idnumber, name, surname, email, age);//sends data inserted by the user this method
                //ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Only alert Message');", true);

                alert("Details have been saved");
            }
            catch (Exception exception)
            {

                alert(exception);
            }
        }

        private void alert(Exception exception)
        {
            throw new NotImplementedException();
        }

        private void alert(string v)
        {
            throw new NotImplementedException();
        }

        protected void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxtbox.Text = " ";
            surnameTxtbox.Text = " ";
            emailTxtbox.Text= " ";
            nameTxtbox.Text = " ";
            idTxtbox.Text = " ";
            ageTxtbox.Text = " ";
        }

        protected void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}