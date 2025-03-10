using System.Text.Json.Serialization;

namespace CSAdvancedProgramming19_Attreibutes;

//Attribute Instance
[JsonSerializable(typeof(InvalidProgramException))]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Delegate)] //We specify on which concept our attribute will be here
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

class CustomAttribute : Attribute
{
}