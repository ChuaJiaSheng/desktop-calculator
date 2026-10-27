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

## Reproduce on Windows

**Prerequisites:** Git, Windows, Visual Studio with the **.NET desktop development** workload, and the **.NET Framework 4.7.2 targeting/developer pack**. This solution uses .NET Framework rather than a cross-platform .NET application.

```powershell
git clone https://github.com/ChuaJiaSheng/desktop-calculator.git
cd desktop-calculator
Start-Process .\\Calculator_222257U.sln
```

In Visual Studio, select **Debug / Any CPU**, set `Calculator_222257U` as the startup project if prompted, then choose **Build → Build Solution** and press **F5**. Keep all resource files with the project.

Alternatively, in a **Developer PowerShell for Visual Studio** terminal at the repository root:

```powershell
msbuild .\\Calculator_222257U.sln /p:Configuration=Debug /p:Platform=AnyCPU
& .\\Calculator_222257U\\bin\\Debug\\Calculator_222257U.exe
```

**Expected result:** a calculator window opens. Enter `2`, select addition, enter `3`, and evaluate; the result should be `5`. Try clear, answer recall, and copy. Speech requires an installed Windows voice; test it separately from arithmetic.

**Troubleshooting:** an MSB3644/framework-reference error usually means the targeting pack is missing; `msbuild` not found means the command was run outside a Visual Studio developer terminal. Missing resource errors require restoring the resource files and their original relative paths. If sound is silent, check Windows volume/voices and the app's sound toggles.

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
