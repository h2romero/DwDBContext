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

            ////////// Receive Message //////

            //MessageQueue msgQout = new MessageQueue(".\\Private$\\daycare");

            //DimPersonSCD1 qPerson = new DimPersonSCD1();
            //Object o = new Object();
            //System.Type[] arrTypes = new System.Type[2];
            //arrTypes[0] = qPerson.GetType();
            //arrTypes[1] = o.GetType();
            //msgQout.Formatter = new XmlMessageFormatter(arrTypes);
            //qPerson = (DimPersonSCD1)msgQout.Receive().Body;

            //////////// Update Person object from db   ///////

            //DimPersonSCD1 newPerson = new DimPersonSCD1();
            //using (var dbSmartReportingContext = new SmartReportingDevContext())
            //{
            //    newPerson = dbSmartReportingContext.DimPersonSCD1.Where(p => p.PersonID == qPerson.PersonID).FirstOrDefault<DimPersonSCD1>();
            //}

            //if (newPerson != null)
            //{
            //    newPerson.FirstName = qPerson.FirstName;
            //    newPerson.MiddleName = qPerson.MiddleName;
            //    newPerson.LastName = qPerson.LastName;
            //    newPerson.PreferredName = qPerson.PreferredName;
            //    newPerson.BirthDate = qPerson.BirthDate;
            //    //newPerson.Gender = qPerson.Gender;        // Do not modify Ethnicity for now since lookup is not ready
            //    newPerson.Email = qPerson.Email;
            //    //newPerson.Ethnicity = qPerson.Ethnicity;  // Do not modify Gender for now since lookup is not ready
            //    newPerson.DWUpdateDate = DateTime.Now;

            //    /////// Update db with modified Person object //////////

            //    using (var dbDestSmartReportingContext = new SmartReportingDevContext())
            //    {
            //        dbDestSmartReportingContext.Entry(newPerson).State = System.Data.Entity.EntityState.Modified;
            //        dbDestSmartReportingContext.SaveChanges();
            //    }               

            //}

            // Cancel Update for now since hromero does not have permissions to make changes on DayCare_1
            e.Cancel = true;
        }
    }
}