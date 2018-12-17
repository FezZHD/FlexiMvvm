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
using Android.Views;
using Android.Widget;
using FlexiMvvm.Bindings.Custom;
using Java.Lang;
using JetBrains.Annotations;

namespace FlexiMvvm.Bindings
{
    public static class SearchViewBindings
    {
        /// <summary>
        /// One way to source binding on <see cref="SearchView.Close"/> event.
        /// </summary>
        /// <param name="searchViewReference">The item reference.</param>
        /// <param name="trackCanExecuteCommandChanged">if set to <c>true</c> than <see cref="SearchView.Enabled"/> will be <c>false</c> when corresponding command is executing.</param>
        /// <returns>One way to source binding on <see cref="SearchView.Close"/> event.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, bool> CloseBinding(
            [NotNull] this IItemReference<SearchView> searchViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, bool, SearchView.CloseEventArgs>(
                searchViewReference,
                (searchView, eventHandler) => searchView.NotNull().Close += eventHandler,
                (searchView, eventHandler) => searchView.NotNull().Close -= eventHandler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.NotNull().Enabled = canExecuteCommand;
                    }
                },
                (searchView, eventArgs) => eventArgs.Handled,
                () => "Close");
        }

        /// <summary>
        /// One way binding on <see cref="SearchView.Iconified"/> property.
        /// </summary>
        /// <param name="searchViewReference">The item reference.</param>
        /// <returns>One way binding on <see cref="SearchView.Iconified"/> property.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, bool> IconifiedBinding(
            [NotNull] this IItemReference<SearchView> searchViewReference)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayCustomBinding<SearchView, bool>(
                searchViewReference,
                (searchView, iconified) => searchView.NotNull().Iconified = iconified,
                () => "Iconified");
        }

        /// <summary>
        /// Two way binding on <see cref="SearchView.QueryTextChange"/> event and <see cref="SearchView.SetQuery(string, bool)"/> method.
        /// </summary>
        /// <param name="searchViewReference">The item reference.</param>
        /// <param name="submit">Second parameter of <see cref="SearchView.SetQuery(string, bool)"/> method.</param>
        /// <param name="trackCanExecuteCommandChanged">if set to <c>true</c> than <see cref="SearchView.Enabled"/> will be <c>false</c> when corresponding command is executing.</param>
        /// <returns>Two way binding on <see cref="SearchView.QueryTextChange"/> event and <see cref="SearchView.SetQuery(string, bool)"/> method.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, string> QueryAndQueryTextChangeBinding(
            [NotNull] this IItemReference<SearchView> searchViewReference,
            bool submit = true,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemTwoWayCustomBinding<SearchView, string, SearchView.QueryTextChangeEventArgs>(
                searchViewReference,
                (searchView, eventHandler) => searchView.NotNull().QueryTextChange += eventHandler,
                (searchView, eventHandler) => searchView.NotNull().QueryTextChange -= eventHandler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.NotNull().Enabled = canExecuteCommand;
                    }
                },
                (searchView, eventArgs) => searchView.NotNull().Query,
                (searchView, query) => searchView.NotNull().SetQuery(query, submit),
                () => "QueryAndQueryTextChange");
        }

        /// <summary>
        /// One way binding on <see cref="SearchView.QueryRefinementEnabled"/> property.
        /// </summary>
        /// <param name="searchViewReference">The item reference.</param>
        /// <returns>One way binding on <see cref="SearchView.QueryRefinementEnabled"/> property.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, bool> QueryRefinementEnabledBinding(
            [NotNull] this IItemReference<SearchView> searchViewReference)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayCustomBinding<SearchView, bool>(
                searchViewReference,
                (searchView, queryRefinementEnabled) => searchView.NotNull().QueryRefinementEnabled = queryRefinementEnabled,
                () => "QueryRefinementEnabled");
        }

        /// <summary>
        /// One way to source binding on <see cref="SearchView.QueryTextChange"/> event.
        /// </summary>
        /// <param name="searchViewReference">The item reference.</param>
        /// <param name="trackCanExecuteCommandChanged">if set to <c>true</c> than <see cref="SearchView.Enabled"/> will be <c>false</c> when corresponding command is executing.</param>
        /// <returns>One way to source binding on <see cref="SearchView.QueryTextChange"/> event.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, string> QueryTextChangeBinding(
            [NotNull] this IItemReference<SearchView> searchViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, string, SearchView.QueryTextChangeEventArgs>(
                searchViewReference,
                (searchView, eventHandler) => searchView.NotNull().QueryTextChange += eventHandler,
                (searchView, eventHandler) => searchView.NotNull().QueryTextChange -= eventHandler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.NotNull().Enabled = canExecuteCommand;
                    }
                },
                (searchView, eventArgs) => eventArgs.NewText,
                () => "QueryTextChange");
        }

        /// <summary>
        /// One way to source binding on <see cref="SearchView.QueryTextFocusChange"/> event.
        /// </summary>
        /// <param name="searchViewReference">The item reference.</param>
        /// <param name="trackCanExecuteCommandChanged">if set to <c>true</c> than <see cref="SearchView.Enabled"/> will be <c>false</c> when corresponding command is executing.</param>
        /// <returns>One way to source binding on <see cref="SearchView.QueryTextFocusChange"/> event.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, bool> QueryTextFocusChangeBinding(
            [NotNull] this IItemReference<SearchView> searchViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, bool, View.FocusChangeEventArgs>(
                searchViewReference,
                (searchView, eventHandler) => searchView.NotNull().QueryTextFocusChange += eventHandler,
                (searchView, eventHandler) => searchView.NotNull().QueryTextFocusChange -= eventHandler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.NotNull().Enabled = canExecuteCommand;
                    }
                },
                (searchView, eventArgs) => eventArgs.HasFocus,
                () => "QueryTextFocusChange");
        }

        /// <summary>
        /// One way to source binding on <see cref="SearchView.QueryTextSubmit"/> event.
        /// </summary>
        /// <param name="searchViewReference">The item reference.</param>
        /// <param name="trackCanExecuteCommandChanged">if set to <c>true</c> than <see cref="SearchView.Enabled"/> will be <c>false</c> when corresponding command is executing.</param>
        /// <returns>One way to source binding on <see cref="SearchView.QueryTextSubmit"/> event.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, string> QueryTextSubmitBinding(
            [NotNull] this IItemReference<SearchView> searchViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, string, SearchView.QueryTextSubmitEventArgs>(
                searchViewReference,
                (searchView, eventHandler) => searchView.NotNull().QueryTextSubmit += eventHandler,
                (searchView, eventHandler) => searchView.NotNull().QueryTextSubmit -= eventHandler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.NotNull().Enabled = canExecuteCommand;
                    }
                },
                (searchView, eventArgs) => eventArgs.Query,
                () => "QueryTextSubmit");
        }

        /// <summary>
        /// One way to source binding on <see cref="SearchView.SearchClick"/> event.
        /// </summary>
        /// <param name="searchViewReference">The item reference.</param>
        /// <param name="trackCanExecuteCommandChanged">if set to <c>true</c> than <see cref="SearchView.Enabled"/> will be <c>false</c> when corresponding command is executing.</param>
        /// <returns>One way to source binding on <see cref="SearchView.SearchClick"/> event.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, object> SearchClickBinding(
            [NotNull] this IItemReference<SearchView> searchViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, object>(
                searchViewReference,
                (searchView, eventHandler) => searchView.NotNull().SearchClick += eventHandler,
                (searchView, eventHandler) => searchView.NotNull().SearchClick -= eventHandler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.NotNull().Enabled = canExecuteCommand;
                    }
                },
                searchView => null,
                () => "SearchClick");
        }

        /// <summary>
        /// One way binding on <see cref="SearchView.SetMaxWidth(int)"/> method.
        /// </summary>
        /// <param name="searchViewReference">The item reference.</param>
        /// <returns>One way binding on <see cref="SearchView.SetMaxWidth(int)"/> method.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, int> SetMaxWidthBinding(
            [NotNull] this IItemReference<SearchView> searchViewReference)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayCustomBinding<SearchView, int>(
                searchViewReference,
                (searchView, maxpixels) => searchView.NotNull().SetMaxWidth(maxpixels),
                () => "SetMaxWidth");
        }

        /// <summary>
        /// One way binding on <see cref="SearchView.SetQuery()"/> method.
        /// <para>
        /// Supported parameters: <see cref="ICharSequence"/> query; <see cref="string"/> query.
        /// </para>
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="searchViewReference">The item reference.</param>
        /// <returns>One way binding on <see cref="SearchView.SetQuery()"/> method.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        /// <exception cref="NotSupportedException">Type <see cref="TValue"/> is not supported.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, TValue> SetQueryBinding<TValue>(
            [NotNull] this IItemReference<SearchView> searchViewReference,
            bool submit = true)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayCustomBinding<SearchView, TValue>(
                searchViewReference,
                (searchView, value) =>
                {
                    switch (value)
                    {
                        case ICharSequence query:
                            searchView.NotNull().SetQuery(query, submit);
                            break;
                        case string query:
                            searchView.NotNull().SetQuery(query, submit);
                            break;
                        default:
                            throw new NotSupportedException($"\"{nameof(SetQueryBinding)}\" doesn't support \"{typeof(TValue)}\" type.");
                    }
                },
                () => "SetQuery");
        }

        /// <summary>
        /// One way binding on <see cref="SearchView.SetQueryHint()"/> method.
        /// <para>
        /// Supported parameters: <see cref="ICharSequence"/> hint; <see cref="string"/> hint.
        /// </para>
        /// </summary>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="searchViewReference">The item reference.</param>
        /// <returns>One way binding on <see cref="SearchView.SetQueryHint()"/> method.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        /// <exception cref="NotSupportedException">Type <see cref="TValue"/> is not supported.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, TValue> SetQueryHintBinding<TValue>(
            [NotNull] this IItemReference<SearchView> searchViewReference)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayCustomBinding<SearchView, TValue>(
                searchViewReference,
                (searchView, value) =>
                {
                    switch (value)
                    {
                        case ICharSequence hint:
                            searchView.NotNull().SetQueryHint(hint);
                            break;
                        case string hint:
                            searchView.NotNull().SetQueryHint(hint);
                            break;
                        default:
                            throw new NotSupportedException($"{nameof(SetQueryHintBinding)} doesn't support type {typeof(TValue)}");
                    }
                },
                () => "SetQueryHint");
        }

        /// <summary>
        /// One way binding on <see cref="SearchView.SubmitButtonEnabled"/> property.
        /// </summary>
        /// <param name="searchViewReference">The item reference.</param>
        /// <returns>One way binding on <see cref="SearchView.SubmitButtonEnabled"/> property.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, bool> SubmitButtonEnabledBinding(
            [NotNull] this IItemReference<SearchView> searchViewReference)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayCustomBinding<SearchView, bool>(
                searchViewReference,
                (searchView, submitButtonEnabled) => searchView.NotNull().SubmitButtonEnabled = submitButtonEnabled,
                () => "SubmitButtonEnabled");
        }

        /// <summary>
        /// One way to source binding on <see cref="SearchView.SuggestionClick"/> event.
        /// </summary>
        /// <param name="searchViewReference">The item reference.</param>
        /// <param name="trackCanExecuteCommandChanged">if set to <c>true</c> than <see cref="SearchView.Enabled"/> will be <c>false</c> when corresponding command is executing.</param>
        /// <returns>One way to source binding on <see cref="SearchView.SuggestionClick"/> event.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, int> SuggestionClickBinding(
            [NotNull] this IItemReference<SearchView> searchViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, int, SearchView.SuggestionClickEventArgs>(
                searchViewReference,
                (searchView, eventHandler) => searchView.NotNull().SuggestionClick += eventHandler,
                (searchView, eventHandler) => searchView.NotNull().SuggestionClick -= eventHandler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.NotNull().Enabled = canExecuteCommand;
                    }
                },
                (searchView, eventArgs) => eventArgs.Position,
                () => "SuggestionClick");
        }

        /// <summary>
        /// One way to source binding on <see cref="SearchView.SuggestionSelect"/> event.
        /// </summary>
        /// <param name="searchViewReference">The item reference.</param>
        /// <param name="trackCanExecuteCommandChanged">if set to <c>true</c> than <see cref="SearchView.Enabled"/> will be <c>false</c> when corresponding command is executing.</param>
        /// <returns>One way to source binding on <see cref="SearchView.SuggestionSelect"/> event.</returns>
        /// <exception cref="ArgumentNullException">searchViewReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<SearchView, int> SuggestionSelectBinding(
            [NotNull] this IItemReference<SearchView> searchViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, int, SearchView.SuggestionSelectEventArgs>(
                searchViewReference,
                (searchView, eventHandler) => searchView.NotNull().SuggestionSelect += eventHandler,
                (searchView, eventHandler) => searchView.NotNull().SuggestionSelect -= eventHandler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.NotNull().Enabled = canExecuteCommand;
                    }
                },
                (searchView, eventArgs) => eventArgs.Position,
                () => "SuggestionSelect");
        }
    }
}