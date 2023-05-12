grammar calc;

// /*
//  * Parser Rules
//  */

// chat                : line EOF;
// line                : name SAYS opinion NEWLINE;
// name                : WORD ;
// opinion             : TEXT ;

// /*
//  * Lexer Rules
//  */

// fragment A          : ('A'|'a') ;
// fragment S          : ('S'|'s') ;
// fragment Y          : ('Y'|'y') ;

// fragment LOWERCASE  : [a-z] ;
// fragment UPPERCASE  : [A-Z] ;

// SAYS                : S A Y S ;
// WORD                : (LOWERCASE | UPPERCASE)+ ;
// TEXT                : '"' .*? '"' ;
// WHITESPACE          : (' '|'\t')+ -> skip ;
// NEWLINE             : ('\r'? '\n' | '\r')+ ;

// --------------------------------------------------------------
// --------------------------------------------------------------
// --------------------------------------------------------------

INT: [0-9]+;
SEP: ';';
NEWLINE:'\r'? '\n' -> skip;
WS : [ \t]+ -> skip;
MUL: '*';
DIV: '/';
ADD: '+';
SUB: '-';
prog: expr # OneLineProg
 | prog SEP expr # MultLineProg
 ;
expr: expr op=(MUL | DIV) expr # MulDiv
 | expr op=(ADD | SUB) expr # AddSub
 | INT # int
 | '(' expr ')' # parens
 ;
