﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD6_1302213026
{
    public class SayaTubeVideo
    {
        int id;
        string title;
        int playCount;

        public SayaTubeVideo(string judul_video) {
            Debug.Assert(judul_video != null && judul_video.Length <= 100, "Judul melebihi batas");
            Random rnd = new Random();
            id = rnd.Next();
            this.title = judul_video;
            playCount = 0;
        }

        public void IncreasePlayCount(int playCount) {
            Debug.Assert(playCount <= 10000000, "Jumlah penayangan melebihi batas");
           this.playCount = checked( this.playCount + playCount);  
             
        }

        public void printVideoDetail() {
            Console.WriteLine("Judul video adalah " + title + " dengan id " + id + " diputar sebanyak " + playCount + " kali");
        }
    }


}
