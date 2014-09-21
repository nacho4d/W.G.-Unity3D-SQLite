using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System.Data;
using System;

public class DBAccess : MonoBehaviour
{
    void Start ()
    {
        string connectionString = "URI=file:" + Application.dataPath + "/GameMaster"; //Path to database.
        IDbConnection dbcon = new SqliteConnection(connectionString) as IDbConnection;
        dbcon.Open(); //Open connection to the database.

        IDbCommand dbcmd = dbcon.CreateCommand();
        dbcmd.CommandText = "SELECT firstname, lastname " + "FROM addressbook";

        IDataReader reader = dbcmd.ExecuteReader();
        while(reader.Read())
        {
            string FirstName = reader.GetString (0);
            string LastName = reader.GetString (1);
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            UnityEngine.Debug.LogWarning("Name: " + FirstName + " " + LastName);
        }
        reader.Close();
        reader = null;

        dbcmd.Dispose();
        dbcmd = null;

        dbcon.Close();
        dbcon = null;
    }
}
