﻿using CQRS.Core.Events;
using CQRS.Core.Messages;

namespace Post.Cmd.Api.Events
{
    public class CommentUpdatedEvent:BaseEvent
    {
        public CommentUpdatedEvent():base(nameof(CommentUpdatedEvent))
        {
            
        }
        public Guid CommentId { get; set; }

        public string Comment { get; set; }

        public string Username { get; set; }
    }
}
