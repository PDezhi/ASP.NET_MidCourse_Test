using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace PetStoreWeb
{
    public class Basic
    {
        public string GetBrowerInfo()
        {
            StringBuilder sbText = new StringBuilder();

            // Get the reference to the HttpBrowserCapabilities object 
            HttpBrowserCapabilities browser = System.Web.HttpContext.Current.Request.Browser;

            // Display the properties of the HttpBrowserCapabilities Class
            sbText.AppendFormat("Use the Request object from Outside the Page from a basic .cs class." + "<br>");
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