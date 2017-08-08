using Abp.Domain.Services;

namespace YT
{
    public abstract class YtDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected YtDomainServiceBase()
        {
            LocalizationSourceName = YtConsts.LocalizationSourceName;
        }
    }
}
