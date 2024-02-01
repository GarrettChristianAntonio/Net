
namespace Encuestaa.Services
{
    public class PollResultService : IPollResultService
    {
        private Dictionary<Deporte, int> _selectionVotes;

        public PollResultService() 
        { 
            _selectionVotes = new Dictionary<Deporte, int>();
        }

        public void AddVote(Deporte deporte)
        {
            if (_selectionVotes.ContainsKey(deporte))
            {
                _selectionVotes[deporte]++;
            }
            else
            {
                _selectionVotes.Add(deporte, 1);
            }
        }

        public SortedDictionary<Deporte, int> GetVoteResult()
        {
            return new SortedDictionary<Deporte, int>(_selectionVotes);
        }
    }
}
