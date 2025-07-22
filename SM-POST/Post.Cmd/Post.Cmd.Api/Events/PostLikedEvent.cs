using CQRS.Core.Events;
using CQRS.Core.Messages;

namespace Post.Cmd.Api.Events
{
    public class PostLikedEvent:BaseEvent
    {
        public PostLikedEvent():base(nameof(PostLikedEvent))
        {
            
        }

    }
}
