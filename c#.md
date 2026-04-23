C# (pronounced “C‑sharp”) is a modern, object‑oriented, and strongly typed programming language developed by Microsoft. It is mainly used to build applications on the .NET platform.

What is C#?
C# is designed to be:

Simple – easy to learn and use
Powerful – supports modern programming concepts
Safe – strong type checking and memory management
Versatile – used for desktop, web, mobile, cloud, and game development

Where is C# Used?
C# is widely used in:

Windows applications (WinForms, WPF)
Web applications (ASP.NET, ASP.NET Core)
Mobile apps (Xamarin, .NET MAUI)
Game development (Unity)
Cloud & APIs (Azure services)
Enterprise applications

Introduction to .NET
What is .NET?
.NET is a free, open‑source, cross‑platform development framework developed by Microsoft for building different types of applications.
It provides:

A runtime environment
A set of libraries
Languages to build and run applications efficiently


Why .NET?
.NET is designed to:

Build high‑performance applications
Support multiple programming languages
Provide platform independence
Simplify development using rich libraries

Components of .NET Framework
1. Common Language Runtime (CLR)
CLR is the execution engine of .NET.
Responsibilities of CLR:

Memory management
Garbage collection
Type safety
Exception handling
Security
Thread management

2. Class Library (Framework Class Library – FCL)
A collection of pre‑defined classes, interfaces, and methods.
Provides reusable code for:

File handling
Database access
Collections
Networking
XML, JSON
UI controls


3. Common Type System (CTS)
CTS defines how data types are declared, used, and managed.
Ensures that:

Data types behave the same across languages
Language interoperability is possible

Examples:

int
string
bool
float

4. Common Language Specification (CLS)
CLS is a set of rules that languages must follow to interact smoothly.
📌 If a language follows CLS, it can:

Use code written in other .NET languages
Work seamlessly in .NET applications


Languages Supported by .NET

C# (most popular)
VB.NET
F#
C++/CLI

✅ All languages use the same runtime (CLR)

System is the root namespace

Tasks:
1. Value Type vs Reference Type
Value Type

Stores the actual value
Memory allocated on the stack
When you assign one variable to another, a copy of the value is created
Changing one variable does not affect the other
Examples: int, float, double, bool, struct

Reference Type

Stores the address (reference) of the value
Memory allocated on the heap
When you assign one variable to another, both point to the same memory
Changing one variable affects the other
Examples: class, array, string, object

2. Convert.ToInt32() vs Int32.Parse()
Convert.ToInt32()

Safer
Handles null (returns 0)
Handles different data types
Recommended for runtime input

Int32.Parse()

Strict conversion
Throws exception for null or invalid input
Used when you are sure input is valid

3. Assemblies in .NET
What is an Assembly?
An assembly is a compiled unit of code in .NET that contains:

Intermediate Language (IL)
Metadata (type information)
Manifest (version, culture, security)

Types of Assemblies

Private Assembly → Used by a single application
Shared Assembly → Used by multiple applications (stored in GAC)

4. DLL File vs EXE File
EXE File

Executable program
Has Main() method
Runs independently
Example: Console Application

DLL File

Library file
No entry point
Used by other programs
Promotes code reuse

Differences (Simple)

EXE → Start application
DLL → Support application

1.accepting current year and dob and calculate age and display minor/major
2.cateogary of age.