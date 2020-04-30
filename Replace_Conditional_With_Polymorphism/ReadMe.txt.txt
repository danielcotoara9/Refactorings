------ Motivation ------ 

This refactoring technique can help if your code contains operators performing various tasks that vary based on:

 -- Class of the object or interface that it implements

 -- Value of an object’s field

 -- Result of calling one of an object’s methods

If a new object property or type appears, you will need to search for and add code in all similar conditionals. 
Thus the benefit of this technique is multiplied if there are multiple conditionals scattered throughout all of an object’s methods.

------ Benefits and Liabilities ------ 

 -- This technique adheres to the Tell-Don’t-Ask principle: instead of asking an object about its state and then performing actions based on this,
 it’s much easier to simply tell the object what it needs to do and let it decide for itself how to do that.

 -- Removes duplicate code. You get rid of many almost identical conditionals.

 -- If you need to add a new execution variant, all you need to do is add a new subclass without touching the existing code (Open/Closed Principle).