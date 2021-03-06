﻿using System;

namespace Ilaro.Admin.Core.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DeletableAttribute : Attribute
    {
        public bool AllowDelete { get; }

        public DeletableAttribute(bool allowDelete = true)
        {
            AllowDelete = allowDelete;
        }
    }
}