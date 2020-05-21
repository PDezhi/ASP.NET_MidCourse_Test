using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStoreWeb
{
    public partial class BrowserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get Brower information form from within the Page
            lblBrowerInInfo.Text = GetBrowerInformation();

            // get Brower information form from Outside the Page
            Basic basic = new Basic();
            lblBrowerOutInfo.Text = basic.GetBrowerInfo();

        }


        private string GetBrowerInformation()
        {
            StringBuilder sbText = new StringBuilder();
            // Get the reference to the HttpBrowserCapabilities object 
            HttpBrowserCapabilities browser = Request.Browser;

            // Display the properties of the HttpBrowserCapabilities Class
            sbText.AppendFormat("Use the Request object from within the Page." + "<br>");
            sbText.AppendFormat("Browser : " + browser.Browser + "<br>");
            sbText.AppendFormat("Browser Version: " + browser.Version + "<br>");
            sbText.AppendFormat("Client's Platform: " + browser.Platform + "<br>");
            sbText.AppendFormat(".NET CLR Version: " + browser.ClrVersion + "<br>");
            sbText.AppendFormat("ECMA Script Version: " + browser.EcmaScriptVersion + "<br>");
            sbText.AppendFormat("JavaScript Support: " + browser.JavaScript + "<br>");
            sbText.AppendFormat("Microsoft HTML Document Object Model Version: " + browser.MSDomVersion + "<br>");
            sbText.AppendFormat("World Wide Web (W3C) XML Document " + " Object Model Version: " + browser.W3CDomVersion + "<br><br><br><br>");
            return sbText.ToString();
        }
    }
}