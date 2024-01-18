using System;

using R5T.T0137;

using R5T.T0235.T000;


namespace R5T.L0080.T001
{
    [ContextImplementationMarker, ContextTypeMarker]
    public class RepositoryContext :
        IWithRepositoryName,
        IWithRepositoryOwnerName
    {
        public string RepositoryName { get; set; }
        public string RepositoryOwnerName { get; set; }
    }
}
