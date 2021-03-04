using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoApp
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Title = "About Page";
            } else
            {
                Title = "About Page " + txtData.Text;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}