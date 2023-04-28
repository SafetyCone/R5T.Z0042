using System;


namespace R5T.Z0042
{
    public class RepositoryNames : IRepositoryNames
    {
        #region Infrastructure

        public static IRepositoryNames Instance { get; } = new RepositoryNames();


        private RepositoryNames()
        {
        }

        #endregion
    }
}
