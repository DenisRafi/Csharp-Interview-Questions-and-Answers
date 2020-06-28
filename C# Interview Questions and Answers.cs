/*
 C# Interview Questions and Answers

1. What is C#? 

C# is the programming language for writing 
Microsoft .NET applications.
C# provides the rapid application development
found in Visual Basic with the power of C++.
Its syntax is similar to C++ syntax and meets
100% of the requirements of OOPs like the following:

Abstraction
Encapsulation
Polymorphism
Inheritance
 
2. What is the difference between "continue" and "break" 
statements in C#?

Using break statement, you can jump out of a loop
Using continue statement, you can jump over one 
iteration and then resume your loop execution

3. What is Managed or Unmanaged Code? 

Managed Code - The code, which is developed in
.NET framework is known as managed code. 
This code is directly executed by CLR with 
the help of managed code execution. 
Any language that is written in .NET Framework is managed code.

Unmanaged Code - The code, which is developed outside 
.NET framework is known as unmanaged code. 
Applications that do not run under the control of the 
CLR are said to be unmanaged, and certain languages such as 
C++ can be used to write such applications, which, for example, 
access low - level functions of the operating system. 
Background compatibility with the code of VB, ASP and COM 
are examples of unmanaged code.

4. What is Boxing and Unboxing? 

Boxing and Unboxing both are used for 
type conversion but have some difference:

Boxing - Boxing is the process of converting 
a value type data type to the object or to any 
interface data type which is implemented by this value type.
When the CLR boxes a value means when CLR is converting
a value type to Object Type, it wraps the value inside 
a System.Object and stores it on the heap area in application domain.

Unboxing - Unboxing is also a process which is used to extract 
the value type from the object or any implemented interface type. 
Boxing may be done implicitly, but unboxing have to be explicit by code.

The concept of boxing and unboxing underlines the C# 
unified view of the type system in which a value of 
any type can be treated as an object.

5. What is the difference between a struct and a class in C#? 

Class and struct both are the user defined data type but have some major difference:
** Struct**

The struct is value type in C# and it inherits from System.Value Type.
Struct is usually used for smaller amounts of data.
Struct can't be inherited to other type.
A structure can't be abstract.
No need to create object by new keyword.
Do not have permission to create any default constructor.
Class

The class is reference type in C# and it inherits from the System.Object Type.
Classes are usually used for large amounts of data.
Classes can be inherited to other class.
A class can be abstract type.
We can't use an object of a class with using new keyword.
We can create a default constructor.

6. Define Property in C#? 

Properties are members that provide a flexible mechanism to read,
write or compute the values of private fields, in other words by 
the property we can access private fields. 
In other words we can say that a property is a return type 
function/method with one parameter or without a parameter. 
These are always public data members.
It uses methods to access and assign values to private 
fields called accessors.

7. Why can't you specify the accessibility modifier for methods inside the interface?

In an interface, we have virtual methods that do not have method definition.
All the methods are there to be overridden in the derived class.
That's why they all are public.

8. How is Exception Handling implemented in C#? 

Exception handling is done using four keywords in C#:

try – Contains a block of code for which an exception will be checked.
catch – It is a program that catches an exception with the help of exception handler.
finally – It is a block of code written to execute regardless whether an exception is caught or not.
Throw – Throws an exception when a problem occurs.

9. Can you return multiple values from a function in C#? 

Yes! Using output parameters. A return statement
can be used for returning only one value from a function. 
However, using output parameters, you can return two values from a function.

10. What is namespace in C#? 

A namespace is designed for providing a way to keep one set of names separate from another.
The class names declared in one namespace does not conflict with the same class names declared in another.

11. What are dynamic type variables in C#?

You can store any type of value in the dynamic data type variable.
Type checking for these types of variables takes place at run-time.

12. Why to use “finally” block in C#? 

Finally block will be executed irrespective of exception.
So while executing the code in try block when exception is occurred,
control is returned to catch block and at last finally block will be executed.
So closing connection to database / releasing the file handlers can be kept in finally block.

13. What is the difference between Interface and Abstract Class? 

There are some differences between Abstract Class and Interface which are listed below:

A class can implement any number of interfaces but a subclass can at most use only one abstract class.
An abstract class can have non-abstract methods (concrete methods) while in case of interface all the methods has to be abstract.
An abstract class can declare or use any variables while an interface is not allowed to do so.
In an abstract class all data member or functions are private by default while in interface all are public, we can't change them manually.
In an abstract class we need to use abstract keyword to declare abstract methods while in an interface we don't need to use that.
An abstract class can't be used for multiple inheritance while interface can be used as multiple inheritance.
An abstract class use constructor while in an interface we don't have any type of constructor.

14. What is the difference between ref and out keywords? 

The out keyword causes arguments to be passed by reference. This is similar to the ref keyword,
except that ref requires that the variable be initialized before being passed.
The ref keyword causes an argument to be passed by reference, not by value. 
The effect of passing by reference is that any change to the parameter
in the method is reflected in the underlying argument variable in the calling method.

15. What is delegates in C# and uses of delegates? 

C# delegates are same as pointers to functions, in C or C++. 
A delegate Object is a reference type variable that use to holds the reference to a method.
The reference can be changed at runtime which is hold by an object of delegate,
a delegate object can hold many functions reference which is also known as Invocation 
List that refers functions in a sequence FIFO, we can new functions ref in this list 
at run time by += operator and can remove by -= operator.

