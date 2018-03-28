using Data;
using MySql.Data.MySqlClient;
using System;


namespace SqlTest_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbCon = DBConnection.Instance();
            //Nom de la BDD
            dbCon.DatabaseName = "jdr";
            if (dbCon.IsConnect())
            {
                //Exemple de requète
                string query = "SELECT * FROM perso";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string name = reader.GetString(1);
                    string niv = reader.GetString(8);
                    if (niv.Equals("-1")) niv = "?"; 
                    string elem = "";
                    if (reader.GetString(7).Equals("") && reader.GetString(6).Equals(""))
                    {
                        elem = "(Pas d'élément)"; 
                    } else if (!reader.GetString(6).Equals("") && reader.GetString(7).Equals("")) {
                        elem = "(" + reader.GetString(6) + ")";
                    } else {
                        elem = "(" + reader.GetString(6) + " / " + reader.GetString(7) + ")";
                    }
                    Console.WriteLine(id + "," + name + " " + elem +" : niv "+ niv );
                }
                Console.ReadLine();
                dbCon.Close();
                
            }
            /*string langue = Console.ReadLine();
                string query = "INSERT INTO langue (Nom) VALUES ('" + langue + "')";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                cmd.ExecuteReader();

                dbCon.Close();*/
        }
    }
}
