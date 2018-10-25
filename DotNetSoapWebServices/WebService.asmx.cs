using System.ComponentModel;
using System.Web.Services;

namespace DotNetSoapWebServices
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Add(int x, int y)
        {
            return x + y;
        }

        [WebMethod]
        public int Substract(int x, int y)
        {
            return x - y;
        }

        [WebMethod]
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        [WebMethod]
        public int Division(int x, int y)
        {
            return x / y;
        }
    }
}
