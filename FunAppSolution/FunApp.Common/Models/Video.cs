using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FunApp.Common.Models
{
    public class Video
    {
        public Dictionary<string, string> VideoNameWithLink { get; set; } = new Dictionary<string, string>() { {"Demo" , "https://web.microsoftstream.com/embed/video/81ee3c54-61fe-42e3-9522-aa99f71d1f62?autoplay=false&amp;showinfo=true" },
            {"About CSG", "https://web.microsoftstream.com/embed/video/81ee3c54-61fe-42e3-9522-aa99f71d1f62?autoplay=false&amp;showinfo=true" },
            {"DNA DW OverView","https://web.microsoftstream.com/embed/video/5ddc6818-e171-4533-a3f1-1099a04cd16b?autoplay=false&amp;showinfo=true" },
            {"Snowflake Intro","https://www.youtube.com/embed/dZlBCLLL7UA?autoplay;encrypted-media;gyroscope;picture-in-picture"}
        };

    }
}