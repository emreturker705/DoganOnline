using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Model.Domain
{
    public class News
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
    }
}
