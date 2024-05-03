using Solid.ISP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP
{
    public class VideoPlayer : IPlayVideo, ILoadMedia
    {
        public void PlayVideo()
        {
            // implement code to play video
        }

        public void LoadMedia(string filePath)
        {
            // implement code to load media
        }
    }
}
