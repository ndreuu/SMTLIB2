//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/andrew/RiderProjects/SMTLIB2-cc/smtlibv2-grammar/src/main/resources/SMTLIBv2.g4 by ANTLR 4.10.1

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
/// by <see cref="SMTLIBv2Parser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public interface ISMTLIBv2Visitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStart([NotNull] SMTLIBv2Parser.StartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResponse([NotNull] SMTLIBv2Parser.ResponseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.generalReservedWord"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGeneralReservedWord([NotNull] SMTLIBv2Parser.GeneralReservedWordContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.simpleSymbol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleSymbol([NotNull] SMTLIBv2Parser.SimpleSymbolContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.quotedSymbol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuotedSymbol([NotNull] SMTLIBv2Parser.QuotedSymbolContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.predefSymbol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPredefSymbol([NotNull] SMTLIBv2Parser.PredefSymbolContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.predefKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPredefKeyword([NotNull] SMTLIBv2Parser.PredefKeywordContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.symbol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSymbol([NotNull] SMTLIBv2Parser.SymbolContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.numeral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumeral([NotNull] SMTLIBv2Parser.NumeralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.decimal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDecimal([NotNull] SMTLIBv2Parser.DecimalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.hexadecimal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHexadecimal([NotNull] SMTLIBv2Parser.HexadecimalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.binary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinary([NotNull] SMTLIBv2Parser.BinaryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] SMTLIBv2Parser.StringContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeyword([NotNull] SMTLIBv2Parser.KeywordContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.spec_constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSpec_constant([NotNull] SMTLIBv2Parser.Spec_constantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.s_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitS_expr([NotNull] SMTLIBv2Parser.S_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndex([NotNull] SMTLIBv2Parser.IndexContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] SMTLIBv2Parser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.attribute_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttribute_value([NotNull] SMTLIBv2Parser.Attribute_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttribute([NotNull] SMTLIBv2Parser.AttributeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.sort"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSort([NotNull] SMTLIBv2Parser.SortContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.qual_identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQual_identifier([NotNull] SMTLIBv2Parser.Qual_identifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.var_binding"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVar_binding([NotNull] SMTLIBv2Parser.Var_bindingContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.sorted_var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSorted_var([NotNull] SMTLIBv2Parser.Sorted_varContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPattern([NotNull] SMTLIBv2Parser.PatternContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.match_case"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMatch_case([NotNull] SMTLIBv2Parser.Match_caseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTerm([NotNull] SMTLIBv2Parser.TermContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.sort_symbol_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSort_symbol_decl([NotNull] SMTLIBv2Parser.Sort_symbol_declContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.meta_spec_constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMeta_spec_constant([NotNull] SMTLIBv2Parser.Meta_spec_constantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.fun_symbol_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFun_symbol_decl([NotNull] SMTLIBv2Parser.Fun_symbol_declContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.par_fun_symbol_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPar_fun_symbol_decl([NotNull] SMTLIBv2Parser.Par_fun_symbol_declContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.theory_attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTheory_attribute([NotNull] SMTLIBv2Parser.Theory_attributeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.theory_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTheory_decl([NotNull] SMTLIBv2Parser.Theory_declContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.logic_attribue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogic_attribue([NotNull] SMTLIBv2Parser.Logic_attribueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.logic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogic([NotNull] SMTLIBv2Parser.LogicContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.sort_dec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSort_dec([NotNull] SMTLIBv2Parser.Sort_decContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.selector_dec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelector_dec([NotNull] SMTLIBv2Parser.Selector_decContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.constructor_dec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructor_dec([NotNull] SMTLIBv2Parser.Constructor_decContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.datatype_dec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatatype_dec([NotNull] SMTLIBv2Parser.Datatype_decContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.function_dec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction_dec([NotNull] SMTLIBv2Parser.Function_decContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.function_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction_def([NotNull] SMTLIBv2Parser.Function_defContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.prop_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProp_literal([NotNull] SMTLIBv2Parser.Prop_literalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScript([NotNull] SMTLIBv2Parser.ScriptContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_assert"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_assert([NotNull] SMTLIBv2Parser.Cmd_assertContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_checkSat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_checkSat([NotNull] SMTLIBv2Parser.Cmd_checkSatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_checkSatAssuming"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_checkSatAssuming([NotNull] SMTLIBv2Parser.Cmd_checkSatAssumingContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_declareConst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_declareConst([NotNull] SMTLIBv2Parser.Cmd_declareConstContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_declareDatatype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_declareDatatype([NotNull] SMTLIBv2Parser.Cmd_declareDatatypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_declareDatatypes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_declareDatatypes([NotNull] SMTLIBv2Parser.Cmd_declareDatatypesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_declareFun"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_declareFun([NotNull] SMTLIBv2Parser.Cmd_declareFunContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_declareSort"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_declareSort([NotNull] SMTLIBv2Parser.Cmd_declareSortContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_defineFun"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_defineFun([NotNull] SMTLIBv2Parser.Cmd_defineFunContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_defineFunRec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_defineFunRec([NotNull] SMTLIBv2Parser.Cmd_defineFunRecContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_defineFunsRec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_defineFunsRec([NotNull] SMTLIBv2Parser.Cmd_defineFunsRecContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_defineSort"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_defineSort([NotNull] SMTLIBv2Parser.Cmd_defineSortContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_echo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_echo([NotNull] SMTLIBv2Parser.Cmd_echoContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_exit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_exit([NotNull] SMTLIBv2Parser.Cmd_exitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_getAssertions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_getAssertions([NotNull] SMTLIBv2Parser.Cmd_getAssertionsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_getAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_getAssignment([NotNull] SMTLIBv2Parser.Cmd_getAssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_getInfo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_getInfo([NotNull] SMTLIBv2Parser.Cmd_getInfoContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_getModel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_getModel([NotNull] SMTLIBv2Parser.Cmd_getModelContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_getOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_getOption([NotNull] SMTLIBv2Parser.Cmd_getOptionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_getProof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_getProof([NotNull] SMTLIBv2Parser.Cmd_getProofContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_getUnsatAssumptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_getUnsatAssumptions([NotNull] SMTLIBv2Parser.Cmd_getUnsatAssumptionsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_getUnsatCore"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_getUnsatCore([NotNull] SMTLIBv2Parser.Cmd_getUnsatCoreContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_getValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_getValue([NotNull] SMTLIBv2Parser.Cmd_getValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_pop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_pop([NotNull] SMTLIBv2Parser.Cmd_popContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_push"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_push([NotNull] SMTLIBv2Parser.Cmd_pushContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_reset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_reset([NotNull] SMTLIBv2Parser.Cmd_resetContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_resetAssertions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_resetAssertions([NotNull] SMTLIBv2Parser.Cmd_resetAssertionsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_setInfo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_setInfo([NotNull] SMTLIBv2Parser.Cmd_setInfoContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_setLogic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_setLogic([NotNull] SMTLIBv2Parser.Cmd_setLogicContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.cmd_setOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmd_setOption([NotNull] SMTLIBv2Parser.Cmd_setOptionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommand([NotNull] SMTLIBv2Parser.CommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.b_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitB_value([NotNull] SMTLIBv2Parser.B_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOption([NotNull] SMTLIBv2Parser.OptionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.info_flag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInfo_flag([NotNull] SMTLIBv2Parser.Info_flagContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.error_behaviour"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitError_behaviour([NotNull] SMTLIBv2Parser.Error_behaviourContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.reason_unknown"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReason_unknown([NotNull] SMTLIBv2Parser.Reason_unknownContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.model_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModel_response([NotNull] SMTLIBv2Parser.Model_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.info_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInfo_response([NotNull] SMTLIBv2Parser.Info_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.valuation_pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValuation_pair([NotNull] SMTLIBv2Parser.Valuation_pairContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.t_valuation_pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitT_valuation_pair([NotNull] SMTLIBv2Parser.T_valuation_pairContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.check_sat_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCheck_sat_response([NotNull] SMTLIBv2Parser.Check_sat_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.echo_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEcho_response([NotNull] SMTLIBv2Parser.Echo_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.get_assertions_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGet_assertions_response([NotNull] SMTLIBv2Parser.Get_assertions_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.get_assignment_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGet_assignment_response([NotNull] SMTLIBv2Parser.Get_assignment_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.get_info_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGet_info_response([NotNull] SMTLIBv2Parser.Get_info_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.get_model_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGet_model_response([NotNull] SMTLIBv2Parser.Get_model_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.get_option_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGet_option_response([NotNull] SMTLIBv2Parser.Get_option_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.get_proof_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGet_proof_response([NotNull] SMTLIBv2Parser.Get_proof_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.get_unsat_assump_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGet_unsat_assump_response([NotNull] SMTLIBv2Parser.Get_unsat_assump_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.get_unsat_core_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGet_unsat_core_response([NotNull] SMTLIBv2Parser.Get_unsat_core_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.get_value_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGet_value_response([NotNull] SMTLIBv2Parser.Get_value_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.specific_success_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSpecific_success_response([NotNull] SMTLIBv2Parser.Specific_success_responseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SMTLIBv2Parser.general_response"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGeneral_response([NotNull] SMTLIBv2Parser.General_responseContext context);
}
