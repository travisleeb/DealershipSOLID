# DealershipSOLID
Using a Car Dealership project model to showcase typical MVC and SOLID methodology

04/26/21:  This is a recreation of a MVC pattern / SOLID design principle program I have written before.  However some things have changed since last time, or 
          I'm just dealing with weird environmental issues.  Using Excel as a stand-in database so a person can bring down this code to run it immediately, what
          once worked perfectly now fails due to permission issue with ClosedXML.  Not sure what exactly is the problem but it's holding me up from finishing the View portion
          of this. 
          
          I'm happy with how most of this turned out, able to add some new SOLID tricks I've learned.  I will say the Excel problem frustrated me so the whole structure started
          coming off the rails a bit with the Controller trying to call the Domain directly, which I would not have preferred.  
          
          If I did this over again, this would be better as a MVVM (Model-View-ViewModel) design pattern since it's more Client oriented than Service oriented. 
          Also, if this was a MVVM pattern, I could consolidate the AddType/RemoveType functions in each of the vehicle type classes and housed it just once in a View model
          instead of repeating it.   Code the repeats is a smell that says this can be centralized and reused. 
