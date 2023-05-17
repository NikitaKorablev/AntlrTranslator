grammar calc;

AND : 'and';
OR : 'or';
NOT : 'not';
EQ: '=';
COMMA : ',';
LPAREN : '(';
RPAREN : ')';
LCURLY : '{';
RCURLY : '}';
RETURN : 'return';
SEP: ';';

INT: [0-9]+;
ID: [a-zA-Z_][a-zA-Z_0-9]*;
NEWLINE:'\r'? '\n' -> skip;
WS : [ \t\f]+ -> skip;
op: '*' | '/' | '+' | '-';

prog: state                     # OneLineProg
    | prog SEP state            # MultLineProg
    ;

state: let                      # BaseLine
    | print                     # Show
    | expr                      # Expression
    | def                       # Definition
    ;

let: ID '=' expr                # IDeqEXPR
    | ID '=' ID                 # IDeqID
    | ID '=' INT                # IDeqINT
    ;

print: 'print(' (INT|ID) ')'    # PrintIntId
    ;

expr: (INT|ID) op (INT|ID)      # VarsExpression
    ;

def: 'fun' ID '(' ID (',' ID)* ')' '{' state*? SEP RETURN (INT|ID|expr) SEP'}' # DefState
    | 'fun' ID '(' ID (',' ID)* ')' '{'RETURN (INT|ID|expr) SEP '}' # DefNoState
    ;