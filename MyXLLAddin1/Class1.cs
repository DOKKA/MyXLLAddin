using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MyXLLAddin1
{
	static class Class1
	{
		public static string GetValue(string antigenName)
		{
			string value = "";
			try
			{
				using (SqlConnection con = new SqlConnection("insert connection string here"))
				{
					con.Open();
					using (SqlCommand command = new SqlCommand("SELECT TOP 1 sero_eq FROM mtilda.dbo.Antigens WHERE antigen_type = 'D' AND antigen_name = @antigen_name ORDER BY sort_seq", con))
					{
						command.Parameters.Add(new SqlParameter("@antigen_name", antigenName));
						using (SqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								value = (reader.GetString(0));
							}
							return value;
						}
					}
				}
			}
			catch(Exception e)
			{
				return "";
			}

		}
	}
}
