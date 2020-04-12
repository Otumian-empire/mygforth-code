\ Write 17^3 and 17^4 in Forth, without writing 17 more than once. 
: 17^3 ( -- n ) 17 dup dup * * ;
: 17^4 ( -- n ) 17 dup 2dup * * * ;


\ Write a piece of Forth code that expects two numbers on the stack 
\ (a and b, with b on top) and computes (a-b)(a+1). )
: stackmanipassig ( a b -- c )
	.s cr
	over ."  o " .s cr
	swap ."  s " .s cr
	-    ."  - " .s cr
	swap ."  s " .s cr
	1 +  ."  1+ " .s cr
	*    ."  * " .s cr ;
	
: stackmanipassigtest ( a b -- c )
	\ when a = 3, b = 4 then -4 
	cr 3 4 stackmanipassig . cr
	\ when a = 4, b = 3 then 4
	cr 4 3 stackmanipassig . cr ;
	
	
stackmanipassigtest
a b over
swap b a
dup b a a
rot a a b
swap a b a

