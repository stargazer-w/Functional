using System;
using System.Runtime.CompilerServices;

namespace Stargazer.Functional
{
    public static class FunctionalTools
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, TResult>> Currying<T1, T2, TResult>(Func<T1, T2, TResult> func)
        {
            return p1 => p2 => func(p1, p2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, TResult>>> Currying<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> func)
        {
            return p1 => p2 => p3 => func(p1, p2, p3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> Currying<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> func)
        {
            return p1 => p2 => p3 => p4 => func(p1, p2, p3, p4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>> Currying<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> func)
        {
            return p1 => p2 => p3 => p4 => p5 => func(p1, p2, p3, p4, p5);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>> Currying<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> func)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => func(p1, p2, p3, p4, p5, p6);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>> Currying<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> func)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => p7 => func(p1, p2, p3, p4, p5, p6, p7);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>> Currying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => func(p1, p2, p3, p4, p5, p6, p7, p8);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => p13 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => p13 => p14 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => p13 => p14 => p15 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>>>> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func)
        {
            return p1 => p2 => p3 => p4 => p5 => p6 => p7 => p8 => p9 => p10 => p11 => p12 => p13 => p14 => p15 => p16 => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, TResult> Currying<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 p1)
        {
            return (p2) => func(p1, p2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, TResult> Currying<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 p1)
        {
            return (p2, p3) => func(p1, p2, p3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, TResult> Currying<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 p1, T2 p2)
        {
            return (p3) => func(p1, p2, p3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, T4, TResult> Currying<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 p1)
        {
            return (p2, p3, p4) => func(p1, p2, p3, p4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, T4, TResult> Currying<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 p1, T2 p2)
        {
            return (p3, p4) => func(p1, p2, p3, p4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T4, TResult> Currying<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 p1, T2 p2, T3 p3)
        {
            return (p4) => func(p1, p2, p3, p4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, T4, T5, TResult> Currying<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 p1)
        {
            return (p2, p3, p4, p5) => func(p1, p2, p3, p4, p5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, T4, T5, TResult> Currying<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 p1, T2 p2)
        {
            return (p3, p4, p5) => func(p1, p2, p3, p4, p5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T4, T5, TResult> Currying<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 p1, T2 p2, T3 p3)
        {
            return (p4, p5) => func(p1, p2, p3, p4, p5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T5, TResult> Currying<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return (p5) => func(p1, p2, p3, p4, p5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, T4, T5, T6, TResult> Currying<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 p1)
        {
            return (p2, p3, p4, p5, p6) => func(p1, p2, p3, p4, p5, p6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, T4, T5, T6, TResult> Currying<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 p1, T2 p2)
        {
            return (p3, p4, p5, p6) => func(p1, p2, p3, p4, p5, p6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T4, T5, T6, TResult> Currying<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 p1, T2 p2, T3 p3)
        {
            return (p4, p5, p6) => func(p1, p2, p3, p4, p5, p6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T5, T6, TResult> Currying<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return (p5, p6) => func(p1, p2, p3, p4, p5, p6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T6, TResult> Currying<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            return (p6) => func(p1, p2, p3, p4, p5, p6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, T4, T5, T6, T7, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 p1)
        {
            return (p2, p3, p4, p5, p6, p7) => func(p1, p2, p3, p4, p5, p6, p7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, T4, T5, T6, T7, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 p1, T2 p2)
        {
            return (p3, p4, p5, p6, p7) => func(p1, p2, p3, p4, p5, p6, p7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T4, T5, T6, T7, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 p1, T2 p2, T3 p3)
        {
            return (p4, p5, p6, p7) => func(p1, p2, p3, p4, p5, p6, p7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T5, T6, T7, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return (p5, p6, p7) => func(p1, p2, p3, p4, p5, p6, p7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T6, T7, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            return (p6, p7) => func(p1, p2, p3, p4, p5, p6, p7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T7, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            return (p7) => func(p1, p2, p3, p4, p5, p6, p7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, T4, T5, T6, T7, T8, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 p1)
        {
            return (p2, p3, p4, p5, p6, p7, p8) => func(p1, p2, p3, p4, p5, p6, p7, p8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, T4, T5, T6, T7, T8, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 p1, T2 p2)
        {
            return (p3, p4, p5, p6, p7, p8) => func(p1, p2, p3, p4, p5, p6, p7, p8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T4, T5, T6, T7, T8, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 p1, T2 p2, T3 p3)
        {
            return (p4, p5, p6, p7, p8) => func(p1, p2, p3, p4, p5, p6, p7, p8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T5, T6, T7, T8, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return (p5, p6, p7, p8) => func(p1, p2, p3, p4, p5, p6, p7, p8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T6, T7, T8, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            return (p6, p7, p8) => func(p1, p2, p3, p4, p5, p6, p7, p8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T7, T8, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            return (p7, p8) => func(p1, p2, p3, p4, p5, p6, p7, p8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T8, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            return (p8) => func(p1, p2, p3, p4, p5, p6, p7, p8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 p1)
        {
            return (p2, p3, p4, p5, p6, p7, p8, p9) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, T4, T5, T6, T7, T8, T9, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 p1, T2 p2)
        {
            return (p3, p4, p5, p6, p7, p8, p9) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T4, T5, T6, T7, T8, T9, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 p1, T2 p2, T3 p3)
        {
            return (p4, p5, p6, p7, p8, p9) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T5, T6, T7, T8, T9, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return (p5, p6, p7, p8, p9) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T6, T7, T8, T9, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            return (p6, p7, p8, p9) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T7, T8, T9, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            return (p7, p8, p9) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T8, T9, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            return (p8, p9) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T9, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            return (p9) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 p1)
        {
            return (p2, p3, p4, p5, p6, p7, p8, p9, p10) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 p1, T2 p2)
        {
            return (p3, p4, p5, p6, p7, p8, p9, p10) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T4, T5, T6, T7, T8, T9, T10, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 p1, T2 p2, T3 p3)
        {
            return (p4, p5, p6, p7, p8, p9, p10) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T5, T6, T7, T8, T9, T10, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return (p5, p6, p7, p8, p9, p10) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T6, T7, T8, T9, T10, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            return (p6, p7, p8, p9, p10) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T7, T8, T9, T10, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            return (p7, p8, p9, p10) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T8, T9, T10, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            return (p8, p9, p10) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T9, T10, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            return (p9, p10) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T10, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            return (p10) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 p1)
        {
            return (p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 p1, T2 p2)
        {
            return (p3, p4, p5, p6, p7, p8, p9, p10, p11) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 p1, T2 p2, T3 p3)
        {
            return (p4, p5, p6, p7, p8, p9, p10, p11) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T5, T6, T7, T8, T9, T10, T11, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return (p5, p6, p7, p8, p9, p10, p11) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T6, T7, T8, T9, T10, T11, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            return (p6, p7, p8, p9, p10, p11) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T7, T8, T9, T10, T11, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            return (p7, p8, p9, p10, p11) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T8, T9, T10, T11, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            return (p8, p9, p10, p11) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T9, T10, T11, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            return (p9, p10, p11) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T10, T11, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            return (p10, p11) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T11, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            return (p11) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 p1)
        {
            return (p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 p1, T2 p2)
        {
            return (p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 p1, T2 p2, T3 p3)
        {
            return (p4, p5, p6, p7, p8, p9, p10, p11, p12) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return (p5, p6, p7, p8, p9, p10, p11, p12) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T6, T7, T8, T9, T10, T11, T12, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            return (p6, p7, p8, p9, p10, p11, p12) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T7, T8, T9, T10, T11, T12, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            return (p7, p8, p9, p10, p11, p12) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T8, T9, T10, T11, T12, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            return (p8, p9, p10, p11, p12) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T9, T10, T11, T12, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            return (p9, p10, p11, p12) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T10, T11, T12, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            return (p10, p11, p12) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T11, T12, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            return (p11, p12) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T12, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            return (p12) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 p1)
        {
            return (p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 p1, T2 p2)
        {
            return (p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 p1, T2 p2, T3 p3)
        {
            return (p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return (p5, p6, p7, p8, p9, p10, p11, p12, p13) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            return (p6, p7, p8, p9, p10, p11, p12, p13) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T7, T8, T9, T10, T11, T12, T13, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            return (p7, p8, p9, p10, p11, p12, p13) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T8, T9, T10, T11, T12, T13, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            return (p8, p9, p10, p11, p12, p13) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T9, T10, T11, T12, T13, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            return (p9, p10, p11, p12, p13) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T10, T11, T12, T13, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            return (p10, p11, p12, p13) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T11, T12, T13, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            return (p11, p12, p13) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T12, T13, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            return (p12, p13) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T13, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            return (p13) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 p1)
        {
            return (p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 p1, T2 p2)
        {
            return (p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 p1, T2 p2, T3 p3)
        {
            return (p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return (p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            return (p6, p7, p8, p9, p10, p11, p12, p13, p14) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            return (p7, p8, p9, p10, p11, p12, p13, p14) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T8, T9, T10, T11, T12, T13, T14, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            return (p8, p9, p10, p11, p12, p13, p14) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T9, T10, T11, T12, T13, T14, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            return (p9, p10, p11, p12, p13, p14) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T10, T11, T12, T13, T14, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            return (p10, p11, p12, p13, p14) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T11, T12, T13, T14, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            return (p11, p12, p13, p14) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T12, T13, T14, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            return (p12, p13, p14) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T13, T14, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            return (p13, p14) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T14, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            return (p14) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1)
        {
            return (p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1, T2 p2)
        {
            return (p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1, T2 p2, T3 p3)
        {
            return (p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return (p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            return (p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            return (p7, p8, p9, p10, p11, p12, p13, p14, p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            return (p8, p9, p10, p11, p12, p13, p14, p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T9, T10, T11, T12, T13, T14, T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            return (p9, p10, p11, p12, p13, p14, p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T10, T11, T12, T13, T14, T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            return (p10, p11, p12, p13, p14, p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T11, T12, T13, T14, T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            return (p11, p12, p13, p14, p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T12, T13, T14, T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            return (p12, p13, p14, p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T13, T14, T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            return (p13, p14, p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T14, T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            return (p14, p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T15, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14)
        {
            return (p15) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1)
        {
            return (p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2)
        {
            return (p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2, T3 p3)
        {
            return (p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return (p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            return (p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            return (p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            return (p8, p9, p10, p11, p12, p13, p14, p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            return (p9, p10, p11, p12, p13, p14, p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T10, T11, T12, T13, T14, T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9)
        {
            return (p10, p11, p12, p13, p14, p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T11, T12, T13, T14, T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
        {
            return (p11, p12, p13, p14, p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T12, T13, T14, T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11)
        {
            return (p12, p13, p14, p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T13, T14, T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
        {
            return (p13, p14, p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T14, T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13)
        {
            return (p14, p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T15, T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14)
        {
            return (p15, p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T16, TResult> Currying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15)
        {
            return (p16) => func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
        }



        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, TResult>(this Func<T1, T2, TResult> func, in (T1, T2) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3, T4) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3, T4, T5) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3, T4, T5, T6) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3, T4, T5, T6, T7) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3, T4) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3, T4, T5) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3, T4, T5, T6) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3, T4, T5, T6, T7) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, in (T1, T2, T3, T4) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, TResult> func, in (T1, T2, T3, T4, T5) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, TResult> func, in (T1, T2, T3, T4, T5, T6) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, TResult> func, in (T1, T2, T3, T4, T5, T6, T7) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, in (T1, T2, T3, T4, T5) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, in (T1, T2, T3, T4, T5, T6) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, in (T1, T2, T3, T4, T5, T6, T7) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, in (T1, T2, T3, T4, T5, T6) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, in (T1, T2, T3, T4, T5, T6, T7) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, in (T1, T2, T3, T4, T5, T6, T7) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12, args.Item13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12, args.Item13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12, args.Item13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12, args.Item13);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12, args.Item13, args.Item14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12, args.Item13, args.Item14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12, args.Item13, args.Item14);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12, args.Item13, args.Item14, args.Item15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12, args.Item13, args.Item14, args.Item15);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult CallWithArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, in (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) args)
        {
            return func(args.Item1, args.Item2, args.Item3, args.Item4, args.Item5, args.Item6, args.Item7, args.Item8, args.Item9, args.Item10, args.Item11, args.Item12, args.Item13, args.Item14, args.Item15, args.Item16);
        }


        public delegate void Deconstructor<T1, T2>(out T1 item11, out T2 item12);
        public delegate void Deconstructor<T1, T2, T3>(out T1 item11, out T2 item12, out T3 item13);
        public delegate void Deconstructor<T1, T2, T3, T4>(out T1 item11, out T2 item12, out T3 item13, out T4 item14);
        public delegate void Deconstructor<T1, T2, T3, T4, T5>(out T1 item11, out T2 item12, out T3 item13, out T4 item14, out T5 item15);
        public delegate void Deconstructor<T1, T2, T3, T4, T5, T6>(out T1 item11, out T2 item12, out T3 item13, out T4 item14, out T5 item15, out T6 item16);
        public delegate void Deconstructor<T1, T2, T3, T4, T5, T6, T7>(out T1 item11, out T2 item12, out T3 item13, out T4 item14, out T5 item15, out T6 item16, out T7 item17);
        public delegate void Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8>(out T1 item11, out T2 item12, out T3 item13, out T4 item14, out T5 item15, out T6 item16, out T7 item17, out T8 item18);
        public delegate void Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9>(out T1 item11, out T2 item12, out T3 item13, out T4 item14, out T5 item15, out T6 item16, out T7 item17, out T8 item18, out T9 item19);
        public delegate void Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(out T1 item11, out T2 item12, out T3 item13, out T4 item14, out T5 item15, out T6 item16, out T7 item17, out T8 item18, out T9 item19, out T10 item110);
        public delegate void Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(out T1 item11, out T2 item12, out T3 item13, out T4 item14, out T5 item15, out T6 item16, out T7 item17, out T8 item18, out T9 item19, out T10 item110, out T11 item111);
        public delegate void Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(out T1 item11, out T2 item12, out T3 item13, out T4 item14, out T5 item15, out T6 item16, out T7 item17, out T8 item18, out T9 item19, out T10 item110, out T11 item111, out T12 item112);
        public delegate void Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(out T1 item11, out T2 item12, out T3 item13, out T4 item14, out T5 item15, out T6 item16, out T7 item17, out T8 item18, out T9 item19, out T10 item110, out T11 item111, out T12 item112, out T13 item113);
        public delegate void Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(out T1 item11, out T2 item12, out T3 item13, out T4 item14, out T5 item15, out T6 item16, out T7 item17, out T8 item18, out T9 item19, out T10 item110, out T11 item111, out T12 item112, out T13 item113, out T14 item114);
        public delegate void Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(out T1 item11, out T2 item12, out T3 item13, out T4 item14, out T5 item15, out T6 item16, out T7 item17, out T8 item18, out T9 item19, out T10 item110, out T11 item111, out T12 item112, out T13 item113, out T14 item114, out T15 item115);
        public delegate void Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(out T1 item11, out T2 item12, out T3 item13, out T4 item14, out T5 item15, out T6 item16, out T7 item17, out T8 item18, out T9 item19, out T10 item110, out T11 item111, out T12 item112, out T13 item113, out T14 item114, out T15 item115, out T16 item116);


        public static (T1, T2) ToTuple<T1, T2>(Deconstructor<T1, T2> deconstructor)
        {
            deconstructor(out var i1, out var i2);
            return (i1, i2);
        }


        public static (T1, T2, T3) ToTuple<T1, T2, T3>(Deconstructor<T1, T2, T3> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3);
            return (i1, i2, i3);
        }


        public static (T1, T2, T3, T4) ToTuple<T1, T2, T3, T4>(Deconstructor<T1, T2, T3, T4> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3, out var i4);
            return (i1, i2, i3, i4);
        }


        public static (T1, T2, T3, T4, T5) ToTuple<T1, T2, T3, T4, T5>(Deconstructor<T1, T2, T3, T4, T5> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3, out var i4, out var i5);
            return (i1, i2, i3, i4, i5);
        }


        public static (T1, T2, T3, T4, T5, T6) ToTuple<T1, T2, T3, T4, T5, T6>(Deconstructor<T1, T2, T3, T4, T5, T6> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3, out var i4, out var i5, out var i6);
            return (i1, i2, i3, i4, i5, i6);
        }


        public static (T1, T2, T3, T4, T5, T6, T7) ToTuple<T1, T2, T3, T4, T5, T6, T7>(Deconstructor<T1, T2, T3, T4, T5, T6, T7> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3, out var i4, out var i5, out var i6, out var i7);
            return (i1, i2, i3, i4, i5, i6, i7);
        }


        public static (T1, T2, T3, T4, T5, T6, T7, T8) ToTuple<T1, T2, T3, T4, T5, T6, T7, T8>(Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3, out var i4, out var i5, out var i6, out var i7, out var i8);
            return (i1, i2, i3, i4, i5, i6, i7, i8);
        }


        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9) ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3, out var i4, out var i5, out var i6, out var i7, out var i8, out var i9);
            return (i1, i2, i3, i4, i5, i6, i7, i8, i9);
        }


        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3, out var i4, out var i5, out var i6, out var i7, out var i8, out var i9, out var i10);
            return (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10);
        }


        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3, out var i4, out var i5, out var i6, out var i7, out var i8, out var i9, out var i10, out var i11);
            return (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11);
        }


        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3, out var i4, out var i5, out var i6, out var i7, out var i8, out var i9, out var i10, out var i11, out var i12);
            return (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12);
        }


        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3, out var i4, out var i5, out var i6, out var i7, out var i8, out var i9, out var i10, out var i11, out var i12, out var i13);
            return (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13);
        }


        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3, out var i4, out var i5, out var i6, out var i7, out var i8, out var i9, out var i10, out var i11, out var i12, out var i13, out var i14);
            return (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14);
        }


        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3, out var i4, out var i5, out var i6, out var i7, out var i8, out var i9, out var i10, out var i11, out var i12, out var i13, out var i14, out var i15);
            return (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15);
        }


        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Deconstructor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> deconstructor)
        {
            deconstructor(out var i1, out var i2, out var i3, out var i4, out var i5, out var i6, out var i7, out var i8, out var i9, out var i10, out var i11, out var i12, out var i13, out var i14, out var i15, out var i16);
            return (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16);
        }
    }
}
