using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.TinyUrlCleanupFunction.Models
{
        public class ShortUrl
        {
        public int Id { get; set; }
        public string OriginalUrl { get; set; } = string.Empty;
        public string ShortCode { get; set; } = string.Empty;
        public bool IsPrivate { get; set; }

        public int Clicks { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}