using System.Text.Json.Serialization;

namespace CSAdvancedProgramming19_Attreibutes;

//Attribute Instance
[JsonSerializable(typeof(InvalidProgramException))]
class Program
{
    static void Main(string[] args)
    {
        //Attributes
        //represents metadata of nearly all the programming concept structures (like classes, properties, methods, structures, etc.)
        
        //What's metadata then?
        //-It is data containing data about these conceptual structures. (Data about data in universal.)
        
        //Attribute Creation
        //Attributes are classes in essence.
        //Custom attribute class names must implement Attribute class and should end with Attribute for the name condition tradition.      
    }
}
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Delegate | AttributeTargets.Method)] //We specify on which concept our attribute will be here
//Gotta be right above our CustomAttribute class
class CustomAttribute : Attribute
{
}

//Attributes can be implemented in two format ways;
//[CustomAttribute]
[Custom] //(without the "Attribute" in the name of our attribute)
class ExpClass //We can set our attribute to our classes...
{
    //... to our methods
    public static void ExpMethod()
    {
    }

    public delegate void ExpHandler<t1>(t1 obj1);
}