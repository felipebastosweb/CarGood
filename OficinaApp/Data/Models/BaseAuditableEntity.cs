using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if ANDROID || IOS
using SQLite;
#endif

namespace OficinaApp.Data.Models
{
    public class BaseAuditableEntity
    {
#if ANDROID || IOS
        [PrimaryKey, AutoIncrement]
#endif
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
