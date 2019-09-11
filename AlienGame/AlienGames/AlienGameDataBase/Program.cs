using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using AlienGames;

namespace AlienGameDataBase
{
   public class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class Create
    {

        public void insertTable()

        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSharpGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string insertString = String.Format("INSERT INTO AlienGameHighScore(Username, Score, Date) VALUES ('{0}', '{1}', '{2}')", game1.Name, game1.Game1, game1.Type, game1.Review);
            // string inserting2 = "INSERT INTO GAME (name,game,type,review) VALUES('a','b','c','d')";

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand insertCommand = new SqlCommand(insertString, conn);

                Console.WriteLine(conn.State);

                insertCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Something happened to server " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }

    public class HighScore
    {

        string Username = "";
        int Score = 0;
        DateTime Date;

        public string Username1 { get => Username; set => Username = value; }
        public int Score1 { get => Score; set => Score = value; }
        public DateTime Date1 { get => Date; set => Date = value; }
    }
}
