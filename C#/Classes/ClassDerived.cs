using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// inheritance is a concept of re-using the code of the other class, which means re-using the members, methods 
// and attributes of the parent class
// the existance class is called a base class and new class which is referred is called Derived class 

// there are four types of inheritance 
// single inheritance - in which has one base class and one derived class
// hierarchical inheritance -  in which multiple classes are derived from base class
// multilevel inheritance - if a class is derived from a derived class
// multiple inheritance - in which has more than one base classes inherit one derived class (not possible)


// advantages and disadvantages of inheritance 
/* reduces code redudancy and code re-usability
 * reduces source code size and code readability
 * after using inheritance in your code, which is used to manage into parent and child classes
 * 
 * if you change the property in the main class, the child classes will be altered hence both child and base
 * classes are tightly coupled
 * 
 * The disadvantages are that if the derived class or the parent class are not ulilized then there is memory 
 * loss while execution of the code
 */



namespace Classes
{
    class ClassDerived : Employee
    {
        protected double salary { get; set; }

    }
}
