using SQLite;

namespace MeuCarroApp.Shared.Components.Core.Entities
{
    public class User : BaseAuditableEntity
    {
        [Unique] public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public bool KeepConnected { get; set; }
        [Ignore] public Role? Role { get; set; }
    }

    public class UserTelephone : BaseAuditableEntity
    {
        public string? Telephone { get; set; }
        public bool IsMain { get; set; }
    }

    public class UserEmail : BaseAuditableEntity
    {
        public string? Email { get; set; }
        public bool IsMain { get; set; }
    }

    public class UserProfile : BaseAuditableEntity
    {

    }
    public class Role : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Content { get; set; }
        [Ignore] public List<Permission>? Permissions { get; set; }
    }

    public class RolePermission
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
    }

    public class Permission : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Content { get; set; }
        [Ignore] public List<Role>? Roles { get; set; }
    }

}
