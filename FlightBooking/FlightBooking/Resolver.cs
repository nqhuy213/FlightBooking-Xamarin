using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightBooking
{
    public class Resolver
    {
        private static IContainer container;
        public static void Initialize(IContainer container)
        {
            Resolver.container = container;
        }

        public static T Resolve<T>()
        {
            return container.Resolve<T>();
        }
    }
}
