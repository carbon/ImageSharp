﻿// <copyright file="RgbaVector.BulkOperations.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.PixelFormats
{
    using System;
    using System.Numerics;

    using ImageSharp.Memory;

    /// <content>
    /// Provides optimized overrides for bulk operations.
    /// </content>
    public partial struct RgbaVector
    {
        /// <summary>
        /// <see cref="PixelOperations{TPixel}"/> implementation optimized for <see cref="RgbaVector"/>.
        /// </summary>
        internal class PixelOperations : PixelOperations<RgbaVector>
        {
            /// <inheritdoc />
            internal override unsafe void ToVector4(Span<RgbaVector> sourceColors, Span<Vector4> destVectors, int count)
            {
                Guard.MustBeSizedAtLeast(sourceColors, count, nameof(sourceColors));
                Guard.MustBeSizedAtLeast(destVectors, count, nameof(destVectors));

                SpanHelper.Copy(sourceColors.AsBytes(), destVectors.AsBytes(), count * sizeof(Vector4));
            }
        }
    }
}