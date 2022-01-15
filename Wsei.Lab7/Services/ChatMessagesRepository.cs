using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.Lab7.Entities;

namespace Wsei.Lab7.Services
{
    public class ChatMessagesRepository : IChatMessagesRepository
    {
        private readonly List<ChatMessageEntity> _messages = new List<ChatMessageEntity>();

        public void Add(ChatMessageEntity message)
        {
            _messages.Add(message);
        }

        public IEnumerable<ChatMessageEntity> GetAll()
        {
            return _messages;
        }
    }
}
