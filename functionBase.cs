using System.Data;

namespace pharmacy_manegment_practice
{
    internal class functionBase
    {

        public DataSet GetData(String query)
        {
            SqlConnetion con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;


            //SqlConnection con = getConnection();
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = query;
            //  SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //return ds;
        }
    }
}