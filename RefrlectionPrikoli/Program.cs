using System.Reflection;

var ass = Assembly.GetExecutingAssembly();

Console.WriteLine(ass.FullName);

Console.WriteLine(ass.ExportedTypes);

Console.WriteLine(ass.DefinedTypes);

Console.WriteLine(ass.CodeBase);

Console.WriteLine(ass.HostContext);

var types = ass.GetTypes();

foreach (var type in types)
{
    Console.WriteLine("Name: " + type.Name);
    Console.WriteLine("FullName: " + type.FullName);
    Console.WriteLine("BaseType: " + type.BaseType);
    Console.WriteLine("CustomAttrs: " + type.CustomAttributes);

    var props = type.GetProperties();
    foreach (var prop in props)
    {
        Console.WriteLine("Propname: " + prop.Name);
        Console.WriteLine("Proptype: " + prop.PropertyType);
        Console.WriteLine("Propmodule: " + prop.Module);
    }
    Console.WriteLine();
}