# Desktop Calculator

A C# Windows Forms calculator that combines numeric and keyboard input with arithmetic, scientific operations, answer recall, clipboard copying, speech, and click sounds.

**Stack:** C# · Windows Forms · .NET Framework 4.7.2 · Windows speech components

## Features

- Addition, subtraction, multiplication, division, and modulus.
- Square, square root, powers, logarithms, reciprocal, and sign changes.
- Trigonometric and inverse-trigonometric operations with degree/radian modes.
- Clear, clear-entry, backspace, previous-answer recall, and copy controls.
- Number-key handling and an Enter-key handler.
- Optional spoken feedback and a bundled click-sound resource.

## Build and run

1. Use Windows with Visual Studio's **.NET desktop development** tools and the .NET Framework 4.7.2 targeting pack.
2. Open [Calculator_222257U.sln](Calculator_222257U.sln).
3. Keep the `Calculator_222257U` project and its resources together, then build the solution.
4. Start the application from Visual Studio.

The solution targets .NET Framework, not modern cross-platform .NET. Speech depends on the Windows speech components and voices available on the machine.

## Try the interface

Enter a number, select an operation, enter the second number, then evaluate. Use the mode controls to expose the additional operations and choose degree or radian interpretation before trigonometric calculations. Try answer recall and clipboard copy separately from the main calculation controls.

To explore the interface, evaluate `2 + 3`, clear the display, recall an answer, compare degree/radian behaviour, toggle sound, and check keyboard input. Also inspect division by zero and invalid domains such as logarithms of non-positive values before relying on results.

## Code guide

| Path | Responsibility |
| --- | --- |
| [Program.cs](Calculator_222257U/Program.cs) | Windows Forms entry point |
| [MainForm_222257U.cs](Calculator_222257U/MainForm_222257U.cs) | Input handlers, operations, modes, speech, and sound |
| [MainForm_222257U.Designer.cs](Calculator_222257U/MainForm_222257U.Designer.cs) | Form layout and event bindings |
| [Resources](Calculator_222257U/Resources/) | Click sound and calculator icon |
| [Properties](Calculator_222257U/Properties/) | Assembly settings and resource accessors |

## Author

Chua Jia Sheng.
