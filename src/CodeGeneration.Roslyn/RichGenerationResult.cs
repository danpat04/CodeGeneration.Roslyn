﻿// Copyright (c) Andrew Arnott. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace CodeGeneration.Roslyn
{
    using System.Diagnostics;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp.Syntax;

    /// <summary>
    /// Contains <see cref="CompilationUnitSyntax"/> additions generated by the <see cref="IRichCodeGenerator"/>.
    /// </summary>
    public struct RichGenerationResult
    {
        /// <summary>
        /// Gets or sets the <see cref="MemberDeclarationSyntax"/> to add to generated <see cref="CompilationUnitSyntax"/>.
        /// </summary>
        public SyntaxList<MemberDeclarationSyntax> Members { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="UsingDirectiveSyntax"/> to add to generated <see cref="CompilationUnitSyntax"/>.
        /// </summary>
        public SyntaxList<UsingDirectiveSyntax> Usings { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="ExternAliasDirectiveSyntax"/> to add to generated <see cref="CompilationUnitSyntax"/>.
        /// </summary>
        public SyntaxList<ExternAliasDirectiveSyntax> Externs { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="AttributeListSyntax"/> to add to generated <see cref="CompilationUnitSyntax"/>.
        /// </summary>
        public SyntaxList<AttributeListSyntax> AttributeLists { get; set; }
    }
}
