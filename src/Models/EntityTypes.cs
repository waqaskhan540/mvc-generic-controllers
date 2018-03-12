using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace genericcontroller.Models
{
    public static class EntityTypes
    {
        public static IReadOnlyList<TypeInfo> Types => new List<TypeInfo>()
        {
            typeof(Sprocket).GetTypeInfo(),
            typeof(Widget).GetTypeInfo()
        };

        public class Sprocket { }
        public class Widget { }
    }
}
