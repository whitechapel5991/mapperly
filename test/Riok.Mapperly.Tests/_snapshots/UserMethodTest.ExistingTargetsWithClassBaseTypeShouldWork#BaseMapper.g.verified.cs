﻿//HintName: BaseMapper.g.cs
// <auto-generated />
#nullable enable
public partial class BaseMapper
{
    protected partial void MyIntToShortMapping(global::System.Collections.Generic.List<int> src, global::System.Collections.Generic.List<short> dst)
    {
        dst.EnsureCapacity(src.Count + dst.Count);
        foreach (var item in src)
        {
            dst.Add((short)item);
        }
    }
}