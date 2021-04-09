using System.Data.SqlClient;
using System.Linq;
using Dapper;
using dbdemo_project.entity;

namespace dbdemo_project
{
    public class DatabaseConnection
    {
        public void CreateConnection()
        {
            string connectionString = @"Server=localhost,1433;Database=Master;User Id=SA;Password=Yggdrasil1989";

            using var connection = new SqlConnection(connectionString);
            Video video = new Video
            {
                Title = "Rick and Morty",
                SeasonNo = 1,
                EpisodeNo = 3,
                IsTvShow = true
            };

            connection.Execute("INSERT INTO GETFLIX.VIDEO VALUES(@title, @seasonno, @episodeno, @istvshow)", new
            {
                title = video.Title,
                seasonno = video.SeasonNo,
                episodeno = video.EpisodeNo,
                istvshow = video.IsTvShow
            });

            var videos = connection.Query<Video>("SELECT * from GETFLIX.VIDEO");
            Audio audio = new Audio
            {
                Url = "url",
                VideoId = videos.First().Id
            };

            connection.Execute("INSERT INTO GETFLIX.AUDIO VALUES(@url, @video_id)", new
            {
                url = audio.Url,
                video_id = audio.VideoId
            });

            Subtitle sub = new Subtitle
            {
                Url = "url",
                VideoId = videos.First().Id
            };

            connection.Execute("INSERT INTO GETFLIX.SUBTITLE VALUES(@url, @video_id)", new
            {
                url = sub.Url,
                video_id = sub.VideoId
            });

            connection.Execute("INSERT INTO GETFLIX.SUBTITLE VALUES(@url, @video_id)", new
            {
                url = "different url",
                video_id = sub.VideoId
            });
        }
    }
}