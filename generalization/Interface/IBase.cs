using System;

namespace generalization
{
    internal interface IBase<T>
    {
        T RandomValue();
        T UserValue();
    }
}