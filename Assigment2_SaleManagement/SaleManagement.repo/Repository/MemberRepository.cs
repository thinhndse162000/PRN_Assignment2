using Microsoft.Identity.Client;
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

        public void CreateMember(Member member)
        {
            if (member is not null) { 
                this._db.Members.Add(member);
                this._db.SaveChanges();
            }
        }

        public void Update(Member c)
        {
            if (c is not null)
            {

                var member = _db.Members.First(g => g.MemberId.Equals(c.MemberId));
                _db.Entry(member).CurrentValues.SetValues(c);
                _db.SaveChanges();

            }
        }

        public bool Delete(int memberId)
        {
            Member? member = GetMemberById(memberId);
            _db.Remove(member);
            return _db.SaveChanges() > 0;
        }

        public Member? GetMemberById(int memberId)
        {
            return this._db.Members
                .Where(c => c.MemberId.Equals(memberId))
                .FirstOrDefault();
        }

        public Member? GetMemberByEmail(string email)
        {
            return this._db.Members
                .Where(m => m.Email.Equals(email))
                .FirstOrDefault();
        }

        public List<Member> GetMembers() => _db.Members.ToList();

    }
}
