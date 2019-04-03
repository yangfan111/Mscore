﻿//---------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All rights reserved.
//
// File: IAcceptInsertion.cs
//
//---------------------------------------------------------------------------

namespace MS.Internal.Documents
{
    /// <summary>
    /// This interface should be implemented by <see cref="System.Windows.Documents.Table"/> related types
    /// which can hold collection of other Table related objects.
    /// to provide insertion index where item will be inserted.
    /// Refer to <see cref="IIndexedChild<TParent>"/> for additional information.
    /// For an example of usage see <see cref="TableTextElementCollectionInternal"/>
    /// </summary>
    internal interface IAcceptInsertion
    {
        /// <summary>
        /// Provides value for the index where new item will be inserted.
        /// </summary>
        int InsertionIndex
        { get; set; }
    }
}
