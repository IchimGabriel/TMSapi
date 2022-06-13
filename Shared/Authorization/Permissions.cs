using System.Collections.ObjectModel;

namespace Shared.Authorization
{ 
    public class Permissions
    {
        private static readonly Permission[] _all = new Permission[]
        {
            new("View Dashboard", Action.View, Resource.Dashboard),
            new("View Hangfire", Action.View, Resource.Hangfire),
            new("View Users", Action.View, Resource.Users),
            new("Search Users", Action.Search, Resource.Users),
            new("Create Users", Action.Create, Resource.Users),
            new("Update Users", Action.Update, Resource.Users),
            new("Delete Users", Action.Delete, Resource.Users),
            new("Export Users", Action.Export, Resource.Users),
            new("View UserRoles", Action.View, Resource.UserRoles),
            new("Update UserRoles", Action.Update, Resource.UserRoles),
            new("View Roles", Action.View, Resource.Roles),
            new("Create Roles", Action.Create, Resource.Roles),
            new("Update Roles", Action.Update, Resource.Roles),
            new("Delete Roles", Action.Delete, Resource.Roles),
            new("View RoleClaims", Action.View, Resource.RoleClaims),
            new("Update RoleClaims", Action.Update, Resource.RoleClaims),
            new("View Products", Action.View, Resource.Projects, IsBasic: true),
            new("Search Products", Action.Search, Resource.Projects, IsBasic: true),
            new("Create Products", Action.Create, Resource.Projects),
            new("Update Products", Action.Update, Resource.Projects),
            new("Delete Products", Action.Delete, Resource.Projects),
            new("Export Products", Action.Export, Resource.Projects),
            new("View Brands", Action.View, Resource.Clients, IsBasic: true),
            new("Search Brands", Action.Search, Resource.Clients, IsBasic: true),
            new("Create Brands", Action.Create, Resource.Clients),
            new("Update Brands", Action.Update, Resource.Clients),
            new("Delete Brands", Action.Delete, Resource.Clients),
            new("View Tenants", Action.View, Resource.Tenants, IsRoot: true),
            new("Create Tenants", Action.Create, Resource.Tenants, IsRoot: true),
            new("Update Tenants", Action.Update, Resource.Tenants, IsRoot: true),
            new("Upgrade Tenant Subscription", Action.UpgradeSubscription, Resource.Tenants, IsRoot: true)
        };

        public static IReadOnlyList<Permission> All { get; } = new ReadOnlyCollection<Permission>(_all);
        public static IReadOnlyList<Permission> Root { get; } = new ReadOnlyCollection<Permission>(_all.Where(p => p.IsRoot).ToArray());
        public static IReadOnlyList<Permission> Admin { get; } = new ReadOnlyCollection<Permission>(_all.Where(p => !p.IsRoot).ToArray());
        public static IReadOnlyList<Permission> Basic { get; } = new ReadOnlyCollection<Permission>(_all.Where(p => p.IsBasic).ToArray());
    }

    public record Permission(string Description, string Action, string Resource, bool IsBasic = false, bool IsRoot = false)
    {
        public string Name => NameFor(Action, Resource);
        public static string NameFor(string action, string resource) => $"Permissions.{resource}.{action}";
    }
}
