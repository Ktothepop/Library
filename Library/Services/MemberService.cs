using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
  /// <summary>
  /// This class handles the logic for the members in the GUI classes, connected to the MemberRepository
  /// Inherits the IService method to handle events in GUI in accordance with the Observable pattern
  /// </summary>
  class MemberService : IService
  {
    MemberRepository memberRepository;

    public event EventHandler Updated;

    /// <summary>
    /// Constructor launches when class is initiated
    /// </summary>
    /// <param name="rFactory">Connection to Member repository, creates its own through Factory pattern</param>
    public MemberService(RepositoryFactory rFactory)
    {
      this.memberRepository = rFactory.CreateMemberRepository();
    }

    /// <summary>
    /// OnChanged event launched when changes is made 
    /// </summary>
    /// <param name="args">Event arguments, placeholder for future use</param>
    protected virtual void OnChanged(EventArgs args)
    {
      Updated?.Invoke(this, args);
    }

    /// <summary>
    /// Gets all the members
    /// </summary>
    /// <returns>IEnumerable of all the Members</returns>
    public IEnumerable<Member> All()
    {
      return memberRepository.All();
    }

    /// <summary>
    /// Adds a member and makes sure its added to the DB, also raises the OnChanged() event
    /// </summary>
    /// <param name="m">The member to be added</param>
    public void Add(Member m)
    {
      try {
        memberRepository.Add(m);
        OnChanged(EventArgs.Empty);

      } catch (Exception ex) {
        if (ex is FormatException || ex is NullReferenceException || ex is ArgumentNullException) {
          throw ex;
        }
      }
    }
    /// <summary>
    /// Edits a member and makes sure the change goes to DB, also raises the OnChanged() event
    /// </summary>
    /// <param name="m">The edited member</param>
    public void EditMember(Member m)
    {
      if (m != null) {
        memberRepository.Edit(m);
        OnChanged(EventArgs.Empty);
      } else throw new ArgumentNullException();
    }

  }
}
