using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module1Exercise1
{
    public partial class Exercise3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                finalGrade.Text = "Submit your grade percentage to see your final grade!";


            }



            // TODO 3.3 Set the text value of the finalGrade label to "Submit your grade percentage to see your final grade!". Watch out for post backs
        }

        protected void calculate(object sender, EventArgs e)
        {
              double initial_grade = double.Parse(percentageGrade.Text);
              double final_grade=0;
              if (initial_grade <= 59.99)
            {
                final_grade = 5.00;
            }

            if (initial_grade >= 60 || initial_grade >=64.50)
            {
                final_grade = 3.00;
            }

            if (initial_grade >=64.51  || initial_grade >= 69.01)
            {
                final_grade = 2.75;
            }

            if (initial_grade >=69.02 || initial_grade >= 73.50) {

                final_grade = 2.50;
            
            }

            if (initial_grade >= 73.51 || initial_grade >= 78.00)
            {
                final_grade = 2.25;
            }

            if (initial_grade >= 78.01 || initial_grade >= 82.50)
            {
                final_grade = 2.00 ;
            }

            if (initial_grade >= 82.51 || initial_grade >= 87.00)
            {

                final_grade = 1.75;

            }

            if (initial_grade >= 87.01 || initial_grade >= 91.50)
            {

                final_grade = 1.50;

            }

            if (initial_grade >= 91.51 || initial_grade >= 96.00)
            {

                final_grade = 1.25;

            }
            if (initial_grade > 96.00)
            {
                final_grade = 1.00;
                Response.Write($"<script> alert('Congrats boy')</script>");
            }


            finalGrade.Text = final_grade.ToString();
        }
    }
}