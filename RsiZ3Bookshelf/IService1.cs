using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RsiZ3Bookshelf
{
    //[ServiceContract]
    [ServiceContract]
    public interface IIssueTracker
    {
        [OperationContract]
        int putIssue(Issue issue, String projectName);

        [OperationContract]
        Issue getIssue(int id, String projectName);

        [OperationContract]
        Boolean delete(int id, String projectName);
    }

    [DataContract]
    public class Issue
    {
        String title = "";
        int priority = 0;

        [DataMember]
        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        [DataMember]
        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }
    }
}
