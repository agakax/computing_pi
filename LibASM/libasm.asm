.486
.model flat, stdcall
.data
.code
compute proc x:qword
finit
fld x
fld 5
fsub
ret
compute endp
end

