using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0132;

using R5T.L0080.T001;


namespace R5T.L0080.F001
{
    [FunctionalityMarker]
    public partial interface IRepositoryOperator : IFunctionalityMarker
    {
        public async Task In_RepositoryContext(
            string repositoryOwnerName,
            string repositorName,
            IEnumerable<Func<RepositoryContext, Task>> operations)
        {
            var repositoryContext = new RepositoryContext
            {
                RepositoryName = repositorName,
                RepositoryOwnerName = repositoryOwnerName,
            };

            await Instances.ContextOperator.In_Context(
                repositoryContext,
                operations);
        }

        public Task In_RepositoryContext(
            string repositoryOwnerName,
            string repositorName,
            params Func<RepositoryContext, Task>[] operations)
        {
            return this.In_RepositoryContext(
                repositoryOwnerName,
                repositorName,
                operations.AsEnumerable());
        }
    }
}
