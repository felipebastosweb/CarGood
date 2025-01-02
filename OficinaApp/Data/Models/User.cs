using SQLite;

namespace OficinaApp.Data.Models
{
    public class User : BaseAuditableEntity
    {
        [Unique] public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
    }

    public class Role : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Content { get; set; }
        public IList<RoleChild>? Children { get; set; }
        public IList<Permission>? Permissions { get; set; }
    }

    public class RoleChild
    {
        public int RoleId { get; set; }
        public int ChildId { get; set; }
    }

    public class Permission : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Content { get; set; }
        public IList<Role>? Roles { get; set; }
    }

}
