using System;
using System.Collections.Generic;

namespace theMist.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Email { get; protected set; } 
        public string Name { get; protected set; } 
        public string Surname { get; protected set; } 
        public string Username { get; protected set; }
        public DateTime BirthDate { get; protected set; } 
        public DateTime CreatedAt { get; protected set; } 
        public string Salt { get; protected set; }
        public ISet<Friend> friends; 

        protected User()
        {
        }

        public User(string email, string name, string surname, string username, DateTime birthDate, string salt)
        {
            Id = Guid.NewGuid();
            SetEmail(email);
            SetName(name);
            SetSurname(surname);
            SetUsername(username);
            SetBirthDate(birthDate);
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }

        
        public void SetEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
                throw new Exception("Email can not be null or white space.");
            
            Email = email.ToLowerInvariant();
        }
        public void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new Exception("Name can not be null or white space.");
            
            Name = name.ToLowerInvariant();
        }
        public void SetSurname(string surname)
        {
            if(string.IsNullOrWhiteSpace(surname))
                throw new Exception("Email can not be null or white space.");
            
            Surname = surname.ToLowerInvariant();
        }
        public void SetUsername(string username)
        {
            if(string.IsNullOrWhiteSpace(username))
                throw new Exception("Username can not be null or white space.");
            
            Username = username.ToLowerInvariant();
        }
        public void SetBirthDate(DateTime birthDate)
        {
            if(birthDate >= DateTime.UtcNow)
                throw new Exception("Invalid birth date.");
            
            BirthDate = birthDate;
        }
    }
}