using employee_management_api.Data;
using employee_management_api.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace employee_management_api.Data.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly AppDBContext _dbContext;

        public RoleRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;

        }

        public void AddRole(Role role)
        {
            throw new NotImplementedException();
        }

        public Task<Role> DeleteRole(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return _dbContext.Roles.OrderBy(r => r.Name).ToList();
        }

        public Role GetRoleByID(Guid ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetRoleByName(string RoleName)
        {
            throw new NotImplementedException();
        }

        public bool SaveAll()
        {
            throw new NotImplementedException();
        }

        public Task<Role> UpdateRole(Guid id, Role role)
        {
            throw new NotImplementedException();
        }

    }
}