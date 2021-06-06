using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class ReverseInt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int N = 1254;
            string r_str = N.ToString();
            var r = r_str.Reverse().ToArray();
            r_str = new string(r);
            int r_int = int.Parse(r_str);
            Response.Write(r_int);
        }
    }
}