using MediatR;

namespace FlightBooking.Domain.SharedKennel
{
    public abstract class Entity<T> where T : TypedIdValueBase
    {

        T _Id = default!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual T Id
        {
            get
            {
                return _Id;
            }
            protected set
            {
                _Id = value;
            }
        }

        private List<INotification> _domainEvents = new List<INotification>();
        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomainEvent(INotification eventItem)
        {
            _domainEvents = _domainEvents ?? new List<INotification>();
            _domainEvents.Add(eventItem);
        }

        public void RemoveDomainEvent(INotification eventItem)
        {
            _domainEvents?.Remove(eventItem);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Entity<T>))
                return false;

            if (Object.ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;
            else
            {
                Entity<T> item = (Entity<T>)obj;
                return item.Id == this.Id;
            }

        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode() ^ 31;

        }
        public static bool operator ==(Entity<T> left, Entity<T> right)
        {
            if (Object.Equals(left, null))
                return (Object.Equals(right, null)) ? true : false;
            else
                return left.Equals(right);
        }

        public static bool operator !=(Entity<T> left, Entity<T> right)
        {
            return !(left == right);
        }
    }
}
