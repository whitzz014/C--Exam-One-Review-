# C# Review 

##  Whats on the Test 
### Part A
    - 25 T/F Questions 
        - All from the quizzes w1-w5 
        - pool of 100+ questions 
    - Study Lecture Slides
### Part B 
    - Mix of Coding Questions 
        - like assignments 
        - infer properties you need 
        - classes 
        - study assignments 
        - shouldnt need a cheat sheet 
        - No Bitwise Operators on Test

## Nick Uploaded Review Slide in Week 6 Folder 
    - he trimmed down slides to most imporntant 

## Below are things from Nicks Solution Files 

## Assignment 1 - Student Info
    - to access ReadKey() use var name.Key 
    - Review composite formatting to output array instead of stirng interpolation 

## Assignment 2 - Number Guessing Game
    - Review TryParse
    - Parse is ok but need to use try catch block to handle an error 
    - continue; skips the rest of code block left in while loop 
    - if you use an infinite while loop make sure to have a break statement somewhere 

## Assignment 3 - BitWise Operator 
    - classes are player, game, displayBoard, play
    - uses Game class in main method so if he wants to run it infinite he only needs to use one line of code in a while loop 
    - switch statement can use fall through 
    - No multiple classes in single file => new class = new file 

## Assignment 4 - Customer tracker  - Focus on this Assingment
    - Extension Methods are on the test
        - Review and practice them
    - classes customer, person, perferredCustomer 
    - Assignemnt focuses on inheritance 
    - need to use a backing field if you need to customize a getter or setter 
    - could put perferredCustomers in Customers[] because of polymorphism (same type (sub types of Person class)) 
        - Array of derived object types 
        - classes and sub classes 
    - Using multiple class types on the Test 

## Assignment 5 - War Card Game 
 
    - class deck, card, player, game, suit (enum), Round 
    - operator overloading and enums on the test


## Quiz Q&A
### Week 1
    1. C# identifiers follow the same convention as Java 
        - True 
    2. With regards to an array, square brackets must always appear immediately after the variable declaration
        - False 
    3. C# is a loosly typed language
        - False 
    4. After declaring a local variable, you must assign it a value before reading from it
        -  True 
    5. The "Output" class may be used to perform I/O on the console
        - False 
    6. In C#, the main method requires PascalCase
        - True 
    7. Regarding string interpolation, the compiler interprets the interior of the curly brackets within the string as expressions
        - True
    8. Console.Write() will add a newline character automatically after the end of the string
        -False 
    9. C# is not a case sensitive language
        - False 
    10. Before C# 6.0, composite formatting had to be used instead of string interpolation
        - True
### Week 2 
    1. 	Method overloading occurs when a class has two or more methods with the same name and the parameter count and/or data types vary between the overloaded methods
        - True 
    2. Null-Coalescing Operator ( ?? ) checks if a value is null. If so, then use another value
        - True 
    3. The parameter array ("params" keyword) must be the first parameter in the method declaration
        - False 
    4. Namespaces are hierarchical and can have any amount of levels
        - True 
    5. The type name qualifier can be omitted from a method call whenever the method is a member of the same type as the calling expression
        - True 
    6. Calls to static methods require the type name qualifier if the target method is not within the same type
        - True 
    7. C# contains all of the same basic operators available in Java
        - True
    8. Methods must always be called with their FQN
        - False
    9. The using directive enables you to omit the namespace from a type declared within a child namespace
        -False
    10. The params keyword allows the number of arguments to vary in the calling code instead of being set by the target method
        - True
### Week 3 - N/A
### Week 4
    1. C# supports overriding on instance methods and properties but not fields or on any static members
        - True 
    2. All members of a base class, except for constructors and destructors are inherited by the derived class
        - True 
    3. The new modifier hides a redeclared member of the derived class from the base class
        - True 
    4. Fields marked with "protected" visibility are accessible only at code locations inside the type that declares them
        - False 
    5. Any members that are decorated with override are automatically designated as virtual
        - True 
    6. C# does not allow access modifiers on interface members; instead, it automatically defines them as public
        - True 
    7. "private" members in the base class are accessible only from the base class and other classes within the derivation chain
        - False 
    8. When declaring a derived class, follow the class identifier with a colon and then the base class name
        - True 
    9. Interfaces can never be instantiated; you cannot use new to create an interface, so interfaces do not have constructors or finalizers.   
        - True 
    10. Derived class members to wanting to be overriden must be decorated with the "override" keyword
        - True