using System;
using System.Threading.Tasks;

using R5T.T0131;
using R5T.T0235.T000;


namespace R5T.L0080.O001
{
    /// <summary>
    /// Repsitory context operations (<see cref="IHasRepositoryName"/>, <see cref="IHasRepositoryOwnerName"/>).
    /// </summary>
    [ValuesMarker]
    public partial interface IRepositoryContextOperations : IValuesMarker
    {
        public Task Display_ExistsRepository_ToConsole<TContext>(
            TContext context,
            bool repositoryExists)
            where TContext : IHasRepositoryName, IHasRepositoryOwnerName
        {
            var message = $"{repositoryExists}: repository-exists {context.RepositoryOwnerName}/{context.RepositoryName}";

            Console.WriteLine(message);

            return Task.CompletedTask;
        }

        public Task Display_IsPrivate_ToConsole<TContext>(
            TContext context,
            bool isPrivate)
            where TContext : IHasRepositoryName, IHasRepositoryOwnerName
        {
            var message = $"{isPrivate}: repository-is-private {context.RepositoryOwnerName}/{context.RepositoryName}";

            Console.WriteLine(message);

            return Task.CompletedTask;
        }
    }
}
