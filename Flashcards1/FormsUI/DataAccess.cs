using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Dapper;

namespace FormsUI
{
    public class DataAccess
    {
        public List<Card> GetCards(string bandName)
        {
            //connect to sql server - this will be the same no matter the project
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDb")))
            {
                //this is saying - take the connection you have open and query (ask for) Card data 
                //the command will return an ienumerable back but we want a list
                var output = connection.Query<Card>($"select * from flashkardz where BandName = '{ bandName }'").ToList();
                return output;
            }

        }

        public void AddCards(string bandName, string songName)
        {

            string sql = "INSERT INTO flashkardz (bandName, songName) VALUES ( @bandName,  @songName)";
            object[] parameters = { new { bandName = bandName, songName = songName } };

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDb")))
            {
                var input = connection.Execute(sql, parameters);
                
            }
        }

        public void DeleteCards (string id)

        {
            var idint = Int32.Parse(id);

            string sql = $"DELETE FROM flashkardz WHERE id='{ id }'";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDb")))
            {
                var input = connection.Execute(sql);
                
            }
        }
    }
}
