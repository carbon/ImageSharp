﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

// <auto-generated />
namespace SixLabors.ImageSharp.PixelFormats
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    /// <content>
    /// Provides optimized overrides for bulk operations.
    /// </content>
    public partial struct Bgra32
    {

        /// <summary>
        /// Provides optimized overrides for bulk operations.
        /// </summary>
        internal class PixelOperations : PixelOperations<Bgra32>
        {
            /// <inheritdoc />
            internal override void FromBgra32(ReadOnlySpan<Bgra32> source, Span<Bgra32> destPixels, int count)
            {
                GuardSpans(source, nameof(source), destPixels, nameof(destPixels), count);

                source.Slice(0, count).CopyTo(destPixels);
            }

            /// <inheritdoc />
            internal override void ToBgra32(ReadOnlySpan<Bgra32> sourcePixels, Span<Bgra32> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                sourcePixels.Slice(0, count).CopyTo(destPixels);
            }

			
			/// <inheritdoc />
            internal override void ToArgb32(ReadOnlySpan<Bgra32> sourcePixels, Span<Argb32> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Argb32 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Argb32 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToBgr24(ReadOnlySpan<Bgra32> sourcePixels, Span<Bgr24> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Bgr24 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Bgr24 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToGray8(ReadOnlySpan<Bgra32> sourcePixels, Span<Gray8> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Gray8 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Gray8 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToGray16(ReadOnlySpan<Bgra32> sourcePixels, Span<Gray16> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Gray16 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Gray16 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToRgb24(ReadOnlySpan<Bgra32> sourcePixels, Span<Rgb24> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Rgb24 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Rgb24 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToRgba32(ReadOnlySpan<Bgra32> sourcePixels, Span<Rgba32> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Rgba32 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Rgba32 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToRgb48(ReadOnlySpan<Bgra32> sourcePixels, Span<Rgb48> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Rgb48 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Rgb48 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
		
			/// <inheritdoc />
            internal override void ToRgba64(ReadOnlySpan<Bgra32> sourcePixels, Span<Rgba64> destPixels, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), destPixels, nameof(destPixels), count);

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Rgba64 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Rgba64 dp = ref Unsafe.Add(ref destRef, i);

                    dp.FromBgra32(sp);
                }
            }
		
		}
	}
}