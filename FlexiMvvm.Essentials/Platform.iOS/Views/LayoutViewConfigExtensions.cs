﻿// =========================================================================
// Copyright 2019 EPAM Systems, Inc.
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

namespace FlexiMvvm.Views
{
    public static class LayoutViewConfigExtensions
    {
        private const string ThemeKey = "FlexiMvvm_Theme";

        public static TTheme GetTheme<TTheme>(this LayoutViewConfig config)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));

            return config.GetValue<TTheme>(ThemeKey);
        }

        internal static void SetTheme<TTheme>(this LayoutViewConfig config, TTheme value)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));

            config.SetValue(ThemeKey, value);
        }
    }
}
