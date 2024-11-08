using FiapLanchonete.Domain.Interfaces;

namespace FiapLanchonete.Domain.Shared
{
    public abstract class Entity<T> where T : IEntity
    {
        protected Guid _id;
        protected T props;

        public Entity(T props, Guid? id = null)
        {
            // Generate a new ID if none is provided
            _id = id ?? Guid.NewGuid();

            // Set CreatedAt and UpdatedAt
            if (props.CreatedAt == default)
            {
                props.CreatedAt = DateTime.Now; // If not set, initialize to now
            }
        }

        public DateTime CreatedAt => props.CreatedAt;

        public Guid Id => _id;
    }
}