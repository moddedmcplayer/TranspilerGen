using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Mono.Reflection;

namespace TranspilerGen;

public class ProxyDomain : MarshalByRefObject
{
    private Assembly assm;
    public void GetAssembly(string AssemblyPath)
    {
        assm = Assembly.LoadFrom(AssemblyPath);
    }

    public bool IsNull() => assm is null;
    public string getLocation => assm.Location;

    public void Execute(Action<MethodInfo> action, string[] input)
    {
        action(assm.GetType(input[0]).GetMethod(input[1]));
    }
}