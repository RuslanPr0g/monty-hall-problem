using RefrlectionPrikoli;
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
Console.WriteLine("\n\n\n");

var llkk = new Kek
{
    Lole = "loll",
    MyProperty = 1,
    LOL = new Lol
    {
        IsMeme = true,
        KEK = new Kek
        {
            Lole = "loll2",
            MyProperty = 2,
            LOL = new Lol
            {
                IsMeme = true,
                KEK = new Kek
                {
                    Lole = "loll3",
                    MyProperty = 3,
                    LOL = new Lol
                    {
                        IsMeme = true,
                        KEK = new Kek
                        {
                            Lole = "loll4",
                            MyProperty = 4,
                            LOL = new Lol
                            {
                                IsMeme = true,
                                MyProperty = 5,
                            }
                        }
                    }
                }
            }
        }
    }
};

var ff = typeof(Kek);

var nameFF = ff.GetProperty("MyProperty");
if (nameFF is not null)
    Console.WriteLine(nameFF.GetValue(llkk));

