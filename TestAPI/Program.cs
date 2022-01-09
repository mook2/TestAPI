// See https://aka.ms/new-console-template for more information


using System.Data;
using System.Data.SqlClient;

namespace CsTest
{
    class program
    {

        
        static void Main(string[] args)
        {
            
            String Query = String.Empty;


            String ConnectionString = "Data Source=.;Initial Catalog=master;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(ConnectionString);

            DataSet ds = new DataSet();


            SqlCommand command = new SqlCommand("SELECT * FROM MOOK_TEST");

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM MOOK_TEST", sqlcon);


            try
            { 
                

                sqlcon.Open();

                adapter.Fill(ds);
                Console.WriteLine("Fill 성공" );


            }
            catch (Exception)
            {
                
                Console.WriteLine("서버오픈이 실행되지 않았습니다.");
                Console.WriteLine(sqlcon.State);
                return;
            }


            

            if (ds.Tables.Count > 0)
            {
                foreach( DataRow r in ds.Tables[0].Rows)
                {
                    Console.WriteLine(r);
                }
            }


            Console.WriteLine("셀렉트 리턴" );
            //command = new SqlCommand()



        }
    }


}
