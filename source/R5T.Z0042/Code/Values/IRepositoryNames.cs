using System;

using R5T.T0131;
using R5T.T0186;
using R5T.T0186.Extensions;


namespace R5T.Z0042
{
    [ValuesMarker]
    public partial interface IRepositoryNames : IValuesMarker
    {
        private static Z0014.IRepositoryNames StringlyTyped => Z0014.RepositoryNames.Instance;


        public IRepositoryName Test => StringlyTyped.TestRepository.ToRepositoryName();
    }
}
