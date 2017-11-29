using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void AddToolDetails(Tool_Details obj)
        {
            
                ToolContext t_obj = new ToolContext();
                t_obj.Tool_detail.Add(obj);
                t_obj.SaveChanges();
           
        }

        public void DeleteToolDetails(Tool_Details obj)
        {
            ToolContext t_obj = new ToolContext();
            var t = (from tool in t_obj.Tool_detail
                     where tool.tool_id == obj.tool_id
                     select tool).First();
            t_obj.Tool_detail.Remove(t);
            t_obj.SaveChanges();
        }

        public List<Tool_Details> GetToolDetails()
        {
            List<Tool_Details> li = new List<Tool_Details>();
            ToolContext t_obj = new ToolContext();
            li = t_obj.Tool_detail.ToList();
            return li;
        }

        public void UpdateToolDetails(Tool_Details obj)
        {
            ToolContext t_obj = new ToolContext();
            var t = (from tool in t_obj.Tool_detail
                     where tool.tool_id == obj.tool_id
                     select tool).First();

            t.tool_name = obj.tool_name;
            t.tool_size = obj.tool_size;
            t.tool_type = obj.tool_type;
            t.tool_desc = obj.tool_desc;

            t_obj.SaveChanges();
        }
    }
}
