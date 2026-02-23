namespace AdvanceCRM.Administration.Scripts
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;
    using System;
    using AdvanceCRM.Web.Helpers;
    using AdvanceCRM.Administration.Entities;

    /// <summary>
    /// Lookup for users with InsideSales role
    /// </summary>
    [LookupScript("Administration.InsideSalesUserLookup", Permission = "?")]
    public class InsideSalesUserLookup : RowLookupScript<UserRow>
    {
        public InsideSalesUserLookup(ISqlConnections sqlConnections)
            : base(sqlConnections)
        {
            IdField = UserRow.Fields.UserId.PropertyName;
            TextField = UserRow.Fields.DisplayName.PropertyName;
            Expiration = TimeSpan.FromMinutes(1);
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            var user = Authorization.UserDefinition as UserDefinition;

            if (user != null)
            {
                var ur = UserRoleRow.Fields.As("ur");
                var r = RoleRow.Fields.As("r");

                query
                    .LeftJoin("UserRoles", ur, ur.UserId == UserRow.Fields.UserId)
                    .LeftJoin("Roles", r, r.RoleId == ur.RoleId)
                    .Where(
                        UserRow.Fields.CompanyId == user.CompanyId &
                        UserRow.Fields.IsActive == 1 &
                        (r.RoleName == "InsideSales" | r.RoleName == "SInsideSales" | r.RoleName.Contains("InsideSales"))
                    );
            }
        }

        public override string GetScript()
        {
            var user = Authorization.UserDefinition as UserDefinition;

            if (user == null)
                return string.Empty;

            return LocalCache.GetLocalStoreOnly(
                "InsideSalesUserLookup:" + this.ScriptName + ":" + user.CompanyId,
                TimeSpan.FromMinutes(1),
                new UserRow().GetFields().GenerationKey,
                () => base.GetScript()
            );
        }
    }

    /// <summary>
    /// Lookup for users with InitialProcess role
    /// </summary>
    [LookupScript("Administration.InitialProcessUserLookup", Permission = "?")]
    public class InitialProcessUserLookup : RowLookupScript<UserRow>
    {
        public InitialProcessUserLookup(ISqlConnections sqlConnections)
            : base(sqlConnections)
        {
            IdField = UserRow.Fields.UserId.PropertyName;
            TextField = UserRow.Fields.DisplayName.PropertyName;
            Expiration = TimeSpan.FromMinutes(1);
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            var user = Authorization.UserDefinition as UserDefinition;

            if (user != null)
            {
                var ur = UserRoleRow.Fields.As("ur");
                var r = RoleRow.Fields.As("r");

                query
                    .LeftJoin("UserRoles", ur, ur.UserId == UserRow.Fields.UserId)
                    .LeftJoin("Roles", r, r.RoleId == ur.RoleId)
                    .Where(
                        UserRow.Fields.CompanyId == user.CompanyId &
                        UserRow.Fields.IsActive == 1 &
                        (r.RoleName == "InitialProcess" | r.RoleName == "SInitialProcess" | r.RoleName.Contains("InitialProcess"))
                    );
            }
        }

        public override string GetScript()
        {
            var user = Authorization.UserDefinition as UserDefinition;

            if (user == null)
                return string.Empty;

            return LocalCache.GetLocalStoreOnly(
                "InitialProcessUserLookup:" + this.ScriptName + ":" + user.CompanyId,
                TimeSpan.FromMinutes(1),
                new UserRow().GetFields().GenerationKey,
                () => base.GetScript()
            );
        }
    }

    /// <summary>
    /// Lookup for users with LogInProcess role
    /// </summary>
    [LookupScript("Administration.LogInProcessUserLookup", Permission = "?")]
    public class LogInProcessUserLookup : RowLookupScript<UserRow>
    {
        public LogInProcessUserLookup(ISqlConnections sqlConnections)
            : base(sqlConnections)
        {
            IdField = UserRow.Fields.UserId.PropertyName;
            TextField = UserRow.Fields.DisplayName.PropertyName;
            Expiration = TimeSpan.FromMinutes(1);
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            var user = Authorization.UserDefinition as UserDefinition;

            if (user != null)
            {
                var ur = UserRoleRow.Fields.As("ur");
                var r = RoleRow.Fields.As("r");

                query
                    .LeftJoin("UserRoles", ur, ur.UserId == UserRow.Fields.UserId)
                    .LeftJoin("Roles", r, r.RoleId == ur.RoleId)
                    .Where(
                        UserRow.Fields.CompanyId == user.CompanyId &
                        UserRow.Fields.IsActive == 1 &
                        (r.RoleName == "LogInProcess" | r.RoleName == "SLogInProcess" | r.RoleName.Contains("LoginProcess"))
                    );
            }
        }

        public override string GetScript()
        {
            var user = Authorization.UserDefinition as UserDefinition;

            if (user == null)
                return string.Empty;

            return LocalCache.GetLocalStoreOnly(
                "LogInProcessUserLookup:" + this.ScriptName + ":" + user.CompanyId,
                TimeSpan.FromMinutes(1),
                new UserRow().GetFields().GenerationKey,
                () => base.GetScript()
            );
        }
    }

    /// <summary>
    /// Lookup for users with DisbursementProcess role
    /// </summary>
    [LookupScript("Administration.DisbursementProcessUserLookup", Permission = "?")]
    public class DisbursementProcessUserLookup : RowLookupScript<UserRow>
    {
        public DisbursementProcessUserLookup(ISqlConnections sqlConnections)
            : base(sqlConnections)
        {
            IdField = UserRow.Fields.UserId.PropertyName;
            TextField = UserRow.Fields.DisplayName.PropertyName;
            Expiration = TimeSpan.FromMinutes(1);
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            var user = Authorization.UserDefinition as UserDefinition;

            if (user != null)
            {
                var ur = UserRoleRow.Fields.As("ur");
                var r = RoleRow.Fields.As("r");

                query
                    .LeftJoin("UserRoles", ur, ur.UserId == UserRow.Fields.UserId)
                    .LeftJoin("Roles", r, r.RoleId == ur.RoleId)
                    .Where(
                        UserRow.Fields.CompanyId == user.CompanyId &
                        UserRow.Fields.IsActive == 1 &
                        (r.RoleName == "DisbursementProcess" | r.RoleName == "SDisbursementProcess" | r.RoleName.Contains("DisbursementProcess"))
                    );
            }
        }

        public override string GetScript()
        {
            var user = Authorization.UserDefinition as UserDefinition;

            if (user == null)
                return string.Empty;

            return LocalCache.GetLocalStoreOnly(
                "DisbursementProcessUserLookup:" + this.ScriptName + ":" + user.CompanyId,
                TimeSpan.FromMinutes(1),
                new UserRow().GetFields().GenerationKey,
                () => base.GetScript()
            );
        }
    }
}