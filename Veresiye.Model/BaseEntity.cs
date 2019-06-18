using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veresiye.Model
{
    public class BaseEntity
    {
        //ortak alanları buraya koyduk (Entitylerin ortak alanlarını)
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
