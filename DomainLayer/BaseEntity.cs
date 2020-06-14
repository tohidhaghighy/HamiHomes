using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
    }
}
