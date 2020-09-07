using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Core.Context
{
    public class ELibraryDbInitializer
    {
        private static ElibraryContext context;
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ElibraryContext>();
            }
        }
    }
}
