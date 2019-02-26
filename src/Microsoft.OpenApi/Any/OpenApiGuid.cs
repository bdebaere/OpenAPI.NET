// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. 

using System;

namespace Microsoft.OpenApi.Any
{
    /// <summary>
    /// Open API guid type.
    /// </summary>
    public class OpenApiGuid : OpenApiPrimitive<Guid>
    {
        /// <summary>
        /// Initializes the <see cref="OpenApiString"/> class.
        /// </summary>
        /// <param name="value"></param>
        public OpenApiGuid(Guid value)
            : base(value)
        {
        }

        /// <summary>
        /// The primitive class this object represents.
        /// </summary>
        public override PrimitiveType PrimitiveType { get; } = PrimitiveType.Guid;
    }
}