using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JSProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] != null)
            Label1.Text += Session["User"].ToString();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["1"] = TBcomname.Text;
        Session["5"] = TBjobtitle.Text;
        Session["6"] = TBsal.Text;
        Session["4"] = TBjobloc.Text;
        Session["2"] = TBexp.Text;
        Session["3"] = TBfield.Text;
        Session["7"] = TBskills.Text;
        Response.Redirect("JSJobs.aspx");
    }
}