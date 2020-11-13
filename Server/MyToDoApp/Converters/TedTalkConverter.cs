using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Converters
{
    public static class TedTalkConverter
    {
        public static MyToDoApp.Model.TEDTalk convertFromDTO(EF.Model.TEDTalk tedTalk)
        {
            MyToDoApp.Model.TEDTalk t = new MyToDoApp.Model.TEDTalk();
            t.ID = tedTalk.ID;
            t.Title = tedTalk.Title;
            t.IsWatched = tedTalk.IsWatched;
            t.Link = tedTalk.Link;
            return t;
        }
        public static EF.Model.TEDTalk convertToDTO(MyToDoApp.Model.TEDTalk tedTalk)
        {
            EF.Model.TEDTalk t = new EF.Model.TEDTalk();
            t.ID = tedTalk.ID;
            t.Title = tedTalk.Title;
            t.Link = tedTalk.Link;
            t.IsWatched = tedTalk.IsWatched;
            return t;
        }
    }
}
