using CQRS.Core.Events;
using CQRS.Core.Messages;

namespace Post.Cmd.Api.Events
{
    public class CommentAddedEvent:BaseEvent
    {
        public CommentAddedEvent():base(nameof(CommentAddedEvent))
        {
            
        }
        public string Comment { get; set; }

        public string Username { get; set; }
    }
}
