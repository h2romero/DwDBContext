using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Messaging;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DayCareQueueProcessing
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            MessageQueue myQueue = new MessageQueue(".\\Private$\\daycare");

            DimPersonSCD1 qPerson = new DimPersonSCD1();
            Object o = new Object();
            System.Type[] arrTypes = new System.Type[2];
            arrTypes[0] = qPerson.GetType();
            arrTypes[1] = o.GetType();
            myQueue.Formatter = new XmlMessageFormatter(arrTypes);

            myQueue.ReceiveCompleted += new ReceiveCompletedEventHandler(ReceiveCompleted2);

            myQueue.BeginReceive();
        }

        protected override void OnStop()
        {
        }

        private static void ReceiveCompleted2(Object source, ReceiveCompletedEventArgs asyncResult)
        {
            try
            {
                System.Diagnostics.Debugger.Launch();
                MessageQueue mq = (MessageQueue)source;
                Message m = mq.EndReceive(asyncResult.AsyncResult);
                DimPersonSCD1 qPerson = new DimPersonSCD1();
                qPerson = (DimPersonSCD1)m.Body;
                ////////// Update Person object from db   ///////

                DimPersonSCD1 newPerson = new DimPersonSCD1();
                var dbSmartReportingContext = new SmartReportingContext();
                newPerson = dbSmartReportingContext.DimPersonSCD1.Where(p => p.PersonID == qPerson.PersonID).FirstOrDefault<DimPersonSCD1>();
                var dbDestSmartReportingContext = new SmartReportingContext();

                newPerson.FirstName = qPerson.FirstName;
                newPerson.MiddleName = qPerson.MiddleName;
                newPerson.LastName = qPerson.LastName;
                newPerson.PreferredName = qPerson.PreferredName;
                newPerson.BirthDate = qPerson.BirthDate;
                //newPerson.Gender = qPerson.Gender;        // Do not modify Ethnicity for now since lookup is not ready
                newPerson.Email = qPerson.Email;
                //newPerson.Ethnicity = qPerson.Ethnicity;  // Do not modify Gender for now since lookup is not ready
                newPerson.DWUpdateDate = DateTime.Now;

                if (newPerson != null)
                {
                    /////// Update db with modified Person object //////////
                   dbDestSmartReportingContext.Entry(newPerson).State = System.Data.Entity.EntityState.Modified;
                   dbDestSmartReportingContext.SaveChanges();                   
                }
                else
                {
                    // Insert
                    dbDestSmartReportingContext.Entry(newPerson).State = System.Data.Entity.EntityState.Added;
                    dbDestSmartReportingContext.SaveChanges(); 
                }

                // Restart the asynchronous receive operation.
                mq.BeginReceive();
            }
            catch (MessageQueueException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("DayCare Service Error", ex.Message);
            }

            return;
        }

        private static void ReceiveCompleted(Object source, ReceiveCompletedEventArgs asyncResult)
        {
            try
            {
                System.Diagnostics.Debugger.Launch();
                MessageQueue mq = (MessageQueue)source;
                Message m = mq.EndReceive(asyncResult.AsyncResult);
                DimPersonSCD1 qPerson = new DimPersonSCD1();
                qPerson = (DimPersonSCD1)m.Body;
                ////////// Update Person object from db   ///////

                DimPersonSCD1 newPerson = new DimPersonSCD1();
                using (var dbSmartReportingContext = new SmartReportingContext())
                {
                    newPerson = dbSmartReportingContext.DimPersonSCD1.Where(p => p.PersonID == qPerson.PersonID).FirstOrDefault<DimPersonSCD1>();
                }

                if (newPerson != null)
                {
                    newPerson.FirstName = qPerson.FirstName;
                    newPerson.MiddleName = qPerson.MiddleName;
                    newPerson.LastName = qPerson.LastName;
                    newPerson.PreferredName = qPerson.PreferredName;
                    newPerson.BirthDate = qPerson.BirthDate;
                    //newPerson.Gender = qPerson.Gender;        // Do not modify Ethnicity for now since lookup is not ready
                    newPerson.Email = qPerson.Email;
                    //newPerson.Ethnicity = qPerson.Ethnicity;  // Do not modify Gender for now since lookup is not ready
                    newPerson.DWUpdateDate = DateTime.Now;

                    /////// Update db with modified Person object //////////

                    using (var dbDestSmartReportingContext = new SmartReportingContext())
                    {
                        dbDestSmartReportingContext.Entry(newPerson).State = System.Data.Entity.EntityState.Modified;
                        dbDestSmartReportingContext.SaveChanges();
                    }

                }

                // Restart the asynchronous receive operation.
                mq.BeginReceive();
            }
            catch (MessageQueueException ex)
            {
                System.Diagnostics.EventLog.WriteEntry("DayCare Service Error", ex.Message); 
            }

            return;
        }

    }
}
