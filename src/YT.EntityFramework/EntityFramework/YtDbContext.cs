using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using YT.Authorizations;
using YT.Managers.MultiTenancy;
using YT.Managers.Roles;
using YT.Managers.Users;
using YT.MultiTenancy;
using YT.Navigations;
using YT.Storage;

namespace YT.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */

    public class YtDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

  

            /// <summary>
            /// ≤Àµ•≈‰÷√
            /// </summary>
            public  virtual  IDbSet<Menu> Menus { get; set; }
        /// <summary>
        /// »®œﬁ≈‰÷√
        /// </summary>
        public  virtual  IDbSet<YtPermission> YtPermissions { get; set; }
        public YtDbContext()
            : base("Default")
        {
            
        }

        public YtDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public YtDbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public YtDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
