using System;


namespace R5T.L0080.F002
{
    public class RepositoryOperator : IRepositoryOperator
    {
        #region Infrastructure

        public static IRepositoryOperator Instance { get; } = new RepositoryOperator();


        private RepositoryOperator()
        {
        }

        #endregion
    }
}
