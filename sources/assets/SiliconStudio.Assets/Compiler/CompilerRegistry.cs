﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System;
using System.Collections.Generic;

using SiliconStudio.Core;

namespace SiliconStudio.Assets.Compiler
{
    /// <summary>
    /// A registry containing the compiler associated to all the asset types
    /// </summary>
    /// <typeparam name="T">The type of the class implementing the <see cref="IAssetCompiler"/> interface to register.</typeparam>
    public class CompilerRegistry<T> where T: class, IAssetCompiler
    {
        private readonly Dictionary<Type, T> typeToCompiler = new Dictionary<Type, T>();

        /// <summary>
        /// Gets or sets the default compiler to use when no compiler are explicitly registered for a type.
        /// </summary>
        public T DefaultCompiler { get; set; } 

        /// <summary>
        /// Register a compiler for a given <see cref="Asset"/> type.
        /// </summary>
        /// <param name="type">The type of asset the compiler can compile</param>
        /// <param name="compiler">The compiler to use</param>
        public void RegisterCompiler(Type type, T compiler)
        {
            if (compiler == null) throw new ArgumentNullException("compiler");

            AssertAssetType(type);

            typeToCompiler[type] = compiler;
        }

        /// <summary>
        /// Gets the compiler associated to an <see cref="Asset"/> type.
        /// </summary>
        /// <param name="type">The type of the <see cref="Asset"/></param>
        /// <returns>The compiler associated the provided asset type or null if no compiler exists for that type.</returns>
        public T GetCompiler(Type type)
        {
            AssertAssetType(type);

            if (!typeToCompiler.ContainsKey(type))
                return DefaultCompiler;

            return typeToCompiler[type];
        }

        private static void AssertAssetType(Type assetType)
        {
            if (assetType == null)
                throw new ArgumentNullException("assetType");

            if (!typeof(Asset).IsAssignableFrom(assetType))
                throw new ArgumentException("Type [{0}] must be assignable to Asset".ToFormat(assetType), "assetType");
        }
    }
}
