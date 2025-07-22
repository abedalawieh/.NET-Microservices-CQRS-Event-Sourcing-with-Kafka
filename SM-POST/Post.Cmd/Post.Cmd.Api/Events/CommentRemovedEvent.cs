using CQRS.Core.Events;
using CQRS.Core.Messages;

namespace Post.Cmd.Api.Events
{
    public class CommentRemovedEvent: BaseEvent
    {
        public CommentRemovedEvent():base(nameof(CommentUpdatedEvent))
        {
            
        }
        public Guid CommentId { get; set; }


        public string Username { get; set; }
    }
}
