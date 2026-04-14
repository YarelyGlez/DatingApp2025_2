using API.Entities;
using API.Helpers;

namespace API.Interfaces;

public interface IMembersRepository
{
    void Update(Member member);
    Task<bool> SaveAllAsync();
    Task<PaginationResult<Member>> GetMembersAsync(MessageParams messageRequest);
    Task<Member?> GetMemberAsync(string id);
    Task<IReadOnlyList<Photo>> GetPhotosAsync(string memberId);
    Task<Member?> GetMemberForUpdateAsync(string id);
    Task<object?> GetMembersAsync(MemberRequest request);
}
