using System;

namespace FiapLanchonete.Domain.Interfaces
{
    public interface IEntity
    {
        Guid Id { get; }
        DateTime CreatedAt { get; set; }
    }
}
