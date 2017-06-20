using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text == "")
        {
            lblPrompt.Text = "Keyin your name";
            return;
        }
        Session["userName"] = txtUserName.Text;

        if (IsPostBack == true)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Defaule.aspx");
            }
            else
                Response.Redirect("Secret.aspx");
        }


    }
}