using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroceryApp
{
    public partial class Logon_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Login1.UserName.Trim() == "HR_manager" && Login1.Password.Trim() == "password")
            {
                // Success, create non-persistent authentication cookie.
                FormsAuthentication.SetAuthCookie(
                        Login1.UserName.Trim(), false);

                FormsAuthenticationTicket ticket1 =
                   new FormsAuthenticationTicket(
                        1,                                   // version
                        Login1.UserName.Trim(),   // get username  from the form
                        DateTime.Now,                        // issue time is now
                        DateTime.Now.AddMinutes(10),         // expires in 10 minutes
                        false,      // cookie is not persistent
                        "HR"                              // role assignment is stored
                                                          // in userData
                        );
                HttpCookie cookie1 = new HttpCookie(
                  FormsAuthentication.FormsCookieName,
                  FormsAuthentication.Encrypt(ticket1));
                Response.Cookies.Add(cookie1);

                // 4. Do the redirect. 
                String returnUrl1;
                // the login is successful
                if (Request.QueryString["ReturnUrl"] == null)
                {
                    returnUrl1 = "HRpages/HR_main.aspx";
                }

                //login not unsuccessful 
                else
                {
                    returnUrl1 = Request.QueryString["ReturnUrl"];
                }
                Response.Redirect(returnUrl1);
            }

        }
    }
}