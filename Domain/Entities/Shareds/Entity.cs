using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Shareds
{
    public abstract class Entity : IEquatable<Entity>
    {
        protected Entity(EntityId id)
        {
            Id = id;
        }

        public EntityId Id { get; private init; }


        public static bool operator==(Entity? first,Entity? second) { return first != null && second != null && first.Equals(second); }
        public static bool operator !=(Entity? first, Entity? second) { return !(first == second); }


        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType != obj.GetType) return false;
            if(obj is not Entity entity) return false;

            return entity.Id == Id;
        }

        public bool Equals(Entity? other)
        {
            if (other == null) return false;
            if (other.GetType != other.GetType) return false;
            if (other is not Entity entity) return false;

            return other.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
