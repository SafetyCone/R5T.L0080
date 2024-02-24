using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0221;
using R5T.T0235.T000;


namespace R5T.L0080.F002
{
    [FunctionalityMarker]
    public partial interface IRepositoryOperator : IFunctionalityMarker
    {
        public Task In_RepositoryContext<TContext>(
            string repositoryOwnerName,
            string repositoryName,
            out (IsSet<IHasRepositoryName>, IsSet<IHasRepositoryOwnerName>) propertiesSet,
            IEnumerable<Func<TContext, Task>> operations)
            where TContext : IWithRepositoryName, IWithRepositoryOwnerName, new()
        {
            var context = new TContext
            {
                RepositoryOwnerName = repositoryOwnerName,
                RepositoryName = repositoryName,
            };

            return Instances.ContextOperator.In_Context(
                context,
                operations);
        }

        public Task In_RepositoryContext<TContext>(
            string repositoryOwnerName,
            string repositoryName,
            out (IsSet<IHasRepositoryName>, IsSet<IHasRepositoryOwnerName>) propertiesSet,
            params Func<TContext, Task>[] operations)
            where TContext : IWithRepositoryName, IWithRepositoryOwnerName, new()
        {
            return this.In_RepositoryContext(
                repositoryOwnerName,
                repositoryName,
                out propertiesSet,
                operations.AsEnumerable());
        }

        public Task In_RepositoryContext<TContext>(
            string repositoryOwnerName,
            string repositoryName,
            Func<TContext> contextConstructor,
            out (IsSet<IHasRepositoryName>, IsSet<IHasRepositoryOwnerName>) propertiesSet,
            IEnumerable<Func<TContext, Task>> operations)
            where TContext : IWithRepositoryName, IWithRepositoryOwnerName
        {
            var context = contextConstructor();

            context.RepositoryName = repositoryName;
            context.RepositoryOwnerName = repositoryOwnerName;

            return Instances.ContextOperator.In_Context(
                context,
                operations);
        }

        public Task In_RepositoryContext<TContext>(
            string repositoryOwnerName,
            string repositoryName,
            Func<TContext> contextConstructor,
            out (IsSet<IHasRepositoryName>, IsSet<IHasRepositoryOwnerName>) propertiesSet,
            params Func<TContext, Task>[] operations)
            where TContext : IWithRepositoryName, IWithRepositoryOwnerName
        {
            return this.In_RepositoryContext(
                repositoryOwnerName,
                repositoryName,
                contextConstructor,
                out propertiesSet,
                operations.AsEnumerable());
        }

        //public Task In_RepositoryContext<TContext>(
        //    Func<TContext> contextConstructor,
        //    IEnumerable<Func<TContext, Task>> operations)
        //    where TContext : IWithRepositoryName, IWithRepositoryOwnerName
        //{

        //}
    }
}
