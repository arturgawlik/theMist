using System;

namespace theMist.Core.Domain
{
    public class Friend
    {
        public Guid UserId { get; protected set; }
        public string Name{ get; protected set; }
        public string Surname{ get; protected set; }

        protected Friend()
        {
        }

        public Friend(Guid userId, string name, string surname)
        {
            userId = UserId;
            Name = name; 
            Surname= surname;
        }
    }
}