Delegates are especially used for implementing events and the call-back methods.
All delegates are implicitly derived from the System.Delegate class.

16. What is the difference between overloading and overriding? 

//Overloading
public class 
{
    public void getStuff(int id)
    {}
    public void getStuff(string name)
    {}
}

//Overriding
public class 
{
        public virtual void getStuff(int id)
        {
            
        }
}

public class 
{
        public override void getStuff(int id)
        {
            
        }
}

17. Explain Anonymous type in C# 

Anonymous types allow us to create a new type without defining them.
This is way to defining read only properties into a single object without
having to define type explicitly. Here Type is generating by the compiler
and it is accessible only for the current block of code.
The type of properties is also inferred by the compiler.

var anonymousData = new
{  
     ForeName = "Denis",  
     SurName = "Rafi"
};  

Console.WriteLine("First Name : " + anonymousData.ForeName); 

18. What is difference between constants and readonly? 

Constant variables are declared and initialized at compile time.
The value can't be changed afterwards. 
Readonly is used only when we want to assign the value at run time.

19. What is a Destructor in C#? 

A Destructor is used to clean up the memory and free the resources.
But in C# this is done by the garbage collector on its own. System.GC.Collect()
is called internally for cleaning up. But sometimes it may be necessary to implement destructors manually.

20. How encapsulation is implemented in C#? 

Encapsulation is implemented by using access specifiers. 
An access specifier defines the scope and visibility of a class member.

Public access specifier allows a class to expose its member variables and member
functions to other functions and objects. Any public member can be accessed from outside the class.
Private access specifier allows a class to hide its member variables and member
functions from other functions and objects. Only functions of the same class can access its private members.
Even an instance of a class cannot access its private members.
Protected access specifier allows a child class to access the member variables and member functions of its base class.
This way it helps in implementing inheritance.

21. What is the output of the program below? Explain your answer. 

delegate void Printer();

static void Main()
{
        List<Printer> printers = new List<Printer>();
        int i=0;
        for(; i < 10; i++)
        {
            printers.Add(delegate { Console.WriteLine(i); });
        }

        foreach (var printer in printers)
        {
            printer();
        }
}

This program will output the number 10 ten times.

Here’s why: The delegate is added in the for loop and “reference” 
(or perhaps “pointer” would be a better choice of words) to i is stored, rather than the value itself. 
Therefore, after we exit the loop, the variable i has been set to 10, so by the time each delegate is invoked,
the value passed to all of them is 10.

22. Refactor the code 

class ClassA
{
  public ClassA() { }

  public ClassA(int pValue) {  }
}

// client program
class Program
{
  static void Main(string[] args)
  {
    ClassA refA = new ClassA();
  }
}

class ClassA
{
  public ClassA() : this(10)
  { }

  public ClassA(int pValue)
  {  }
}


23. What is lambda expressions in C#? 

A lambda expression is an anonymous function that you can use to create delegates or expression tree types.
By using lambda expressions, you can write local functions that can be passed as arguments or returned as the value of function calls. 
Lambda expressions are particularly helpful for writing LINQ query expressions.

24. What is Console application?

A console application is an application that can be run in the command prompt in Windows.
For any beginner on .Net, building a console application is ideally the first step, to begin with.

25. Is C# code is managed or unmanaged code?

C# is managed code because Common language runtime can compile C# code to Intermediate language.

26. What is the difference between directcast and ctype?

DirectCast is used to convert the type of object that requires the run-time type to be the same as the specified type in DirectCast.

Ctype is used for conversion where the conversion is defined between the expression and the type.

27. How to implement a singleton design pattern in C#?

In a singleton pattern, a class can only have one instance and provides an access point to it globally.

Eg:

Public sealed class Singleton
{
Private static readonly Singleton _instance = new Singleton();
}

28. What are C# attributes and its significance?

C# provides developers a way to define declarative tags on certain entities,
eg. Class, method, etc. are called attributes. The attribute's information
can be retrieved at runtime using Reflection.

29. What is difference between the "throw" and "throw ex" in .NET?

"Throw" statement preserves original error stack whereas "throw ex"
have the stack trace from their throw point. It is always advised to use
"throw" because it provides more accurate error information.

30. What are indexers in C# .NET?

Indexers are known as smart arrays in C#. It allows the instances of a class to be indexed in the same way as an array.

Eg:

public int this[int index]    // Indexer declaration

31. What's a multicast delegate?

A delegate having multiple handlers assigned to it is called multicast delegate. Each handler is assigned to a method.

32. What is difference between "is" and "as" operators in C#?

"is" operator is used to check the compatibility of an object with a given type, and it returns the result as Boolean.

"as" operator is used for casting of an object to a type or a class.

32. How we can create an array with non-default values?

We can create an array with non-default values using Enumerable.Repeat.

32. How to use nullable types in .Net?

Value types can take either their normal values or a null value. Such types are called nullable types.

Int? someID = null;
If(someID.HasVAlue)
{

}

33. What is the difference between a Struct and a Class?

Structs are value-type variables, and classes are reference types.
Structs stored on the Stack causes additional overhead but faster retrieval.
Structs cannot be inherited.

34. What happens if the inherited interfaces have conflicting method names?

Implement is up to you as the method is inside your own class. 
There might be a problem when the methods from different interfaces
expect different data, but as far as compiler cares you're okay.

35. How can we set the class to be inherited, but prevent the method from being over-ridden?

Declare the class as public and make the method sealed to prevent it from being overridden.

By Denis Rafi 

 */