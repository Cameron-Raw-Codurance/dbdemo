--CREATE SCHEMA GETFLIX
CREATE TABLE GETFLIX.VIDEO
(
    id         int NOT NULL IDENTITY,
    title      varchar(255),
    season_no  int,
    episode_no int,
    is_tv_show bit,
    PRIMARY KEY (id)
)

CREATE TABLE GETFLIX.AUDIO
(
    id       int NOT NULL IDENTITY,
    url      varchar(255),
    video_id int,
    PRIMARY KEY (id),
    CONSTRAINT video_id_audio_fk FOREIGN KEY (video_id) REFERENCES GETFLIX.VIDEO
)

CREATE TABLE GETFLIX.SUBTITLE
(
    id       int NOT NULL IDENTITY,
    url      varchar(255),
    video_id int,
    PRIMARY KEY (id),
    CONSTRAINT video_id_subtitle_fk FOREIGN KEY (video_id) REFERENCES GETFLIX.VIDEO
)