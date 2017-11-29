using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Tool_Details> GetToolDetails();

        [OperationContract]
        void UpdateToolDetails(Tool_Details obj);

        [OperationContract]
        void AddToolDetails(Tool_Details obj);

        [OperationContract]
        void DeleteToolDetails(Tool_Details obj);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    
    [DataContract]
     public class Tool_Details
    {
        [DataMember]
        [Key]
        public string tool_id { get; set; }
        [DataMember]
        public string tool_name { get; set;}
        [DataMember]
        public string tool_size { get; set; }
        [DataMember]
        public string tool_type { get; set; }
        [DataMember]
        public string tool_desc { get; set; }
    }
}
