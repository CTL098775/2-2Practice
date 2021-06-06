using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice {
    public partial class GenerateBomb : System.Web.UI.Page {
        void mt_GetRowCol(ref int  i_Row,  ref int  i_Col, ref int  i_Landmine)  {
            i_Row = i_Landmine % 10;
            i_Col = i_Landmine % 10;
        }
    protected void Page_Load(object sender, EventArgs e) {
            int[] i_Landmine = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            int i_Row = 0, i_Col = 0;
            int[,] i_map = new int[10, 10];
            Response.Write("<table border = 4>");
            for (int i_Ct  = 0; i_Ct <  i_Landmine.Length; i_Ct++)  {
                mt_GetRowCol(ref i_Row, ref i_Col, ref i_Landmine[i_Ct]);
                    i_map[i_Row, i_Col] = -1;
            }

            for (int i_Ct = 0; i_Ct < 10; i_Ct++)  {
                Response.Write("<tr>");
                for (int i_Ct2 = 0; i_Ct2 < 10; i_Ct2++) {
                    Response.Write("<td>" + i_map[i_Ct, i_Ct2] + "</td>");
                }
                Response.Write("</tr>"+ "<br />");
                Response.Write("<br />");
            }
            Response.Write("</table>");
        }
    } 
}