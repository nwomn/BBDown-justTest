﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BBDown
{
    class BBDownEntity
    {
        public struct Page
        {
            public int index;
            public string aid;
            public string cid;
            public string epid;
            public string title;
            public int dur;
            public string res;

            public Page(int index, string aid, string cid, string epid, string title, int dur, string res)
            {
                this.aid = aid;
                this.index = index;
                this.cid = cid;
                this.epid = epid;
                this.title = title;
                this.dur = dur;
                this.res = res;
            }
        }

        public struct Video
        {
            public string id;
            public string dfn;
            public string baseUrl;
            public string res;
            public string fps;
            public string codecs;
            public long bandwith;
            public int dur;
            public double size;

            public override bool Equals(object obj)
            {
                return obj is Video video &&
                       id == video.id &&
                       dfn == video.dfn &&
                       res == video.res &&
                       fps == video.fps &&
                       codecs == video.codecs &&
                       bandwith == video.bandwith &&
                       dur == video.dur;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(id, dfn, res, fps, codecs, bandwith, dur);
            }
        }

        public struct Audio
        {
            public string id;
            public string dfn;
            public string baseUrl;
            public string codecs;
            public long bandwith;
            public int dur;

            public override bool Equals(object obj)
            {
                return obj is Audio audio &&
                       id == audio.id &&
                       dfn == audio.dfn &&
                       codecs == audio.codecs &&
                       bandwith == audio.bandwith &&
                       dur == audio.dur;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(id, dfn, codecs, bandwith, dur);
            }
        }

        public struct Subtitle
        {
            public string lan;
            public string url;
            public string path;
        }

        public struct Clip
        {
            public int index;
            public long from;
            public long to;
        }
    }
}
