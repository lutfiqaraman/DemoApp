using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoApp
{
    public partial class ContactForm : System.Web.UI.UserControl
    {
        public string Name { get; set; }
        public string Msg { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Name = txtName.Text;
                Msg  = txtMsg.Text;
            } else
            {
                txtName.Text = Name;
                txtMsg.Text  = Msg;
            }
        }
    }
}