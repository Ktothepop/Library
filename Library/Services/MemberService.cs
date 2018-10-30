using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
  class MemberService
  {
    MemberRepository memberRepository;

    public MemberService(RepositoryFactory rFactory)
    {
      this.memberRepository = rFactory.CreateMemberRepository();
    }
        public IEnumerable<Member> All()
        {
            return memberRepository.All();
        }
        public void Add(Member m)
        {
            if (m != null)
                memberRepository.Add(m);
        }


    }
}
