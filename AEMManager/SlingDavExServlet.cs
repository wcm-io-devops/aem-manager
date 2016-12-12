using System;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Web;
using System.Windows.Forms;

namespace AEMManager {

  public class SlingDavExServlet {

    private readonly AemInstance instance;

    private static readonly log4net.ILog mLog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public SlingDavExServlet(AemInstance instance) {
      this.instance = instance;
    }

    /// <summary>
    /// Make sure DAvEx servlet is enabled, and ask user to enable it if this is not the case.
    /// </summary>
    public void CheckDavExStatus() {
      if (!IsDavExEnabled()) {
        string msg = "The Sling DavEx servlet is not enabled on your AEM instance - do you want to enable it?";
        if (MessageBox.Show(msg, "DavEx servlet", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
          try {
            EnableDavEx();
          }
          catch (Exception ex) {
            MessageBox.Show(ex.Message, "Enabling DavEx servlet failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }

    }

    private bool IsDavExEnabled() {
      string davExUrl = instance.UrlWithContextPath + "/crx/server/crx.default/jcr:root/.1.json";
      Stopwatch responseTimeStopwatch = new Stopwatch();
      try {
        mLog.Debug("Get bundle list from URL: " + davExUrl);

        WebRequest request = instance.WebRequestCreate(davExUrl);
        request.Method = "GET";
        request.Timeout = AEMManager.Properties.Settings.Default.BundleListTimeout;

        responseTimeStopwatch.Start();
        using (WebResponse response = request.GetResponse()) {
          responseTimeStopwatch.Stop();
          return true;
        }
      }
      catch (WebException ex) {
        if (ex.Status == WebExceptionStatus.Timeout) {
          mLog.Debug("Unable to connect to " + davExUrl + " due to timeout. "
            + "Configured timeout: " + AEMManager.Properties.Settings.Default.BundleListTimeout + "ms, "
            + "measured response time: " + responseTimeStopwatch.ElapsedMilliseconds + "ms");
        }
        else {
          mLog.Debug("Unable to connect to " + davExUrl + ": " + ex.Message);
        }
      }
      catch (Exception ex) {
        mLog.Error("Error getting DavEx status from URL: " + davExUrl, ex);
      }
      return false;
    }

    private void EnableDavEx() {
      string configPostUrl = instance.UrlWithContextPath + "/apps/system/config/org.apache.sling.jcr.davex.impl.servlets.SlingDavExServlet";
      Stopwatch responseTimeStopwatch = new Stopwatch();
      try {
        mLog.Debug("Post davex servlet config to URL: " + configPostUrl);

        StringBuilder postData = new StringBuilder();
        AppendUrlEncoded(postData, "jcr:primaryType", "sling:OsgiConfig");
        AppendUrlEncoded(postData, "alias", "/crx/server");
        AppendUrlEncoded(postData, "dav.create-absolute-uri", "true");
        AppendUrlEncoded(postData, "dav.create-absolute-uri@TypeHint", "Boolean");
        ASCIIEncoding ascii = new ASCIIEncoding();
        byte[] postBytes = ascii.GetBytes(postData.ToString());

        WebRequest request = instance.WebRequestCreate(configPostUrl);
        request.Method = "POST";
        request.Timeout = AEMManager.Properties.Settings.Default.BundleListTimeout;
        request.ContentType = "application/x-www-form-urlencoded";
        request.ContentLength = postBytes.Length;

        Stream postStream = request.GetRequestStream();
        postStream.Write(postBytes, 0, postBytes.Length);
        postStream.Flush();
        postStream.Close();

        responseTimeStopwatch.Start();
        using (WebResponse response = request.GetResponse()) {
          responseTimeStopwatch.Stop();
        }
      }
      catch (WebException ex) {
        if (ex.Status == WebExceptionStatus.Timeout) {
          throw new Exception("Unable to connect to " + configPostUrl + " due to timeout. "
            + "Configured timeout: " + AEMManager.Properties.Settings.Default.BundleListTimeout + "ms, "
            + "measured response time: " + responseTimeStopwatch.ElapsedMilliseconds + "ms");
        }
        else {
          throw new Exception("Unable to connect to " + configPostUrl + ": " + ex.Message);
        }
      }
      catch (Exception ex) {
        throw new Exception("Error posting DavEx config to URL: " + configPostUrl, ex);
      }

    }

    static void AppendUrlEncoded(StringBuilder sb, string name, string value) {
      if (sb.Length > 0) {
        sb.Append("&");
      }
      sb.Append(HttpUtility.UrlEncode(name));
      sb.Append("=");
      sb.Append(HttpUtility.UrlEncode(value));
    }

  }

}
