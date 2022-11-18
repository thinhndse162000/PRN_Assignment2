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
        List<Member> GetMembers();
        Member GetMemberById(int memberId);

        Member GetMemberByEmail(string email);
        string GetAdminEmail();
        string GetAdminPassword();
        void CreateMember(Member member);
        void Update(Member c);
        bool Delete(int memberId);

    }
}
