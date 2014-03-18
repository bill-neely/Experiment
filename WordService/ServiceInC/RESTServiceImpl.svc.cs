using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace ServiceInC
{
    [AspNetCompatibilityRequirements
    (RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RESTServiceImpl" in code, svc and config file together.
    public class RESTServiceImpl : IRESTServiceImpl
    {
        public string JSONData(string id)
        {
            
            return "You requested JSON product " + id;
        }

        public string XMLData(string id)
        {

            return "You requested XML product " + id;
        }
    }
}
