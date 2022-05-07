using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using TranspilerGen.Info;

namespace TranspilerGen.Handlers
{
    public class SelectorHandler
    {
        public List<TypeInfo> types;
        public List<MethodInfo> methods;
        public List<string> getLetters()
        {
            List<string> collection = new List<string>();
            foreach (var type in GenInfo.ModdedFile.GetTypes())
            {
                if(!collection.Contains(type.Name[0].ToString()))
                    collection.Add(type.Name[0].ToString());
            }
            return collection;
        }
        
        public TypeInfo[] getClasses(char character)
        {
            types = new List<TypeInfo>();
            foreach (var type in GenInfo.ModdedFile.GetTypes().Where(x => x.Name[0] == character))
            {
                if(!types.Contains(type.GetTypeInfo()))
                {
                    types.Add(type.GetTypeInfo());
                }
            }
            return types.ToArray();
        }
        
        public MethodInfo[] getMethods(TypeInfo type)
        {
            methods = new List<MethodInfo>();
            foreach (var method in type.DeclaredMethods)
            {
                if(!methods.Contains(method))
                {
                    methods.Add(method);
                }
            }
            return methods.ToArray();
        }
    }
}