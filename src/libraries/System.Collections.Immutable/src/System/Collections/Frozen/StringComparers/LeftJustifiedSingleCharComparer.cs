﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Collections.Frozen
{
    /// <summary>
    /// A comparer that operates over a single char of the input strings.
    /// </summary>
    /// <remarks>
    /// This comparer looks from the start of input strings.
    ///
    /// This code doesn't perform any error checks on the input as it assumes
    /// the data is always valid. This is ensured by precondition checks before
    /// a key is used to perform a dictionary lookup.
    /// </remarks>
    internal sealed class LeftJustifiedSingleCharComparer : SubstringComparerBase
    {
        public override bool Equals(string? x, string? y) => string.Equals(x, y);
        public override bool EqualsPartial(string? x, string? y) => x![Index] == y![Index];
        public override int GetHashCode(string s) => s[Index];
    }
}
