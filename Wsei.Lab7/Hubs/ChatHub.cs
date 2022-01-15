using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.Lab7.Entities;
using Wsei.Lab7.Services;

namespace Wsei.Lab7.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        public readonly IChatMessagesRepository _repository;

        public ChatHub(IChatMessagesRepository repository)
        {
            _repository = repository;
        }

        public override async Task OnConnectedAsync()
        {
            var user = Context.User.Identity.Name;

            await Clients.Caller.SendAsync("OnMessageSent", "admin", "Hello dear " + user);
        }

        public async Task SendMessage(string message)
        {
            var user = Context.User.Identity.Name;

            await Clients.All.SendAsync("OnMessageSent", user, message);

            var messageEntity = new ChatMessageEntity
            {
                Username = user,
                Content = message,
            };
            _repository.Add(messageEntity);
        }
    }
}
