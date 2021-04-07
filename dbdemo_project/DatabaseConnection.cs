using System;
using System.Data.SqlClient;
using Dapper;

namespace dbdemo_project
{
    public class DatabaseConnection
    {
        public void CreateConnection()
        {
            string connectionString = @"Server=localhost,1433;Database=Master;User Id=SA;Password=Yggdrasil1989";
            //string connectionString = @"Persist Security Info=False;User ID=sa;Password=Yggdrasil1989;Initial Catalog=RawData;Server=rawdata.db";

            Video rickAndMorty = new Video
            {
                Title = "Rick and Morty",
                SeasonNo = 1,
                EpisodeNo = 3,
                IsTvShow = true
            };
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute("INSERT INTO GETFLIX.VIDEO VALUES(@title, @seasonno, @episodeno, @istvshow)", new { video = rickAndMorty } );
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