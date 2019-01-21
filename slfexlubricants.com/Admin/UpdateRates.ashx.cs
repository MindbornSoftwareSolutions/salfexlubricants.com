using System;
using System.Collections.Generic;
using System.Web;
using System.Text;

namespace Admin
{
	/// <summary>
	/// Summary description for UpdateRates1
	/// </summary>
	public class UpdateRates1 : IHttpHandler
	{
		private static char[] separators1 = new char[] { '\n', '\r' };
		private static char[] separators2 = new char[] { '=' };
		public void ProcessRequest(HttpContext context)
		{
			//foreach(String s in context.Request.Form.AllKeys)
			//{
			//    if (s.StartsWith("ta_"))
			//    {
			//        int iid = Convert.ToInt32(s.Substring(3));
			//        String rates = context.Request.Form[s];

			//        String instock = context.Request.Form["is_" + iid];

			//        StringBuilder sb = new StringBuilder();
			//        String[] tokens = rates.Split(separators1);
			//        foreach (String token in tokens)
			//        {
			//            String[] tokens2 = token.Split(separators2);
			//            //sb.Append(tokens2[0].Trim()).Append('=').Append(tokens2[1]).Append('\n');
			//            for (int i = 0; i < tokens2.Length; i++)
			//            {
			//                if (i > 0) sb.Append("=");
			//                sb.Append(tokens2[i]);
			//            }
			//            sb.Append("\n");
			//        }
			//        rates = sb.ToString();
			//        DBManager.ExecuteNonQuery("update item set rates=@rates where iid=@iid", "@rates", rates, "@iid", iid);
			//    }
			//}
			//context.Response.Redirect("/Admin/Categories.aspx");
		}

		public bool IsReusable
		{
			get
			{
				return false;
			}
		}
	}
}