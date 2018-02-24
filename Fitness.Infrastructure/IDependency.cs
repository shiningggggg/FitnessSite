using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Infrastructure
{
    public interface IDependency
    {

    }
    /// <summary>
    /// Base interface for services that are instantiated per shell/tenant
    /// </summary>
    public interface ISingletonDependency : IDependency
    {

    }
    /// <summary>
    /// Base interface for services that may *only* be instantiated in a unit of work.
    /// This interface is used to guarantee they are not accidentally referenced by a singleton dependency.
    /// </summary>
    public interface IUnitOfWorkDependency : IDependency
    {

    }
}
