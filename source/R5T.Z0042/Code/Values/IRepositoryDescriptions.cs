using System;

using R5T.T0131;
using R5T.T0184;
using R5T.T0184.Extensions;


namespace R5T.Z0042
{
    [ValuesMarker]
    public partial interface IRepositoryDescriptions : IValuesMarker
    {
        private static Z0014.IRepositoryDescriptions StringlyTyped => Z0014.RepositoryDescriptions.Instance;


        public IRepositoryDescription ForTest => StringlyTyped.ForTestRepository.ToRepositoryDescription();
    }
}
