\ Write min without else-part (hint: what's the definition of nip?)

: min ( n m -- )
	2dup
	< if drop endif
	2dup
	= if drop endif
	2dup
	> if nip endif drop ;
