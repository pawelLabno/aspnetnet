using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDotNetCore.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Content { get; set; }

        public DateTime PublicationDate { get; set; }


        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
