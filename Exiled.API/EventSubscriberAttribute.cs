// -----------------------------------------------------------------------
// <copyright file="EventSubscriberAttribute.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Attributes
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Used to automatically subscribe to C# events.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class EventSubscriberAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventSubscriberAttribute"/> class.
        /// Auto subscribe to a C# event.
        /// </summary>
        /// <param name="eventArgs">Event delegate to subscribe to.</param>
        public EventSubscriberAttribute(EventArgs eventArgs)
        {
        }
    }
}
