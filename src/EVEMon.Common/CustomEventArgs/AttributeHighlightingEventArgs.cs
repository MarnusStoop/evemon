﻿using System;

namespace EVEMon.Common.CustomEventArgs
{
    public sealed class AttributeHighlightingEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeHighlightingEventArgs"/> class.
        /// </summary>
        /// <param name="highlightValue">The highlight value.</param>
        public AttributeHighlightingEventArgs(Int64 highlightValue)
        {
            Value = highlightValue;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public Int64 Value { get; }
    }
}
