using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Infrastructure
{
    public static class FitnessContainer
    {
        public static IContainer Instance
        {
            get;set;
        }
    }
}
