using System;
using System.Runtime.CompilerServices;

namespace Stargazer.Functional
{
    public static class PipeExtensions
    {
        public delegate TResult RefStructFunc<T, out TResult>(ref T it) where T : struct;

        public delegate void RefStructAction<T>(ref T it) where T : struct;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult Let<T, TResult>(this T @this, Func<T, TResult> func)
        {
            return func(@this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Let<T>(this T @this, Action<T> func)
        {
            func(@this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Also<T>(this T @this, Action<T> func)
        {
            func(@this);
            return @this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult Let<T, TResult>(this ref T @this, RefStructFunc<T, TResult> func) where T : struct
        {
            return func(ref @this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Let<T>(this ref T @this, RefStructAction<T> func) where T : struct
        {
            func(ref @this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Also<T>(this ref T @this, RefStructAction<T> func) where T : struct
        {
            func(ref @this);
            return @this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void To<T>(this T @this, out T returnVal)
        {
            returnVal = @this;
        }
    }
}
