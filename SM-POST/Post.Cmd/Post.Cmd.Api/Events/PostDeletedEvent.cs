using CQRS.Core.Events;
using CQRS.Core.Messages;

namespace Post.Cmd.Api.Events
{
    public class PostDeletedEvent : BaseEvent
    {
        public PostDeletedEvent():base(nameof(PostDeletedEvent))
        {

        }
        public string Username { get; set; }
    }
}
