------ Replace Inheritance with Composition : Motivation ------ 

 -- Inheritance --

 - Inheritance is a hierarchical relationship between classes. Inheritance can denote a "is - a" relationship between classes.
 Inheritance is sometimes said to provide "weak encapsulation," because if you have code that directly uses a derived class
    then that code can be broken by changes to a base class.

 - An inheritance relationship between base classes and derived classes is often said to be fragile, 
    because small changes done in the base class can ripple out and might require changes in many places within an application.

 -- Composition --
 - Composition is the most commonly used relation in a class diagram. In general terms, composition allows a class to contain 
    an object instance of another class. 
 - Composition can be denoted as being an "as a part" or a "has a" relationship between classes.

 -In the composition approach, the derived class becomes the front-end class and the base class becomes the back-end class. 
    The composition approach provides stronger encapsulation than inheritance, because a change to a back-end class does not
        necessarily break any code that relies on the front-end class. The main advantages of composition is, 
        with carefully designed interfaces we can change references of back end

------ Benefits and Liabilities ------ 
