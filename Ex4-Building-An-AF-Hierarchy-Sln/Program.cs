﻿using System;
using External;

namespace Ex4_Building_An_AF_Hierarchy_Sln
{
    class Program
    {
        static void Main(string[] args)
        {
            AFHierarchyBuilder builder = new AFHierarchyBuilder("PISRV01");
            builder.CreateDatabase();
            builder.CreateCategories();
            builder.CreateEnumerationSets();
            builder.CreateTemplates();
            builder.CreateElements();
            builder.SetAttributeValues();
            builder.CreateDistrictElements();
            builder.CreateWeakReferences();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
