------ Motivation ------ 

 -- If you have multiple constructors, programmers will have to choose which constructor to call by studying the expected parameters and/or poking around at the constructor code
 -- Constructors simply don’t communicate intention efficiently or effectively. 
        The more constructors you have, the easier it is for programmers to choose the wrong one. 
        Having to choose which constructor to call slows down development, and the code that does call one of the many constructors often fails to sufficiently communicate
        the nature of the object being constructed
 -- It’s common, particularly on mature systems, to find numerous constructors that are no longer being used yet continue to live on in the code. 
        Dead constructors only bloat a class and make it more complicated than it needs to be 

This refactoring technique can help if your code contains operators performing various tasks that vary based on:

 -- 



------ Benefits and Liabilities ------ 
