//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\FucingTrash\Programming\Repozitories\UNN-PROJ\AntlrTranslator\AntlrCSharp\calc.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="calcParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IcalcVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="calcParser.op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOp([NotNull] calcParser.OpContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>OneLineProg</c>
	/// labeled alternative in <see cref="calcParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOneLineProg([NotNull] calcParser.OneLineProgContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MultLineProg</c>
	/// labeled alternative in <see cref="calcParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultLineProg([NotNull] calcParser.MultLineProgContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BaseLine</c>
	/// labeled alternative in <see cref="calcParser.state"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBaseLine([NotNull] calcParser.BaseLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Show</c>
	/// labeled alternative in <see cref="calcParser.state"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShow([NotNull] calcParser.ShowContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Expression</c>
	/// labeled alternative in <see cref="calcParser.state"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] calcParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Definition</c>
	/// labeled alternative in <see cref="calcParser.state"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefinition([NotNull] calcParser.DefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IDeqEXPR</c>
	/// labeled alternative in <see cref="calcParser.let"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIDeqEXPR([NotNull] calcParser.IDeqEXPRContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IDeqID</c>
	/// labeled alternative in <see cref="calcParser.let"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIDeqID([NotNull] calcParser.IDeqIDContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IDeqINT</c>
	/// labeled alternative in <see cref="calcParser.let"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIDeqINT([NotNull] calcParser.IDeqINTContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PrintIntId</c>
	/// labeled alternative in <see cref="calcParser.print"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintIntId([NotNull] calcParser.PrintIntIdContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VarsExpression</c>
	/// labeled alternative in <see cref="calcParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarsExpression([NotNull] calcParser.VarsExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="calcParser.def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDef([NotNull] calcParser.DefContext context);
}
