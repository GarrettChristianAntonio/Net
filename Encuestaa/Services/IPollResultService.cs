using System.Collections.Immutable;

namespace Encuestaa.Services
{
    public interface IPollResultService
    {
        void AddVote(Deporte deporte);
        SortedDictionary<Deporte, int> GetVoteResult();
    }
}
