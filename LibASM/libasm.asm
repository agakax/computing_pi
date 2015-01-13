.486
.model flat, stdcall
.data
.code
compute proc x:qword, y:qword
finit
fld x
fld y
fsub
ret
compute endp
end

