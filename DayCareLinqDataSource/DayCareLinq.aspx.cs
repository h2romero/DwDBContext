using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DayCareLinqDataSource.Models;
using System.Messaging;

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
            person.PersonID = tGuid;
            person.FirstName = tFirstName;
            person.MiddleName = tMiddleName;
            person.LastName = tLastName;
            person.PreferredName = tPreferredName;
            person.BirthDate = tBirthDate;
            person.Gender = tGender;
            person.Email = tEmail;
            person.Ethnicity = tEthnicity;
            person.DWUpdateDate = DateTime.Now;

            //////// Create Message //////

            System.Messaging.Message msg = new System.Messaging.Message();
            msg.Body = person;

            MessageQueue msgQin = new MessageQueue(".\\Private$\\daycare");
            msgQin.Send(msg);

            //////// Receive Message //////

            MessageQueue msgQout = new MessageQueue(".\\Private$\\daycare");

            DimPersonSCD1 qPerson = new DimPersonSCD1();
            Object o = new Object();
            System.Type[] arrTypes = new System.Type[2];
            arrTypes[0] = qPerson.GetType();
            arrTypes[1] = o.GetType();
            msgQout.Formatter = new XmlMessageFormatter(arrTypes);
            qPerson = (DimPersonSCD1)msgQout.Receive().Body;

            ////////// Update Person object from db   ///////

            DimPersonSCD1 newPerson = new DimPersonSCD1();
            bool personExists = false;
            var dbSmartReportingContext = new SmartReportingDevContext();
            newPerson = dbSmartReportingContext.DimPersonSCD1.Where(p => p.PersonID == qPerson.PersonID).FirstOrDefault<DimPersonSCD1>();
            personExists = newPerson != null;
            if (!personExists)
                newPerson = new DimPersonSCD1();
            var dbDestSmartReportingContext = new SmartReportingDevContext();

            newPerson.FirstName = qPerson.FirstName;
            newPerson.MiddleName = qPerson.MiddleName;
            newPerson.LastName = qPerson.LastName;
            newPerson.PreferredName = qPerson.PreferredName;
            newPerson.BirthDate = qPerson.BirthDate;
            //newPerson.Gender = qPerson.Gender;        // Do not modify Ethnicity for now since lookup is not ready
            newPerson.Email = qPerson.Email;
            //newPerson.Ethnicity = qPerson.Ethnicity;  // Do not modify Gender for now since lookup is not ready
            

            if (personExists)
            {
                // Update 
                newPerson.DWUpdateDate = DateTime.Now;
                dbDestSmartReportingContext.Entry(newPerson).State = System.Data.Entity.EntityState.Modified;
                dbDestSmartReportingContext.SaveChanges();                
            }
            else
            {
                // Add
                newPerson.PersonID = qPerson.PersonID;
                newPerson.DWInsertDate = DateTime.Now;
                dbDestSmartReportingContext.Entry(newPerson).State = System.Data.Entity.EntityState.Added;
                dbDestSmartReportingContext.SaveChanges();
            }

            // Cancel Update for now since hromero does not have permissions to make changes on DayCare_1
            e.Cancel = true;
        }
    }
}