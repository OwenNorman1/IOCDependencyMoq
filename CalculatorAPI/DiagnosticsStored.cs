using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAPI
{
    public class DiagnosticsStored : IDiagnostics
    {
        SqlConnection cnn;
        public void logString(string message)
        {
            Console.WriteLine($"Logging message: {message}");
            String connString = "Data Source=.\\sqlexpress; Initial Catalog = Logging; User ID = LoggingAdmin; Password = LoggingAdmin; Trusted_Connection=True";
            String query = "INSERT INTO Diagnostics (Message) VALUES ('"+ message +"');";
            cnn = new SqlConnection(connString);
            cnn.Open();
            SqlCommand command = new SqlCommand(query, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
