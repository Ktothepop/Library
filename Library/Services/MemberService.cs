using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
  class MemberService : IService
  {
    MemberRepository memberRepository;

    public event EventHandler Updated;

    public MemberService(RepositoryFactory rFactory)
    {
      this.memberRepository = rFactory.CreateMemberRepository();
    }

    protected virtual void OnChanged(EventArgs args)
    {
      Updated?.Invoke(this, args);
    }

    public IEnumerable<Member> All()
    {
      return memberRepository.All();
    }
    public void Add(Member m)
    {
      if (m != null) {
        memberRepository.Add(m);
        OnChanged(EventArgs.Empty);

      }
    }
    public void EditMember(Member m)
    {
      if (m != null) {
        memberRepository.Edit(m);
        OnChanged(EventArgs.Empty);
      }
    }

  }
}
