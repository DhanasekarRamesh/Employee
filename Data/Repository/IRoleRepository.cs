
using employee_management_api.Data.Entity;

namespace employee_management_api.Data.Repository
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetRoleByName(string RoleName);
        IEnumerable<Role> GetAllRoles();
        Role GetRoleByID(Guid ID);
        bool SaveAll();
        void AddRole(Role role);
        Task<Role> UpdateRole(Guid id, Role role);
        Task<Role> DeleteRole(Guid id);
    }

}
