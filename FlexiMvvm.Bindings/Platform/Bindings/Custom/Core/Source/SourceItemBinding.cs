﻿// =========================================================================
// Copyright 2018 EPAM Systems, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// =========================================================================

using System;
using JetBrains.Annotations;

namespace FlexiMvvm.Bindings.Custom.Core.Source
{
    internal abstract class SourceItemBinding<TItem, TValue> : ItemBinding<TItem, TValue>
        where TItem : class
    {
        protected SourceItemBinding(
            [NotNull] ItemReference<TItem> itemReference,
            [NotNull] Func<string> itemValuePathAccessor)
            : base(itemReference, itemValuePathAccessor)
        {
        }

        internal void SetItemReference([NotNull] IItemReference<TItem> itemReference)
        {
            ItemReference = itemReference;
        }
    }
}
