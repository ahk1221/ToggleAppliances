﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Harmony;

namespace ToggleAppliances
{
    public class Main
    {
        public static void Patch()
        {
            var harmony = HarmonyInstance.Create("com.ahk1221.toggleappliances");
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            Console.WriteLine("[ToggleAppliances] Successfully patched!");
        }
    }
}
