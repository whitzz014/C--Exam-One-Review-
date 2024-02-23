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

## My Code 

### Person Class 
    ```
        class Person
        {
            //Properties ++ Getters & Setters
            public string Name { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }

            //Constructor
            public Person(string name, string address, string phoneNumber)
            {
                Name = name;
                Address = address;
                PhoneNumber = phoneNumber;
            }

            // Override the default ToString method to provide a custom string representation of the object.
            public override string ToString()
            {
                //Format the output to be this string 
                return $"Name: {Name}, Address: {Address}, Phone Number: {PhoneNumber}";
            }
        }
    ```
### Customer Class

    ```
        class Customer : Person
        {
            //Properties
            public int CustomerNumber;
            public bool OnMailingList;

            //initalizing name, address, phoneNumber from parent class 
            public Customer(int customerNumber, bool onMailingList, string name, string address, string phoneNumber ) 
                : base(name, address, phoneNumber)
            {
                CustomerNumber = customerNumber;
                OnMailingList = onMailingList;
            }

            //samething as parent 
            public override string ToString()
            {
                return $"Customer Number: {CustomerNumber}, On Mailing List? {IsOnMailingList}";
            }
        }
    ```

### Preferred Customer 
    ```
    class PreferredCustomer : Customer
        {
           
            //Properties 
            public int AmountSpent {get; set;}
        
            // Public property with a custom getter 
            public double DiscountLevel
            {
                get
                {
                    //if to set custom discount amounts 
                    if (AmountSpent >= 2000)
                    {
                        return 0.1;
                    }
                    else if (AmountSpent >= 1500)
                    {
                        return 0.07;
                    }
                    else if (AmountSpent >= 1000)
                    {
                        return 0.06;
                    }
                    else if (AmountSpent >= 500)
                    {
                        return 0.05;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            public PreferredCustomer(string name, string address, string phoneNumber, int customerNumber, bool onMailingList, int amountSpent)
                : base( customerNumber,  onMailingList,  name,  address,  phoneNumber)
            {
                AmountSpent = amountSpent;
            }

            public override string ToString()
            {
                return $"Name: {Name}\n Address: {Address}\n Phone Number: {PhoneNumber.ToPhoneNumber()}\n " +
                    $"Customer Number: {CustomerNumber}\n On Mailing List: {OnMailingList}\n " +
                    $"Customer Purchases: {Extension.ToCurrency(AmountSpent)}\n Discount Level: {DiscountLevel.ToPercentage()}"; ;
            }
        }
    ```
### Extension 
    ```
    static class Extension
        {
            public static string ToPercentage(this double value)
            {
                //P repersents percentage
                return $"{value:P}";
            }

            public static string ToCurrency(this double value)
            {
                // C=>currency
                return $"{value:C}";
            }

            public static string ToPhoneNumber(this string phoneNumber)
            {
                return $"({phoneNumber.Substring(0, 3)}) {phoneNumber.Substring(3, 3)}-{phoneNumber.Substring(6)}";
            }
        }
    ```

### Program 

    ```
     class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];

            //Runs the program 3 times 
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the Customer's Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the Customer's Address: ");
                string address = Console.ReadLine();

                Console.WriteLine("Enter the Customer's Phone Number: ");
                string pNumber = Console.ReadLine();

                Console.WriteLine("Enter the Customer Number: ");
                int cNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Would the customer like to sign up for the mailing list? (y/n): ");
                bool isOnMailingList = Console.ReadLine().Trim().ToLower() == "y";

                Console.Write("Enter the amount spent last year by the customer: ");
                int amountSpentLastYear = int.Parse(Console.ReadLine());

                //insert depending on value of i (which turn is it)
                customers[i] = new PreferredCustomer(name, address, pNumber, cNumber, isOnMailingList, amountSpentLastYear);
            }
            // displays based to string  method for every  object in customers array
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
        }
    }
    ```

### Output 

    ```
    Enter the Customer's Name:
    brock
    Enter the Customer's Address:
    1
    Enter the Customer's Phone Number:
    6727628901
    Enter the Customer Number:
    1
    Would the customer like to sign up for the mailing list? (y/n):
    y
    Enter the amount spent last year by the customer: 2000
    Enter the Customer's Name:
    Yuji
    Enter the Customer's Address:
    2
    Enter the Customer's Phone Number:
    1234567890
    Enter the Customer Number:
    2
    Would the customer like to sign up for the mailing list? (y/n):
    n
    Enter the amount spent last year by the customer: 750
    Enter the Customer's Name:
    Levi
    Enter the Customer's Address:
    3
    Enter the Customer's Phone Number:
    3216540987
    Enter the Customer Number:
    3
    Would the customer like to sign up for the mailing list? (y/n):
    n
    Enter the amount spent last year by the customer: 0
    Name: brock
    Address: 1
    Phone Number: (672) 762-8901
    Customer Number: 1
    On Mailing List: True
    Customer Purchases: $2,000.00
    Discount Level: 0.00%
    Name: Yuji
    Address: 2
    Phone Number: (123) 456-7890
    Customer Number: 2
    On Mailing List: False
    Customer Purchases: $750.00
    Discount Level: 0.00%
    Name: Levi
    Address: 3
    Phone Number: (321) 654-0987
    Customer Number: 3
    On Mailing List: False
    Customer Purchases: $0.00
    Discount Level: 0.00%
    ```

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