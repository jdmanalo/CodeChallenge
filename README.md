# KeyPad Typing Simulator

Simulates typing using an old-style mobile keypad (e.g., T9 input), including support for:
- Number press mapping (2 → ABC, 3 → DEF, etc.)
- Repeated key presses for character selection
- `*` for backspace
- `#` to mark the end of the sequence

## Features
- Input validation
- Sequence parsing with backspace handling
- Modular and testable design

## Example
Input : 22# -> B
Input : 33# -> E
Input : 227*# -> B
Input : 4433555 555666# -> HELLO
Input : 8 88777444666*664# -> Turinng
