using SaleManagement.repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.repo.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetAllMember();
        string GetAdminEmail();
        string GetAdminPassword();
    }
}
