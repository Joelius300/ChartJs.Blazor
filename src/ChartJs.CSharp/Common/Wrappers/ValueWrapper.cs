
namespace ChartJs.Common.Wrappers
{
    public abstract class ValueWrapper<TData> where TData : struct
    {
        internal TData Value { get; }

        internal ValueWrapper(TData value) => Value = value;
    }
}
