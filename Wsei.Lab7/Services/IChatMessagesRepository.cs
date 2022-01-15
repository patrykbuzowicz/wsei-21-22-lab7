using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.Lab7.Entities;

namespace Wsei.Lab7.Services
{
    public interface IChatMessagesRepository
    {
        void Add(ChatMessageEntity message);

        IEnumerable<ChatMessageEntity> GetAll();
    }
}
