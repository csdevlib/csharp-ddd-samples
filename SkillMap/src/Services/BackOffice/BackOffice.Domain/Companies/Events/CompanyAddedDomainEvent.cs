﻿using SkillMap.EventBus.Events;
namespace BackOffice.Domain.Companies.Events
{
    public record CompanyAddedDomainEvent : DomainEvent
    {
        public string Id { get; init; }

        public string Name { get; init; }

        public CompanyAddedDomainEvent(string id, string name) 
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public override string EventName() => GetType().Name.ToLower();
       
    }
}
