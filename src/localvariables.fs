\ Write colon definitions for nip, tuck, negate, and /mod in 
\ terms of other Forth words, and check if they work, uisng
\ local variables

\ nip ( n1 n2 - n2 )
\ nip works like drop ( n1 -- )
: nip ( n1 n2 -- n2 )
    { n1 n2 }
    n2 n1 drop ;

: niptest
	cr ." niptest started" cr 
	1 2 nip . cr \ 1 2 -- 2
	3 4 nip . cr \ 3 4 -- 4
	." niptest ended" cr ;
	
\ negate ( n1 -- -n1 )
\ returns the negation of n1
: negate ( n -- -n )
    { n }  -1 n * ;
	
: negatetest
	cr ." negatetest started" cr
	1 negate . cr \ 1 -- -1
	3 negate . cr	\ 3 -- -3
	-2 negate . cr \ -2 -- 2
	." negatetest ended" ;
		
niptest cr
negatetest cr

bye

