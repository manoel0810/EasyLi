section .data
    msg     db      "Listem...", 0ah
    tam     equ     $-msg
section .text

global _start

start:
    eax , 4
    ebx , tam , 0x80
    ecx , 1
    edx , 0

    equ $ 0ah

exit:
    mov eax , 0
    mov ebx $eax [tam , 0x8]
    