using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace _3.StudentsAndCourses
{
    public partial class StudentsAndCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ArrayList values = new ArrayList();

            values.Add("Math 1");
            values.Add("Math 2");
            values.Add("Production technоlogies");
            values.Add("Macroeconomy");
            values.Add("Statistcis");
            values.Add("Bulgaria History");

            // ListBoxCourses.DataSource = values;
            // ListBoxCourses.DataBind();
        }

        protected void button_Click(object sender, EventArgs e)
        {
            HtmlGenericControl studentDiv = new HtmlGenericControl("div");
            studentDiv.ID = "studentDiv";

            HtmlGenericControl names = new HtmlGenericControl("h1");
            names.InnerText = textBoxFirstName.Text + " " + textBoxLastName.Text;

            HtmlGenericControl facultyNumber = new HtmlGenericControl("div");
            facultyNumber.InnerText = "Faculty Number: " + textBoxFacultyNumber.Text;

            HtmlGenericControl university = new HtmlGenericControl("div");
            university.InnerText = "University: " + DropDownListUniversity.Text;

            HtmlGenericControl specialty = new HtmlGenericControl("div");
            specialty.InnerText = "Specialty: " + DropDownListSpecialty.Text;

            HtmlGenericControl courses = new HtmlGenericControl("ul");
            courses.InnerText = "Courses:";

            for (int i = ListBoxCourses.Items.Count - 1; i >= 0; i--)
            {
                if (ListBoxCourses.Items[i].Selected == true)
                {
                    HtmlGenericControl course = new HtmlGenericControl("li");
                    course.InnerText = ListBoxCourses.Items[i].Text;                    
                    courses.Controls.Add(course);                  
                }
            }

            


            studentDiv.Controls.Add(names);
            studentDiv.Controls.Add(facultyNumber);
            studentDiv.Controls.Add(university);
            studentDiv.Controls.Add(specialty);
            studentDiv.Controls.Add(courses);
            PlaceHolder1.Controls.Add(studentDiv);
        }
    }
}