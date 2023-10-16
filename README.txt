# CS50 Medical App
#### Video Demo:  https://youtu.be/8yEgPj0TECc
#### Description:
    This is a GUI interface using C# Windows .NET forms to allow users to register, lookup and delete patients in a database.
    Upon starting the application, users will be able to:
    Register - input details into a form, generate a unique patient ID and pass that information into a SQL database
    Lookup - Lookup patient details either by the unique patient ID number, or via name and date of birth
    Delete - delete a patient from the database using either patient ID, or via name / date of birth search, with
        a confirmation to prevent accidental deletion.
    I chose this project to challenge myself with a language not covered in the CS50 course, C# was entertaining to learn, with a robust community in both Microsoft official documentation and forums such as Unity and StackOverflow

#### CODE OVERVIEW:
Welcome.cs:
    The Welcome form is a simple starting platform, with buttons for each of the functions this program offers; Register, Lookup, & Delete
register.cs:
    Register needed to handle several functions. first of all it needed to verify that all non optional fields have been filled and are valid by implementing a validation check near the beginning I made it easier to for myself to change the number of validators as it was being written this also allowed for a lot of flexibility.
    Next, all of the data is converted to strings, including date of birth, for easier storage in the SQL database.
    A unique patient ID is created using a system similar to the UK's NHS system, taking someones date of birth in the format DDMMYY and appending 4 random digits on the end.
    This newly generated patient ID is then passed through a SQL query to ensure that it is actually unique.
    After this, a SQL query is exceuted based on if optional fields were filled or not. The registration form informs the user if successful and the form is closed
    Below the main segment are a few methods to help keep the code clean, GetPatientID does exactly as described above, taking the DateTime inputted and converting it to a unique ID number
    ConsolidateAddress converts multiple lines of the address in to one easily read, easily stored string (line breaks become comma separations so later those commas can be replaced with line breaks again)
lookup.cs:
    Lookup functions to allow users to look up patient contact details and can work two different ways;
    - the first is to input the patient ID, this checks the number exists and passes that information to the displayform
    - the second takes forename, surname and date of birth in order to find the patient, first checking each field has been filled properly, then returning the patient ID to be sent to the displayform
displayform:
    Initially the lookup form handled looking up the data, which would be saved in a dictionary and passed to the display form however i decided to tidy up my code and have just the patient ID as a string passed to the displayform, which upon loading, would perform the lookup and display the information this helped to make the structure of my project easier to manage and also allowed me to play around with object oriented concepts like overloading method
delete.cs:
    Delete functions in a very similar way to Lookup, as it's main function is to validate a patient's existence within the database before confirming deletion
deleteconfirm.cs:
    In order to prevent accidental deletion I took a leaf from World Of Warcraft where if you want to delete a character you have to type "DELETE" into a dialogue box this form also displays the full name of the patient to be deleted so that users can confirm they are deleting the correct patient. 
    Once confirmed, a SQL query is executed that removes that patient from the database, using patient ID as the identifying information
utilities.cs:
    To help keep my code readable and tidy I created a utlity script for methods i was either likely to use again or where too verbose that i felt they needed separating
    firstly, in order to maintain my sanity, i made a public string for the connection string to my database, this freed me from having to type out a long connection string every time
    next, i created the method used to look up a patient's details, aptly named GetPatientDetails, taking patient ID as an argument and returning a dictionary with easily referenced keys such as
    "Phone" and "Address".
    the next two methods, VerifyPatientID, were used in the lookup and delete forms to return a valid patient ID number to be used in the GetPatientDetails method
    these methods allowed me to practice with overloading methods as one takes the name and date of birth, returning the patient ID, and the other takes patient ID, checks its valid, then returns it if it is

Overall, I am satisfied with how this project turned out. After my initial planning stage a few factors caused my project to become bloated and messy and i had to start again from scratch
however this was a valuable lesson in learning to let go and refocus. I am incredibly thankful to the CS50 team at Harvard for providing these courses and getting me started on what will hopefully be a new career
Thank you for reading,
    Will Cooke, Edinburgh, Scotland
