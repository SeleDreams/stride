﻿// Copyright (c) Stride contributors (https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using Stride.Core;
using Stride.Core.Annotations;
using Stride.Shaders;

namespace Stride.Rendering.Materials
{
    /// <summary>
    /// Uses the tangent vector as the hair direction.
    /// </summary>
    [DataContract("MaterialHairDirectionFunctionTangent")]
    [Display("Tangent")]
    public class MaterialHairDirectionFunctionTangent : IMaterialHairDirectionFunction
    {
        public ShaderSource Generate(MaterialGeneratorContext context)
        {
            return new ShaderClassSource("MaterialHairDirectionFunctionTangent");
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is MaterialHairDirectionFunctionTangent;
        }

        public override int GetHashCode()
        {
            return typeof(MaterialHairDirectionFunctionTangent).GetHashCode();
        }
    }
}
