using System;

namespace BE
{
    internal class ColumnAttribute : Attribute
    {
        public int Order { get; set; }
    }
}