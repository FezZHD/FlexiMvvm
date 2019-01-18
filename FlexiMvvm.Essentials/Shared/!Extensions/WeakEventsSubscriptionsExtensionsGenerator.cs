﻿// <auto-generated />
// =========================================================================
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

using System.Collections.Specialized;
using System.ComponentModel;
using System;
using FlexiMvvm.Weak.Subscriptions;

namespace FlexiMvvm
{
    /// <summary>Provides a set of static methods for weak subscriptions on <see cref="INotifyPropertyChanged"/> class events.</summary>
    public static class NotifyPropertyChangedWeakEventsSubscriptionsExtensions
    {
        /// <summary>Weak subscription on <see cref="INotifyPropertyChanged.PropertyChanged"/> event.</summary>
        /// <returns>Weak event subscription instance.</returns>
        /// <param name="eventSource">The source of the event.</param>
        /// <param name="eventHandler">Represents the method that will handle the <see cref="INotifyPropertyChanged.PropertyChanged"/> event.</param>
        /// <exception cref="ArgumentNullException"><paramref name="eventSource" /> is null.-or-<paramref name="eventHandler" /> is null.</exception>
        public static IDisposable PropertyChangedWeakSubscribe(
            this INotifyPropertyChanged eventSource,
            EventHandler<PropertyChangedEventArgs> eventHandler)
        {
            if (eventSource == null)
                throw new ArgumentNullException(nameof(eventSource));
            if (eventHandler == null)
                throw new ArgumentNullException(nameof(eventHandler));

            return new PropertyChangedEventHandlerWeakEventSubscription<INotifyPropertyChanged>(
                eventSource,
                (source, handler) => source.PropertyChanged += handler,
                (source, handler) => source.PropertyChanged -= handler,
                eventHandler);
        }

        private sealed class PropertyChangedEventHandlerWeakEventSubscription<TEventSource> : WeakEventSubscription<TEventSource, PropertyChangedEventArgs>
            where TEventSource : class
        {
            private readonly Action<TEventSource, PropertyChangedEventHandler> _subscribeToEvent;
            private readonly Action<TEventSource, PropertyChangedEventHandler> _unsubscribeFromEvent;
        
            public PropertyChangedEventHandlerWeakEventSubscription(
                TEventSource eventSource,
                Action<TEventSource, PropertyChangedEventHandler> subscribeToEvent,
                Action<TEventSource, PropertyChangedEventHandler> unsubscribeFromEvent,
                EventHandler<PropertyChangedEventArgs> eventHandler)
                : base(eventSource, eventHandler)
            {
                _subscribeToEvent = subscribeToEvent ?? throw new ArgumentNullException(nameof(subscribeToEvent));
                _unsubscribeFromEvent = unsubscribeFromEvent ?? throw new ArgumentNullException(nameof(unsubscribeFromEvent));
        
                SubscribeToEvent();
            }
        
            protected override void SubscribeToEvent(TEventSource eventSource)
            {
                if (eventSource == null)
                    throw new ArgumentNullException(nameof(eventSource));
        
                _subscribeToEvent(eventSource, OnSourceEvent);
            }
        
            protected override void UnsubscribeFromEvent(TEventSource eventSource)
            {
                if (eventSource == null)
                    throw new ArgumentNullException(nameof(eventSource));
        
                _unsubscribeFromEvent(eventSource, OnSourceEvent);
            }
        }

    }
}

namespace FlexiMvvm
{
    /// <summary>Provides a set of static methods for weak subscriptions on <see cref="INotifyCollectionChanged"/> class events.</summary>
    public static class NotifyCollectionChangedWeakEventsSubscriptionsExtensions
    {
        /// <summary>Weak subscription on <see cref="INotifyCollectionChanged.CollectionChanged"/> event.</summary>
        /// <returns>Weak event subscription instance.</returns>
        /// <param name="eventSource">The source of the event.</param>
        /// <param name="eventHandler">Represents the method that will handle the <see cref="INotifyCollectionChanged.CollectionChanged"/> event.</param>
        /// <exception cref="ArgumentNullException"><paramref name="eventSource" /> is null.-or-<paramref name="eventHandler" /> is null.</exception>
        public static IDisposable CollectionChangedWeakSubscribe(
            this INotifyCollectionChanged eventSource,
            EventHandler<NotifyCollectionChangedEventArgs> eventHandler)
        {
            if (eventSource == null)
                throw new ArgumentNullException(nameof(eventSource));
            if (eventHandler == null)
                throw new ArgumentNullException(nameof(eventHandler));

            return new NotifyCollectionChangedEventHandlerWeakEventSubscription<INotifyCollectionChanged>(
                eventSource,
                (source, handler) => source.CollectionChanged += handler,
                (source, handler) => source.CollectionChanged -= handler,
                eventHandler);
        }

        private sealed class NotifyCollectionChangedEventHandlerWeakEventSubscription<TEventSource> : WeakEventSubscription<TEventSource, NotifyCollectionChangedEventArgs>
            where TEventSource : class
        {
            private readonly Action<TEventSource, NotifyCollectionChangedEventHandler> _subscribeToEvent;
            private readonly Action<TEventSource, NotifyCollectionChangedEventHandler> _unsubscribeFromEvent;
        
            public NotifyCollectionChangedEventHandlerWeakEventSubscription(
                TEventSource eventSource,
                Action<TEventSource, NotifyCollectionChangedEventHandler> subscribeToEvent,
                Action<TEventSource, NotifyCollectionChangedEventHandler> unsubscribeFromEvent,
                EventHandler<NotifyCollectionChangedEventArgs> eventHandler)
                : base(eventSource, eventHandler)
            {
                _subscribeToEvent = subscribeToEvent ?? throw new ArgumentNullException(nameof(subscribeToEvent));
                _unsubscribeFromEvent = unsubscribeFromEvent ?? throw new ArgumentNullException(nameof(unsubscribeFromEvent));
        
                SubscribeToEvent();
            }
        
            protected override void SubscribeToEvent(TEventSource eventSource)
            {
                if (eventSource == null)
                    throw new ArgumentNullException(nameof(eventSource));
        
                _subscribeToEvent(eventSource, OnSourceEvent);
            }
        
            protected override void UnsubscribeFromEvent(TEventSource eventSource)
            {
                if (eventSource == null)
                    throw new ArgumentNullException(nameof(eventSource));
        
                _unsubscribeFromEvent(eventSource, OnSourceEvent);
            }
        }

    }
}
