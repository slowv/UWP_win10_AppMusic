﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlowVMusic.Entity
{
    class GlobalFlySong
    {
        private static Song globalSong;

        public static bool _isLogin = false;

        internal static Song GlobalSong { get => globalSong; set => globalSong = value; }
    }
}
