using System.Collections.Generic;
using dbdemo_project.entity;

namespace dbdemo_project.repository
{
    public interface IVideoRepository
    {
        void Add(Video video);
        IList<Video> GetAllVideo();
    }
}