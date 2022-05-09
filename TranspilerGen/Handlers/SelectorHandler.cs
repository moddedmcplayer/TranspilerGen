using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using TranspilerGen.Info;

namespace TranspilerGen.Handlers
{
    public class SelectorHandler
    {
        public List<Type> types;
        public List<MethodInfo> methods;
        public List<string> getLetters()
        {
            List<string> collection = new List<string>();
            foreach (var type in GenInfo.ModdedAssembly.GetTypes())
            {
                if(!collection.Contains(type.Name[0].ToString().ToUpper()))
                    collection.Add(type.Name[0].ToString().ToUpper());
            }
            return collection;
        }
        
        public string[] getClasses(char character)
        {
            types = new List<Type>();
            foreach (var type in GenInfo.ModdedAssembly.GetTypes().Where(x => x.FullName.StartsWith(character.ToString(), true, null)))
            {
                if(!types.Contains(type))
                {
                    types.Add(type);
                }
            }
            return types.ConvertAll(x => x.FullName).ToArray();
        }
        
        public string[] getMethods(TypeInfo type)
        {
            methods = new List<MethodInfo>();
            foreach (var method in type.GetMethods())
            {
                if(!methods.Contains(method))
                {
                    methods.Add(method);
                }
            }
            return methods.ConvertAll(x => x.ToString()).ToArray();
        }
    }
}