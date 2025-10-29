# SimpleEncrypter
A skill check project written in C#. A console-based encryption and decryption application.

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Logic Breakdown / Tasks](#logic-breakdown--tasks)
- [Code Structure](#code-structure)

## Overview
This project demonstrates:
- Character manipulation and encoding
- Modular code with static classes
- Console input and output handling
- Looping and menu-driven program flow
- Using arrays and LINQ for pattern-based transformations

## Features
- Encrypts text using a repeating numeric pattern applied to character codes.
- Decrypts text by reversing the same numeric pattern.
- Provides a menu-driven interface with options to encrypt, decrypt, clear console, or exit.
- Prompts the user for input and handles invalid menu selections gracefully.
- Supports continuous use without restarting the application.

## Logic Breakdown / Tasks
- [x] Define an encryption/decryption pattern array (`_pattern = {2, 5, 3}`).
- [x] Encrypt input by shifting characters according to the repeating pattern.
- [x] Decrypt input by reversing the character shifts.
- [x] Display a console menu for user interaction.
- [x] Validate menu selections and provide appropriate feedback.
- [x] Loop program execution until the user chooses to exit.

## Code Structure
- `Program.cs` — Entry point that calls `UIHelper.Run()`.

- `Encrypter.cs` — Static class containing:
   - `Encrypt(string input)` — Encodes a string by adding values from the `_pattern` array in sequence.
   - `Decrypt(string input)` — Decodes a string by subtracting values from the `_pattern` array in sequence.

- `UIHelper.cs` — Static class handling user interface:
   - `Run()` — Loops the main menu.
   - `ShowMenu()` — Displays available options.
   - `MenuSelection(string selection)` — Executes actions based on user choice.
   - `PromptUser(string input)` — Prompts and reads user input.
