using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace RsiZ3Bookshelf
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.Single)]
    public class IssueTracker : IIssueTracker
    {
        private Dictionary<String, Dictionary<int,Issue>> map = new Dictionary<String, Dictionary<int, Issue>>(); 

        public bool delete(int id, string projectName)
        {
            if (map.ContainsKey(projectName))
            {
                if ((map[projectName]).ContainsKey(id))
                {
                    map[projectName].Remove(id);
                    return true;
                }
            }
            return false;
        }

        public Issue getIssue(int id, string projectName)
        {
            if (map.ContainsKey(projectName))
            {
                if ((map[projectName]).ContainsKey(id))
                {
                    return (map[projectName])[id];
                }
            }
            return null;
        }

        public int putIssue(Issue issue, string projectName)
        {
            int maxId = -1;
            if (!( map.ContainsKey(projectName)))
            {
                map.Add(projectName, new Dictionary<int, Issue>());
            }

            foreach (int key in map[projectName].Keys)
            {
                if (key > maxId)
                {
                    maxId = key;
                }
            }

            maxId += 1;
            map[projectName].Add(maxId, issue);
            
            return maxId;
        }
    }
}
