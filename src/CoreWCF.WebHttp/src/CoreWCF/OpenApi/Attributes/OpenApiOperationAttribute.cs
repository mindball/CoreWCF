// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace CoreWCF.OpenApi.Attributes
{
    /// <summary>
    /// Attribute to denote information about an operation.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class OpenApiOperationAttribute : Attribute
    {
        /// <summary>
        /// Default value for <see cref="Deprecated"/>.
        /// </summary>
        public const bool DeprecatedDefault = false;
        
        /// <summary>
        /// A short summary about an operation.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Description of an operation
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Declares this operation to be deprecated. Consumers SHOULD refrain from usage of the declared operation.
        /// </summary>
        public bool Deprecated { get; set; } = DeprecatedDefault;
    }
}
