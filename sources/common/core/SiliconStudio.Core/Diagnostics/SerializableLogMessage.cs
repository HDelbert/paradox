﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
using System;

namespace SiliconStudio.Core.Diagnostics
{
    /// <summary>
    /// A class that represents a copy of a <see cref="LogMessage"/> that can be serialized.
    /// </summary>
    [DataContract]
    public class SerializableLogMessage : ILogMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableLogMessage"/> class with default values for its properties.
        /// </summary>
        public SerializableLogMessage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableLogMessage"/> class from a <see cref="LogMessage"/> instance.
        /// </summary>
        /// <param name="message">The <see cref="LogMessage"/> instance to use to initialize properties.</param>
        public SerializableLogMessage(LogMessage message)
        {
            Module = message.Module;
            Type = message.Type;
            Text = message.Text;
            ExceptionInfo = message.Exception != null ? new ExceptionInfo(message.Exception) : null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableLogMessage"/> class using the given parameters to set its properties.
        /// </summary>
        /// <param name="module">The module name.</param>
        /// <param name="type">The type.</param>
        /// <param name="text">The text.</param>
        /// <param name="exceptionInfo">The exception information. This parameter can be null.</param>
        public SerializableLogMessage(string module, LogMessageType type, string text, ExceptionInfo exceptionInfo = null)
        {
            if (module == null) throw new ArgumentNullException("module");
            if (text == null) throw new ArgumentNullException("text");
            Module = module;
            Type = type;
            Text = text;
            ExceptionInfo = exceptionInfo;
        }

        /// <summary>
        /// Gets or sets the module.
        /// </summary>
        /// <remarks>
        /// The module is an identifier for a logical part of the system. It can be a class name, a namespace or a regular string not linked to a code hierarchy.
        /// </remarks>
        public string Module { get; set; }

        /// <summary>
        /// Gets or sets the type of this message.
        /// </summary>
        public LogMessageType Type { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="ExceptionInfo"/> of this message.
        /// </summary>
        public ExceptionInfo ExceptionInfo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return string.Format("[{0}]: {1}: {2}{3}", Module, Type, Text, ExceptionInfo != null ? string.Format(" Exception: {0}", ExceptionInfo.Message) : "");
        }
    }
}
