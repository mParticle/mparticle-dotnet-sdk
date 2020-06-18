using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace mParticle.Client
{
    internal static class Extensions
    {
        internal static string ToPrettyJson(this string json, int indentations)
        {
            string indentationString = "";
            for(var i = 0; i < indentations; i++)
            {
                indentationString += "\t";
            }
            try
            {
                return indentationString + JValue.Parse(json).ToString(Formatting.Indented).Replace("\n", "\n" + indentationString);
            }
            catch(Exception)
            {
                return json;
            }
        }

        internal static void RemoveCollection<T>(this List<T> targetList, List<T> list)
        {
            var set = new HashSet<T>();
            foreach(T t in list)
            {
                set.Add(t);
            }
            targetList.RemoveAll(x => set.Contains(x));
        }
    }
}
