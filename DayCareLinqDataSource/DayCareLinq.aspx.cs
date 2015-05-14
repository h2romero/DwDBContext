using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DayCareLinqDataSource.Models;

namespace DayCareLinqDataSource
{
    public partial class DayCareLinq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            //int id = Int32.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
            var tGuid = GridView1.DataKeys[e.RowIndex].Value.ToString();
            var tEthnicity = ((TextBox)row.FindControl("Ethnicity")).Text.Trim();
            var tFirstName = ((TextBox)row.FindControl("FirstName")).Text.Trim();
            var tMiddleName = ((TextBox)row.FindControl("MiddleName")).Text.Trim();
            var tLastName = ((TextBox)row.FindControl("LastName")).Text.Trim();
            var tPreferredName = ((TextBox)row.FindControl("PreferredName")).Text.Trim();
            var tBirthDate = DateTime.Parse(((TextBox)row.FindControl("BirthDate")).Text.Trim());
            var tGender = ((TextBox)row.FindControl("Ethnicity")).Text.Trim();
            var tEmail = ((TextBox)row.FindControl("Email")).Text.Trim();
            var tDateCreated = ((TextBox)row.FindControl("DateCreated")).Text.Trim();

            DimPersonSCD1 person = new DimPersonSCD1();
            using (var dbSmartReportingContext = new SmartReportingDevContext())
            {
                person = dbSmartReportingContext.DimPersonSCD1.Where(p => p.PersonID == tGuid).FirstOrDefault<DimPersonSCD1>();
            }

            if (person != null)
            {
                person.FirstName = tFirstName;
                person.MiddleName = tMiddleName;
                person.LastName = tLastName;
                person.PreferredName = tPreferredName;
                person.BirthDate = tBirthDate;
                person.Gender = tGender;
                person.Email = tEmail;
                person.Ethnicity = tEthnicity;
                person.DWUpdateDate = DateTime.Now;

                using (var dbDestSmartReportingContext = new SmartReportingDevContext())
                {
                    dbDestSmartReportingContext.Entry(person).State = System.Data.Entity.EntityState.Modified;
                    dbDestSmartReportingContext.SaveChanges();
                }
            }

           
        }
    }
}