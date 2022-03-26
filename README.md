# ATMConsole_With_OOP

Implemented Object-Oriented Programming like interface, class and object.

### Software Development Summary

- Technology: C#
- Framework: .NET Core 5.0
- Project Type: Console
- IDE: Visual Studio Code (Version 1.65.2)
- Paradigm or pattern of programming: Object-Oriented Programming (OOP)
- Data: Data of this demo program (Bank Account and Transaction data) are stored using List objects. No database is used on purpose for this demo version.
- NuGet: ConsoleTables (Version 2.2), CsConsoleFormat (Coming Soon)

### ATM Basic Features / Use Cases:

- [x] Log in / Log out
- [x] Check account balance
- [x] Place deposit
- [x] Make withdraw
- [x] Check card number and pin against bank account list object (Note: No database is used on purpose to demo the use of list object)
- [x] Make third-party-transfer (Transfer within the same bank but different account number)
- [x] View bank transactions

#### Business Rules:

- User is not allow to withdraw or transfer more than the balance amount. A minimum USD20 is needed to maintain the bank account.
- If user key in the wrong pin more than 3 times, the bank account will be locked.

#### Assumption:

- All bank account are the from the same bank

#### Enhancement (To Do):

- [ ] Fluent Validation to handle input validation of any data type and input length (min, max, fixed)

### OOP principles and C# features implemented:

- class (POCO class and utility class)
- object
- Object and collection initializer
- encapsulation: private, internal and public
- LINQ to object (LINQ Query syntax)
- List
- static
- this
- field
- property
- const
- switch case
- string interpolation
- while loop
- enum
- region
- System.Globalization for local currency symbol and format
- ternary operator ?
