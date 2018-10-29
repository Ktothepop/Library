using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
  public class MemberRepository : IRepository<Member, int>
  {
    LibraryContext context;

    public MemberRepository(LibraryContext c)
    {
      this.context = c;
    }

    //Samtliga funktioner här ska utnyttja Linq
    //ser ut såhär, frågan är om man gör en kontroll här eller tidigare? Borde kanske alltid kontrolleras?
    public IEnumerable<Member> All()
    {
      return context.Members;
    }
    public void Edit(Member a)
    {
      context.SaveChanges();
    }
    public void Add(Member a)
    {
      context.Members.Add(a);
      context.SaveChanges();
    }
    public void Remove(Member a)
    {
      context.Members.Remove(a);
      context.SaveChanges();
    }
    public Member Find(int inID)
    {
      return context.Members.Find(inID);
    }
  }
}
