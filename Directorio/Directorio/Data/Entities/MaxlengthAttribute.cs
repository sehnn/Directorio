﻿using System;

namespace Directorio.Data.Entities
{
    internal class MaxlengthAttribute : Attribute
    {
        private int v;

        public MaxlengthAttribute(int v)
        {
            this.v = v;
        }
    }
}