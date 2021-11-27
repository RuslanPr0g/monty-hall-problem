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
        Console.WriteLine("\tPropname: " + prop.Name);
        Console.WriteLine("\tProptype: " + prop.PropertyType);
        Console.WriteLine("\tPropmodule: " + prop.Module);
    }

    var meths = type.GetMethods();
    foreach (var meth in meths)
    {
        Console.WriteLine("\t\tMethname: " + meth.Name);
        Console.WriteLine("\t\tMethtype: " + meth.ReturnType);
        Console.WriteLine("\t\tMethmodule: " + meth.Module);
    }
    Console.WriteLine();
}

// ----------------------------------------------------------------------------

