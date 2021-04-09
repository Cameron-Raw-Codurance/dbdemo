using System.Collections.Generic;
using DapperExtensions.Mapper;

namespace dbdemo_project.entity
{
    public class Video
    {
        public int Id;
        public string Title;
        public int SeasonNo;
        public int EpisodeNo;
        public bool IsTvShow;

        public IList<Subtitle> Subtitles { get; }
    }
    
    public class VideoMapper : ClassMapper<Video>
    {
        public VideoMapper()
        {
            Table("Video");
            Map(v => v.Subtitles).Ignore();
            AutoMap();
        }
    }
    
}