using System;
using System.Collections.Generic;

namespace theMist.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Email { get; protected set; } 
        public string Name { get; protected set; } 
        public string Surrname { get; protected set; } 
        public string Username { get; protected set; } 
        public DateTime CreatedAt { get; protected set; } 
        public string Salt { get; protected set; }
        public ISet<Friend> friends; 
    }
}