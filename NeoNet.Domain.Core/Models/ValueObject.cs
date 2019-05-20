using System;
using System.Collections.Generic;
using System.Text;

namespace NeoNet.Domain.Core.Models
{
    #region explicacion 
    //En el modelo Value Object, un objeto se diferencia de otro por su contenido, no por su identidad propia.
    //Los estados en un modelo Value Object son inmutables -llamamos estado de la aplicación, de una función, etc,
    //a todos aquellos datos que representan cómo está la aplicación en un momento determinado- .
    //Value Object es un concepto

    #endregion
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        public override bool Equals(object obj)
        {
            var valueObject = obj as T;
            return !ReferenceEquals(valueObject, null) && EqualsCore(valueObject);
        }

        protected abstract bool EqualsCore(T other);

        public override int GetHashCode()
        {
            return GetHashCodeCore();
        }

        protected abstract int GetHashCodeCore();

        public static bool operator ==(ValueObject<T> a, ValueObject<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(ValueObject<T> a, ValueObject<T> b)
        {
            return !(a == b);
        }
    }
}
