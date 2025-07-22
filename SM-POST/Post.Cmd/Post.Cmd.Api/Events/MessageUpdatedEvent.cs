using CQRS.Core.Events;
using CQRS.Core.Messages;

namespace Post.Cmd.Api.Events
{
    public class MessageUpdatedEvent:BaseEvent
    {
        public MessageUpdatedEvent():base(nameof(MessageUpdatedEvent))
        {
            
        }
        public string Message { get; set; }
    }
}
