using System.Reflection;
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
        //When applying the attributes to anything, we do not need to type the "Attribute" part though.
        //Like check the ExpClass below
        
        //Since attributes are classes in essence, they can have any type of members in the definition that a normal class can do.
        //Between square brackets, when an attribute is applied to a concept, only the properties declared in the applied attribute's...
        //... class are accessible apart from the contructor if declared in the relevant attribute class.
        //We utilize from the attribute's constructor between the square bracket in the regular way with paranthesis by giving values...
        //... to the properties as if we use the object initializer and to the parameteres if the constructor has.
        
        //Multiple attributes can be applied to the same concept.
        //You can do that by leaving commas between diff attributes in the same square brackets or putting each attribute between diff square brackets.
        //Exp: [Attribute1, Attribute2] / [Attribute1][Attribute2]
        //We can send arguments in the constructor of an attribute with the constant properties declared in the class the relevant attribute is applied to. 
        //Check ExpClass3 below
        
        //Assembly Level Attributes
        //In default, attributes are run-time concept. However, we can perform operations with attributes in the compile time too via assembly keyword.
        //To qualify an attribute with that feature, we needa mark the attribute with the keyword in the AssemblyInfo.cs file.
        //If you wanna check it, here is the path SolutionName\ProjectName\obj\Debug\net9.0\ProjectName.AssemblyInfo.cs

    }
}
//[CustomAttribute] //Instead of this,
[Custom(property1 = 20, property2 = 0)]
class ExpClass1
{
}
[Custom1(20, 10, property1 = 15, property2 = 20)]
class ExpClass2
{
}
[Custom1(20, field2, property1 = 15, property2 = 20)]
class ExpClass3
{
    public int Field1 { get; set; }
    const int field2 = 20;
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Delegate)] //We specify which concepts our attribute can be applied to here
//We are not obligated to utilize from AttributeUsage attribute, our attribute would become usable for any concept in default in that case.
class CustomAttribute : Attribute
{
    public int property1 { get; set; }
    public int property2 { get; set; }
}
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Delegate)]
class Custom1Attribute : Attribute
{
    public int property1 { get; set; }
    public int property2 { get; set; }

    public Custom1Attribute(int Arg1, int Arg2)
    {
    }
}