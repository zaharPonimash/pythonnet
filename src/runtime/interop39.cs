
// Auto-generated by geninterop.py.
// DO NOT MODIFY BY HAND.


#if PYTHON39
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Text;

namespace Python.Runtime
{

    [StructLayout(LayoutKind.Sequential)]
    internal static partial class TypeOffset
    {
        // Auto-generated from PyHeapTypeObject in Python.h
        public static int am_await = 0;
        public static int am_aiter = 0;
        public static int am_anext = 0;
        public static int nb_add = 0;
        public static int nb_subtract = 0;
        public static int nb_multiply = 0;
        public static int nb_remainder = 0;
        public static int nb_divmod = 0;
        public static int nb_power = 0;
        public static int nb_negative = 0;
        public static int nb_positive = 0;
        public static int nb_absolute = 0;
        public static int nb_bool = 0;
        public static int nb_invert = 0;
        public static int nb_lshift = 0;
        public static int nb_rshift = 0;
        public static int nb_and = 0;
        public static int nb_xor = 0;
        public static int nb_or = 0;
        public static int nb_int = 0;
        public static int nb_reserved = 0;
        public static int nb_float = 0;
        public static int nb_inplace_add = 0;
        public static int nb_inplace_subtract = 0;
        public static int nb_inplace_multiply = 0;
        public static int nb_inplace_remainder = 0;
        public static int nb_inplace_power = 0;
        public static int nb_inplace_lshift = 0;
        public static int nb_inplace_rshift = 0;
        public static int nb_inplace_and = 0;
        public static int nb_inplace_xor = 0;
        public static int nb_inplace_or = 0;
        public static int nb_floor_divide = 0;
        public static int nb_true_divide = 0;
        public static int nb_inplace_floor_divide = 0;
        public static int nb_inplace_true_divide = 0;
        public static int nb_index = 0;
        public static int nb_matrix_multiply = 0;
        public static int nb_inplace_matrix_multiply = 0;
        public static int mp_length = 0;
        public static int mp_subscript = 0;
        public static int mp_ass_subscript = 0;
        public static int sq_length = 0;
        public static int sq_concat = 0;
        public static int sq_repeat = 0;
        public static int sq_item = 0;
        public static int was_sq_slice = 0;
        public static int sq_ass_item = 0;
        public static int was_sq_ass_slice = 0;
        public static int sq_contains = 0;
        public static int sq_inplace_concat = 0;
        public static int sq_inplace_repeat = 0;
        public static int bf_getbuffer = 0;
        public static int bf_releasebuffer = 0;
        public static int name = 0;
        public static int ht_slots = 0;
        public static int qualname = 0;
        public static int ht_cached_keys = 0;
        public static int ht_module = 0;

        /* here are optional user slots, followed by the members. */
        public static int members = 0;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct PyNumberMethods
    {
        public IntPtr nb_add;
        public IntPtr nb_subtract;
        public IntPtr nb_multiply;
        public IntPtr nb_remainder;
        public IntPtr nb_divmod;
        public IntPtr nb_power;
        public IntPtr nb_negative;
        public IntPtr nb_positive;
        public IntPtr nb_absolute;
        public IntPtr nb_bool;
        public IntPtr nb_invert;
        public IntPtr nb_lshift;
        public IntPtr nb_rshift;
        public IntPtr nb_and;
        public IntPtr nb_xor;
        public IntPtr nb_or;
        public IntPtr nb_int;
        public IntPtr nb_reserved;
        public IntPtr nb_float;
        public IntPtr nb_inplace_add;
        public IntPtr nb_inplace_subtract;
        public IntPtr nb_inplace_multiply;
        public IntPtr nb_inplace_remainder;
        public IntPtr nb_inplace_power;
        public IntPtr nb_inplace_lshift;
        public IntPtr nb_inplace_rshift;
        public IntPtr nb_inplace_and;
        public IntPtr nb_inplace_xor;
        public IntPtr nb_inplace_or;
        public IntPtr nb_floor_divide;
        public IntPtr nb_true_divide;
        public IntPtr nb_inplace_floor_divide;
        public IntPtr nb_inplace_true_divide;
        public IntPtr nb_index;
        public IntPtr nb_matrix_multiply;
        public IntPtr nb_inplace_matrix_multiply;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct PySequenceMethods
    {
        public IntPtr sq_length;
        public IntPtr sq_concat;
        public IntPtr sq_repeat;
        public IntPtr sq_item;
        public IntPtr was_sq_slice;
        public IntPtr sq_ass_item;
        public IntPtr was_sq_ass_slice;
        public IntPtr sq_contains;
        public IntPtr sq_inplace_concat;
        public IntPtr sq_inplace_repeat;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct PyMappingMethods
    {
        public IntPtr mp_length;
        public IntPtr mp_subscript;
        public IntPtr mp_ass_subscript;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct PyAsyncMethods
    {
        public IntPtr am_await;
        public IntPtr am_aiter;
        public IntPtr am_anext;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct PyBufferProcs
    {
        public IntPtr bf_getbuffer;
        public IntPtr bf_releasebuffer;
    }

    internal static partial class SlotTypes
    {
        public static readonly Type[] Types = {
            typeof(PyNumberMethods),
            typeof(PySequenceMethods),
            typeof(PyMappingMethods),
            typeof(PyAsyncMethods),
            typeof(PyBufferProcs),
        };
    }

}
#endif

