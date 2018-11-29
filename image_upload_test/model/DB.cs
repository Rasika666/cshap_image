using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace image_upload_test.model
{
	class DB
	{

		//database config
		private const String SERVER = "localhost";
		private const String DATABASE = "image_test";
		private const String USERNAME = "root";
		private const String PASSWORD = "";
		private static MySqlConnection dbConn;
		private static MySqlDataReader reader;


		public static void initializedDB()
		{
			MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
			builder.Server = SERVER;
			builder.UserID = USERNAME;
			builder.Password = PASSWORD;
			builder.Database = DATABASE;

			String connString = builder.ToString();
			builder = null;
			Console.WriteLine(connString);

			dbConn = new MySqlConnection(connString);
		}

		public static System.Data.IDataReader getData(String SQL)
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand(SQL, dbConn);
				dbConn.Open();

				//get buffer the fetch result
				reader = cmd.ExecuteReader();

				//fetch read data to main memory
				var dt = new DataTable();
				dt.Load(reader);
				return dt.CreateDataReader();

			}
			catch (Exception e)
			{
				Console.WriteLine("Exception caught(DB): {0}", e);
				return null;
			}
			finally
			{
				dbConn.Close();
			}
		}

		public static void closeConnection()
		{
			dbConn.Close();
		}

		public static int putData(String SQL)
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand(SQL, dbConn);
				dbConn.Open();

				//# of rows affected
				return cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception caught(DB): {0}", e);
				return 0;
			}
			finally
			{
				dbConn.Close();
			}

		}

		public static int putDataImg(String SQL, byte[] image)
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand(SQL, dbConn);
				dbConn.Open();

				cmd.Parameters.Add("@image", MySqlDbType.Blob);
				cmd.Parameters["@image"].Value = image;
				//# of rows affected
				return cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception caught(DB): {0}", e);
				return 0;
			}
			finally
			{
				dbConn.Close();
			}

		}

		public static MySqlConnection getConn()
		{
			initializedDB();

			return dbConn;
		}
	}

}

