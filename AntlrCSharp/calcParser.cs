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

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class calcParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, AND=7, OR=8, NOT=9, EQ=10, 
		COMMA=11, LPAREN=12, RPAREN=13, LCURLY=14, RCURLY=15, RETURN=16, SEP=17, 
		INT=18, ID=19, NEWLINE=20, WS=21;
	public const int
		RULE_op = 0, RULE_prog = 1, RULE_state = 2, RULE_let = 3, RULE_print = 4, 
		RULE_expr = 5, RULE_def = 6;
	public static readonly string[] ruleNames = {
		"op", "prog", "state", "let", "print", "expr", "def"
	};

	private static readonly string[] _LiteralNames = {
		null, "'*'", "'/'", "'+'", "'-'", "'print('", "'fun'", "'and'", "'or'", 
		"'not'", "'='", "','", "'('", "')'", "'{'", "'}'", "'return'", "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "AND", "OR", "NOT", "EQ", "COMMA", 
		"LPAREN", "RPAREN", "LCURLY", "RCURLY", "RETURN", "SEP", "INT", "ID", 
		"NEWLINE", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "calc.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static calcParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public calcParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public calcParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class OpContext : ParserRuleContext {
		public OpContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_op; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOp(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public OpContext op() {
		OpContext _localctx = new OpContext(Context, State);
		EnterRule(_localctx, 0, RULE_op);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ProgContext : ParserRuleContext {
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prog; } }
	 
		public ProgContext() { }
		public virtual void CopyFrom(ProgContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class OneLineProgContext : ProgContext {
		[System.Diagnostics.DebuggerNonUserCode] public StateContext state() {
			return GetRuleContext<StateContext>(0);
		}
		public OneLineProgContext(ProgContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOneLineProg(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MultLineProgContext : ProgContext {
		[System.Diagnostics.DebuggerNonUserCode] public ProgContext prog() {
			return GetRuleContext<ProgContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(calcParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StateContext state() {
			return GetRuleContext<StateContext>(0);
		}
		public MultLineProgContext(ProgContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMultLineProg(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		return prog(0);
	}

	private ProgContext prog(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ProgContext _localctx = new ProgContext(Context, _parentState);
		ProgContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_prog, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			_localctx = new OneLineProgContext(_localctx);
			Context = _localctx;
			_prevctx = _localctx;

			State = 17;
			state();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 24;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new MultLineProgContext(new ProgContext(_parentctx, _parentState));
					PushNewRecursionContext(_localctx, _startState, RULE_prog);
					State = 19;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 20;
					Match(SEP);
					State = 21;
					state();
					}
					} 
				}
				State = 26;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class StateContext : ParserRuleContext {
		public StateContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_state; } }
	 
		public StateContext() { }
		public virtual void CopyFrom(StateContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ExpressionContext : StateContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ExpressionContext(StateContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DefinitionContext : StateContext {
		[System.Diagnostics.DebuggerNonUserCode] public DefContext def() {
			return GetRuleContext<DefContext>(0);
		}
		public DefinitionContext(StateContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDefinition(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ShowContext : StateContext {
		[System.Diagnostics.DebuggerNonUserCode] public PrintContext print() {
			return GetRuleContext<PrintContext>(0);
		}
		public ShowContext(StateContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitShow(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BaseLineContext : StateContext {
		[System.Diagnostics.DebuggerNonUserCode] public LetContext let() {
			return GetRuleContext<LetContext>(0);
		}
		public BaseLineContext(StateContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBaseLine(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StateContext state() {
		StateContext _localctx = new StateContext(Context, State);
		EnterRule(_localctx, 4, RULE_state);
		try {
			State = 31;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				_localctx = new BaseLineContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 27;
				let();
				}
				break;
			case 2:
				_localctx = new ShowContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 28;
				print();
				}
				break;
			case 3:
				_localctx = new ExpressionContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 29;
				expr();
				}
				break;
			case 4:
				_localctx = new DefinitionContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 30;
				def();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LetContext : ParserRuleContext {
		public LetContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_let; } }
	 
		public LetContext() { }
		public virtual void CopyFrom(LetContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class IDeqEXPRContext : LetContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(calcParser.ID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQ() { return GetToken(calcParser.EQ, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public IDeqEXPRContext(LetContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIDeqEXPR(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IDeqINTContext : LetContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(calcParser.ID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQ() { return GetToken(calcParser.EQ, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(calcParser.INT, 0); }
		public IDeqINTContext(LetContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIDeqINT(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IDeqIDContext : LetContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ID() { return GetTokens(calcParser.ID); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID(int i) {
			return GetToken(calcParser.ID, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode EQ() { return GetToken(calcParser.EQ, 0); }
		public IDeqIDContext(LetContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIDeqID(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LetContext let() {
		LetContext _localctx = new LetContext(Context, State);
		EnterRule(_localctx, 6, RULE_let);
		try {
			State = 42;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				_localctx = new IDeqEXPRContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 33;
				Match(ID);
				State = 34;
				Match(EQ);
				State = 35;
				expr();
				}
				break;
			case 2:
				_localctx = new IDeqIDContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 36;
				Match(ID);
				State = 37;
				Match(EQ);
				State = 38;
				Match(ID);
				}
				break;
			case 3:
				_localctx = new IDeqINTContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 39;
				Match(ID);
				State = 40;
				Match(EQ);
				State = 41;
				Match(INT);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PrintContext : ParserRuleContext {
		public PrintContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_print; } }
	 
		public PrintContext() { }
		public virtual void CopyFrom(PrintContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class PrintIntIdContext : PrintContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(calcParser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(calcParser.INT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(calcParser.ID, 0); }
		public PrintIntIdContext(PrintContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPrintIntId(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PrintContext print() {
		PrintContext _localctx = new PrintContext(Context, State);
		EnterRule(_localctx, 8, RULE_print);
		int _la;
		try {
			_localctx = new PrintIntIdContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 44;
			Match(T__4);
			State = 45;
			_la = TokenStream.LA(1);
			if ( !(_la==INT || _la==ID) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 46;
			Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
	 
		public ExprContext() { }
		public virtual void CopyFrom(ExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class VarsExpressionContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public OpContext op() {
			return GetRuleContext<OpContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] INT() { return GetTokens(calcParser.INT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT(int i) {
			return GetToken(calcParser.INT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ID() { return GetTokens(calcParser.ID); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID(int i) {
			return GetToken(calcParser.ID, i);
		}
		public VarsExpressionContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVarsExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(Context, State);
		EnterRule(_localctx, 10, RULE_expr);
		int _la;
		try {
			_localctx = new VarsExpressionContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 48;
			_la = TokenStream.LA(1);
			if ( !(_la==INT || _la==ID) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 49;
			op();
			State = 50;
			_la = TokenStream.LA(1);
			if ( !(_la==INT || _la==ID) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DefContext : ParserRuleContext {
		public DefContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_def; } }
	 
		public DefContext() { }
		public virtual void CopyFrom(DefContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class DefStateContext : DefContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ID() { return GetTokens(calcParser.ID); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID(int i) {
			return GetToken(calcParser.ID, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(calcParser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(calcParser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LCURLY() { return GetToken(calcParser.LCURLY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] SEP() { return GetTokens(calcParser.SEP); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP(int i) {
			return GetToken(calcParser.SEP, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RETURN() { return GetToken(calcParser.RETURN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RCURLY() { return GetToken(calcParser.RCURLY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(calcParser.INT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(calcParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(calcParser.COMMA, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StateContext[] state() {
			return GetRuleContexts<StateContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StateContext state(int i) {
			return GetRuleContext<StateContext>(i);
		}
		public DefStateContext(DefContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDefState(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DefNoStateContext : DefContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ID() { return GetTokens(calcParser.ID); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID(int i) {
			return GetToken(calcParser.ID, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAREN() { return GetToken(calcParser.LPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAREN() { return GetToken(calcParser.RPAREN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LCURLY() { return GetToken(calcParser.LCURLY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RETURN() { return GetToken(calcParser.RETURN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SEP() { return GetToken(calcParser.SEP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RCURLY() { return GetToken(calcParser.RCURLY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(calcParser.INT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] COMMA() { return GetTokens(calcParser.COMMA); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMA(int i) {
			return GetToken(calcParser.COMMA, i);
		}
		public DefNoStateContext(DefContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IcalcVisitor<TResult> typedVisitor = visitor as IcalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDefNoState(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DefContext def() {
		DefContext _localctx = new DefContext(Context, State);
		EnterRule(_localctx, 12, RULE_def);
		int _la;
		try {
			int _alt;
			State = 101;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,8,Context) ) {
			case 1:
				_localctx = new DefStateContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 52;
				Match(T__5);
				State = 53;
				Match(ID);
				State = 54;
				Match(LPAREN);
				State = 55;
				Match(ID);
				State = 60;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 56;
					Match(COMMA);
					State = 57;
					Match(ID);
					}
					}
					State = 62;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 63;
				Match(RPAREN);
				State = 64;
				Match(LCURLY);
				State = 68;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
				while ( _alt!=1 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1+1 ) {
						{
						{
						State = 65;
						state();
						}
						} 
					}
					State = 70;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
				}
				State = 71;
				Match(SEP);
				State = 72;
				Match(RETURN);
				State = 76;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
				case 1:
					{
					State = 73;
					Match(INT);
					}
					break;
				case 2:
					{
					State = 74;
					Match(ID);
					}
					break;
				case 3:
					{
					State = 75;
					expr();
					}
					break;
				}
				State = 78;
				Match(SEP);
				State = 79;
				Match(RCURLY);
				}
				break;
			case 2:
				_localctx = new DefNoStateContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 80;
				Match(T__5);
				State = 81;
				Match(ID);
				State = 82;
				Match(LPAREN);
				State = 83;
				Match(ID);
				State = 88;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==COMMA) {
					{
					{
					State = 84;
					Match(COMMA);
					State = 85;
					Match(ID);
					}
					}
					State = 90;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 91;
				Match(RPAREN);
				State = 92;
				Match(LCURLY);
				State = 93;
				Match(RETURN);
				State = 97;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,7,Context) ) {
				case 1:
					{
					State = 94;
					Match(INT);
					}
					break;
				case 2:
					{
					State = 95;
					Match(ID);
					}
					break;
				case 3:
					{
					State = 96;
					expr();
					}
					break;
				}
				State = 99;
				Match(SEP);
				State = 100;
				Match(RCURLY);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return prog_sempred((ProgContext)_localctx, predIndex);
		}
		return true;
	}
	private bool prog_sempred(ProgContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 1);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x17', 'j', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\a', '\x3', '\x19', '\n', '\x3', 
		'\f', '\x3', '\xE', '\x3', '\x1C', '\v', '\x3', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x5', '\x4', '\"', '\n', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', '-', '\n', '\x5', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\a', '\b', '=', '\n', '\b', '\f', 
		'\b', '\xE', '\b', '@', '\v', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\a', '\b', '\x45', '\n', '\b', '\f', '\b', '\xE', '\b', 'H', '\v', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x5', 
		'\b', 'O', '\n', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\a', '\b', 'Y', '\n', 
		'\b', '\f', '\b', '\xE', '\b', '\\', '\v', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', '\x64', 
		'\n', '\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', 'h', '\n', '\b', '\x3', 
		'\b', '\x3', '\x46', '\x3', '\x4', '\t', '\x2', '\x4', '\x6', '\b', '\n', 
		'\f', '\xE', '\x2', '\x4', '\x3', '\x2', '\x3', '\x6', '\x3', '\x2', '\x14', 
		'\x15', '\x2', 'p', '\x2', '\x10', '\x3', '\x2', '\x2', '\x2', '\x4', 
		'\x12', '\x3', '\x2', '\x2', '\x2', '\x6', '!', '\x3', '\x2', '\x2', '\x2', 
		'\b', ',', '\x3', '\x2', '\x2', '\x2', '\n', '.', '\x3', '\x2', '\x2', 
		'\x2', '\f', '\x32', '\x3', '\x2', '\x2', '\x2', '\xE', 'g', '\x3', '\x2', 
		'\x2', '\x2', '\x10', '\x11', '\t', '\x2', '\x2', '\x2', '\x11', '\x3', 
		'\x3', '\x2', '\x2', '\x2', '\x12', '\x13', '\b', '\x3', '\x1', '\x2', 
		'\x13', '\x14', '\x5', '\x6', '\x4', '\x2', '\x14', '\x1A', '\x3', '\x2', 
		'\x2', '\x2', '\x15', '\x16', '\f', '\x3', '\x2', '\x2', '\x16', '\x17', 
		'\a', '\x13', '\x2', '\x2', '\x17', '\x19', '\x5', '\x6', '\x4', '\x2', 
		'\x18', '\x15', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1C', '\x3', '\x2', 
		'\x2', '\x2', '\x1A', '\x18', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x1B', 
		'\x3', '\x2', '\x2', '\x2', '\x1B', '\x5', '\x3', '\x2', '\x2', '\x2', 
		'\x1C', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x1D', '\"', '\x5', '\b', 
		'\x5', '\x2', '\x1E', '\"', '\x5', '\n', '\x6', '\x2', '\x1F', '\"', '\x5', 
		'\f', '\a', '\x2', ' ', '\"', '\x5', '\xE', '\b', '\x2', '!', '\x1D', 
		'\x3', '\x2', '\x2', '\x2', '!', '\x1E', '\x3', '\x2', '\x2', '\x2', '!', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '!', ' ', '\x3', '\x2', '\x2', '\x2', 
		'\"', '\a', '\x3', '\x2', '\x2', '\x2', '#', '$', '\a', '\x15', '\x2', 
		'\x2', '$', '%', '\a', '\f', '\x2', '\x2', '%', '-', '\x5', '\f', '\a', 
		'\x2', '&', '\'', '\a', '\x15', '\x2', '\x2', '\'', '(', '\a', '\f', '\x2', 
		'\x2', '(', '-', '\a', '\x15', '\x2', '\x2', ')', '*', '\a', '\x15', '\x2', 
		'\x2', '*', '+', '\a', '\f', '\x2', '\x2', '+', '-', '\a', '\x14', '\x2', 
		'\x2', ',', '#', '\x3', '\x2', '\x2', '\x2', ',', '&', '\x3', '\x2', '\x2', 
		'\x2', ',', ')', '\x3', '\x2', '\x2', '\x2', '-', '\t', '\x3', '\x2', 
		'\x2', '\x2', '.', '/', '\a', '\a', '\x2', '\x2', '/', '\x30', '\t', '\x3', 
		'\x2', '\x2', '\x30', '\x31', '\a', '\xF', '\x2', '\x2', '\x31', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\x32', '\x33', '\t', '\x3', '\x2', '\x2', 
		'\x33', '\x34', '\x5', '\x2', '\x2', '\x2', '\x34', '\x35', '\t', '\x3', 
		'\x2', '\x2', '\x35', '\r', '\x3', '\x2', '\x2', '\x2', '\x36', '\x37', 
		'\a', '\b', '\x2', '\x2', '\x37', '\x38', '\a', '\x15', '\x2', '\x2', 
		'\x38', '\x39', '\a', '\xE', '\x2', '\x2', '\x39', '>', '\a', '\x15', 
		'\x2', '\x2', ':', ';', '\a', '\r', '\x2', '\x2', ';', '=', '\a', '\x15', 
		'\x2', '\x2', '<', ':', '\x3', '\x2', '\x2', '\x2', '=', '@', '\x3', '\x2', 
		'\x2', '\x2', '>', '<', '\x3', '\x2', '\x2', '\x2', '>', '?', '\x3', '\x2', 
		'\x2', '\x2', '?', '\x41', '\x3', '\x2', '\x2', '\x2', '@', '>', '\x3', 
		'\x2', '\x2', '\x2', '\x41', '\x42', '\a', '\xF', '\x2', '\x2', '\x42', 
		'\x46', '\a', '\x10', '\x2', '\x2', '\x43', '\x45', '\x5', '\x6', '\x4', 
		'\x2', '\x44', '\x43', '\x3', '\x2', '\x2', '\x2', '\x45', 'H', '\x3', 
		'\x2', '\x2', '\x2', '\x46', 'G', '\x3', '\x2', '\x2', '\x2', '\x46', 
		'\x44', '\x3', '\x2', '\x2', '\x2', 'G', 'I', '\x3', '\x2', '\x2', '\x2', 
		'H', '\x46', '\x3', '\x2', '\x2', '\x2', 'I', 'J', '\a', '\x13', '\x2', 
		'\x2', 'J', 'N', '\a', '\x12', '\x2', '\x2', 'K', 'O', '\a', '\x14', '\x2', 
		'\x2', 'L', 'O', '\a', '\x15', '\x2', '\x2', 'M', 'O', '\x5', '\f', '\a', 
		'\x2', 'N', 'K', '\x3', '\x2', '\x2', '\x2', 'N', 'L', '\x3', '\x2', '\x2', 
		'\x2', 'N', 'M', '\x3', '\x2', '\x2', '\x2', 'O', 'P', '\x3', '\x2', '\x2', 
		'\x2', 'P', 'Q', '\a', '\x13', '\x2', '\x2', 'Q', 'h', '\a', '\x11', '\x2', 
		'\x2', 'R', 'S', '\a', '\b', '\x2', '\x2', 'S', 'T', '\a', '\x15', '\x2', 
		'\x2', 'T', 'U', '\a', '\xE', '\x2', '\x2', 'U', 'Z', '\a', '\x15', '\x2', 
		'\x2', 'V', 'W', '\a', '\r', '\x2', '\x2', 'W', 'Y', '\a', '\x15', '\x2', 
		'\x2', 'X', 'V', '\x3', '\x2', '\x2', '\x2', 'Y', '\\', '\x3', '\x2', 
		'\x2', '\x2', 'Z', 'X', '\x3', '\x2', '\x2', '\x2', 'Z', '[', '\x3', '\x2', 
		'\x2', '\x2', '[', ']', '\x3', '\x2', '\x2', '\x2', '\\', 'Z', '\x3', 
		'\x2', '\x2', '\x2', ']', '^', '\a', '\xF', '\x2', '\x2', '^', '_', '\a', 
		'\x10', '\x2', '\x2', '_', '\x63', '\a', '\x12', '\x2', '\x2', '`', '\x64', 
		'\a', '\x14', '\x2', '\x2', '\x61', '\x64', '\a', '\x15', '\x2', '\x2', 
		'\x62', '\x64', '\x5', '\f', '\a', '\x2', '\x63', '`', '\x3', '\x2', '\x2', 
		'\x2', '\x63', '\x61', '\x3', '\x2', '\x2', '\x2', '\x63', '\x62', '\x3', 
		'\x2', '\x2', '\x2', '\x64', '\x65', '\x3', '\x2', '\x2', '\x2', '\x65', 
		'\x66', '\a', '\x13', '\x2', '\x2', '\x66', 'h', '\a', '\x11', '\x2', 
		'\x2', 'g', '\x36', '\x3', '\x2', '\x2', '\x2', 'g', 'R', '\x3', '\x2', 
		'\x2', '\x2', 'h', '\xF', '\x3', '\x2', '\x2', '\x2', '\v', '\x1A', '!', 
		',', '>', '\x46', 'N', 'Z', '\x63', 'g',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
