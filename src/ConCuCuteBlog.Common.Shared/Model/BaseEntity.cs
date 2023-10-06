using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCuCuteBlog.Common.Shared.Model
{
    //Log time for fix and update
    public class BaseEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        public bool IsDeleted { get; set; }
        public BaseEntity SetCreateInfo(string user, DateTime data)
        {
            this.CreatedAt = data;
            this.CreatedBy = user;
            return this;
        }
        public BaseEntity SetUpdateInfo(string user, DateTime data)
        {
            this.LastUpdatedBy = user;
            this.LastUpdateAt = data;
            return this;
        }
    }
}
