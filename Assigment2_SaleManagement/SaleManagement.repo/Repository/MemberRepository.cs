using SaleManagement.repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.repo.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly SaleManagementContext _db;
        public MemberRepository() {
            _db = new();
        }
        public IEnumerable<Member> GetAllMember()
        {
            return _db.Members.ToList();
        }
        public string GetAdminEmail() { 
            return _db.GetAdminEmail();
        }
        public string GetAdminPassword()
        {
            return _db.GetAdminPassword();
        }
    }
}
