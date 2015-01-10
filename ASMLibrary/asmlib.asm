.486
.model flat, stdcall
.data
.code
licz proc x:qword, y:qword
finit
fld x
fld y
fsub
ret
licz endp
end