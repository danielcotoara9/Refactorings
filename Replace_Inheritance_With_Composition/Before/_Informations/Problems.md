------ Replace Inheritance with Composition - Problems------

There is a saying that we should FAVOR Composition over Inheritance

 - Story
    - Phase_1 - First create the Monster class (with 2 properties HitPoints and AttackDamage)
    - Phase_2 - After a while we need to create let's say 3 types of monster
        - Monster that attack by 
            - biting
            - kicking
            - punching
        - All types of Monster will have HitPoints 
    - Phase_3 - After a while new requirements come and we have to do the next things
        - Some monsters can do different kind of attacks
            - biting and kicking monster
            - biting and punching monster
            - biting, kicking and punching monster
            Here we start to have problems. We know that in C# we cannot inherit from multiples classes!
            So we will add three more classes BitingKigingMonster, KickingPunchingMonster\
            Now we have 7 childs of the base class Monster !!!
    - Phase_4 - After a while new requiremenst come and we have to do the next things
        - Add a new monster that spits - Cobra
        - Add a new prperty to orc that can spit also
        - Add other combinations of monsters
        Now this thing will be harder and harder to do and MAINTAIN => Let's try COMPOSITION



------ Benefits and Liabilities ------ 
