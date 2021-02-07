﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Functional.PipeFunction
{
    public static class EnumberableExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T? FirstOrNull<T>(this IEnumerable<T> @this) where T : class
        {
            return @this.FirstOrDefault();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T? FirstOrNull<T>(this IEnumerable<T> @this, Func<T, bool> predicate) where T : class
        {
            return @this.FirstOrDefault(predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            foreach(var it in @this)
            {
                action(it);
            }
        }
    }

    public static class StructEnumberableExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T? FirstOrNull<T>(this IEnumerable<T> @this) where T : struct
        {
            return @this.Cast<T?>().FirstOrDefault();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T? FirstOrNull<T>(this IEnumerable<T?> @this) where T : struct
        {
            return @this.FirstOrDefault();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T? FirstOrNull<T>(this IEnumerable<T> @this, Func<T, bool> predicate) where T : struct
        {
            return @this.Where(predicate).Cast<T?>().FirstOrDefault();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T? FirstOrNull<T>(this IEnumerable<T?> @this, Func<T?, bool> predicate) where T : struct
        {
            return @this.FirstOrDefault(predicate);
        }
    }
}
