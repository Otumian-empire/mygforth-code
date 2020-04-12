\ Write colon definitions for nip, tuck, negate, and /mod in 
\ terms of other Forth words, and check if they work 

\ nip ( n1 n2 - n2 )
\ nip works like drop ( n1 -- )
: nip ( n1 n2 -- n2 ) swap drop ;

: niptest
	cr ." niptest started" cr 
	1 2 nip . cr \ 1 2 -- 2
	3 2 nip . cr \ 3 2 -- 2
	." niptest ended" cr ;
	
\ tuck ( n1 n2 -- n2 n1 n2 )
\ tuck works like over ( n1 n2 -- n1 n2 n1 )
: tuck ( n1 n2 -- n2 n1 n2 ) dup rot swap ;
	
: tucktest
	cr ." tucktest started" cr
	1 2 tuck .s 2drop drop cr \ 1 2 -- 2 1 2
	3 4 tuck .s 2drop drop cr \ 3 4 -- 4 3 4	
	." tucktest ended" ;
	
\ negate ( n1 -- -n1 )
\ returns the negation of n1
: negate ( n -- -n ) -1 * ;
	
: negatetest
	cr ." negatetest started" cr
	1 negate . cr \ 1 -- -1
	3 negate . cr	\ 3 -- -3
	-2 negate . cr \ -2 -- 2
	." negatetest ended" ;
	
\ /mod ( n1 n2 -- q r )
\ returns the quotient and remainder of n1 and n2
: /mod ( n1 n2 -- q r ) 2dup / rot rot mod ;

: /modtest
	cr ." /modtest started" cr
	5 2 /mod swap . . cr \ 5 2 -- 2 1
	10 4 /mod swap . . cr \ 10 4 -- 2 2
	cr ." /modtest ended" ;
	
niptest cr
tucktest cr
negatetest cr
/modtest cr
bye

