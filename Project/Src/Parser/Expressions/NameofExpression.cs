// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NameofExpression.cs" company="http://stylecop.codeplex.com">
//   MS-PL
// </copyright>
// <license>
//   This source code is subject to terms and conditions of the Microsoft 
//   Public License. A copy of the license can be found in the License.html 
//   file at the root of this distribution. If you cannot locate the  
//   Microsoft Public License, please send an email to dlr@microsoft.com. 
//   By using this source code in any fashion, you are agreeing to be bound 
//   by the terms of the Microsoft Public License. You must not remove this 
//   notice, or any other, from this software.
// </license>
// <summary>
//   An expression representing a nameof operation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace StyleCop.CSharp
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// An expression representing a nameof operation.
    /// </summary>
    /// <subcategory>expression</subcategory>
    public sealed class NameofExpression : Expression
    {
        #region Fields

        /// <summary>
        /// The type literal to get the type of.
        /// </summary>
        private readonly TypeToken type;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the NameofExpression class.
        /// </summary>
        /// <param name="tokens">
        /// The list of tokens that form the expression.
        /// </param>
        /// <param name="name">
        /// The type literal to get the name of.
        /// </param>
        internal NameofExpression(CsTokenList tokens, LiteralExpression name)
            : base(ExpressionType.NameOf, tokens)
        {
            Param.AssertNotNull(tokens, "tokens");
            Param.AssertNotNull(name, "name");

            this.type = CodeParser.ExtractTypeTokenFromLiteralExpression(name);
            this.AddExpression(name);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the type literal to get the type of.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Justification = "API has already been published and should not be changed.")]
        public TypeToken Type
        {
            get
            {
                return this.type;
            }
        }

        #endregion
    }
}