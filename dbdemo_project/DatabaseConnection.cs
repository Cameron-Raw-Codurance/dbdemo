using System;
using System.Data.SqlClient;

namespace dbdemo_project
{
    public class DatabaseConnection
    {
        public void CreateConnection()
        { 
            string connectionString = @" Server=localhost:1433; Database=GETFLIX; User Id=sa; Password=Yggdrasil1989 ";
            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("");
            }
        }
    }

    public class Video
    {
        public int Id;
        public string Title;
        public int SeasonNo;
        public int EpisodeNo;
        public bool IsTvShow;
    }
    
    public class Audio
    {
        public int Id;
        public string Url;
    }
    
    public class Subtitle
    {
        public int Id;
        public string Url;
    }
}
