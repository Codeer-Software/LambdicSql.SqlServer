using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SqlServer
{
    //@@@
    public static partial class Symbol
    {
        /// <summary>
        /// CERTENCODED
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/certencoded-transact-sql
        /// </summary>
        /// <param name="cert_id">certificate id</param>
        /// <returns>the public portion of a certificate in binary format.</returns>
        [FuncStyleConverter]
        public static byte[] CertenCoded(int cert_id) => throw new InvalitContextException(nameof(CertenCoded));

        /// <summary>
        /// CERTPRIVATEKEY
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/certprivatekey-transact-sql
        /// </summary>
        /// <param name="cert_id">certificate id.</param>
        /// <param name="password">password.</param>
        /// <returns>the private key of a certificate in binary format. </returns>
        [FuncStyleConverter]
        public static byte[] CertPrivateKey(int cert_id, string password) => throw new InvalitContextException(nameof(CertPrivateKey));

        /// <summary>
        /// CURRENT_USER
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/current-user-transact-sql
        /// </summary>
        /// <returns>user name.</returns>
        [FuncStyleConverter]
        public static string Current_User() => throw new InvalitContextException(nameof(Current_User));

        /// <summary>
        /// HAS_DBACCESS
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/has-dbaccess-transact-sql
        /// </summary>
        /// <param name="database_name">database name</param>
        /// <returns>information about whether the user has access to the specified database.</returns>
        [FuncStyleConverter]
        public static int Has_DbAccess(string database_name) => throw new InvalitContextException(nameof(Has_DbAccess));

        /// <summary>
        /// HAS_PERMS_BY_NAME
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/has-perms-by-name-transact-sql
        /// </summary>
        /// <param name="securable">securable</param>
        /// <param name="securable_class">securable class</param>
        /// <param name="permission">permission</param>
        /// <returns>the effective permission of the current user on a securable.</returns>
        [FuncStyleConverter]
        public static int? Has_Perms_By_Name(string securable, string securable_class , string permission) => throw new InvalitContextException(nameof(Has_Perms_By_Name));

        /// <summary>
        /// IS_MEMBER.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/is-member-transact-sql
        /// </summary>
        /// <param name="groupOrRole">group or role.</param>
        /// <returns>Indicates whether the current user is a member of the specified Microsoft Windows group or SQL Server database role..</returns>
        [FuncStyleConverter]
        public static int Is_Member(string groupOrRole) => throw new InvalitContextException(nameof(Is_Member));

        /// <summary>
        /// IS_ROLEMEMBER
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/is-rolemember-transact-sql
        /// </summary>
        /// <param name="role">database principal</param>
        /// <returns>Indicates whether a specified database principle is a member of the specified database role.</returns>
        [FuncStyleConverter]
        public static int? Is_RoleMenmber(string role) => throw new InvalitContextException(nameof(Is_RoleMenmber));

        /// <summary>
        /// IS_SRVROLEMEMBER
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/is-srvrolemember-transact-sql
        /// </summary>
        /// <param name="role">role</param>
        /// <returns>Indicates whether a SQL Server login is a member of the specified server role.</returns>
        [FuncStyleConverter]
        public static int? Is_SrvroleMember(string role) => throw new InvalitContextException(nameof(Is_SrvroleMember));

        /// <summary>
        /// LOGINPROPERTY
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/loginproperty-transact-sql
        /// </summary>
        /// <param name="login_name">login name.</param>
        /// <param name="property_name">property name.</param>
        /// <returns>Information about login policy settings.</returns>
        [FuncStyleConverter]
        public static int? LoginProperty(string login_name, string property_name) => throw new InvalitContextException(nameof(LoginProperty));

        /// <summary>
        /// ORIGINAL_LOGIN
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/original-login-transact-sql
        /// </summary>
        /// <returns>login name.</returns>
        [FuncStyleConverter]
        public static string Original_Login() => throw new InvalitContextException(nameof(Original_Login));

        /// <summary>
        /// PERMISSIONS
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/permissions-transact-sql
        /// </summary>
        /// <param name="object_id">object id.</param>
        /// <returns>permissions</returns>
        [FuncStyleConverter]
        public static int? Permissions(int? object_id) => throw new InvalitContextException(nameof(Permissions));

        /// <summary>
        /// PWDENCRYPT
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/pwdencrypt-transact-sql
        /// </summary>
        /// <param name="password">password</param>
        /// <returns>the SQL Server password hash of the input value that uses the current version of the password hashing algorithm.</returns>
        [FuncStyleConverter]
        public static byte[] PwdEncrypt(string password) => throw new InvalitContextException(nameof(Permissions));

        /// <summary>
        /// PWDCOMPARE
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/pwdcompare-transact-sql
        /// </summary>
        /// <param name="password">password</param>
        /// <param name="password_hash">password hash</param>
        /// <returns></returns>
        [FuncStyleConverter]
        public static int PwdCompare(string password, byte[] password_hash) => throw new InvalitContextException(nameof(PwdCompare));

        /// <summary>
        /// SESSION_USER
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/session-user-transact-sql
        /// </summary>
        /// <returns>session user</returns>
        [ClauseStyleConverter]
        public static string Session_User() => throw new InvalitContextException(nameof(Session_User));

        /// <summary>
        /// SESSIONPROPERTY
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/sessionproperty-transact-sql
        /// </summary>
        /// <param name="option">option</param>
        /// <returns>session property</returns>
        [FuncStyleConverter]
        public static string SessionProperty(string option) => throw new InvalitContextException(nameof(SessionProperty));

        /// <summary>
        /// SUSER_ID.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/suser-id-transact-sql
        /// </summary>
        /// <param name="login_name">login name.</param>
        /// <returns>server user id.</returns>
        [FuncStyleConverter]
        public static int? SUser_Id(string login_name) => throw new InvalitContextException(nameof(SUser_Id));

        /// <summary>
        /// SUSER_NAME.
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/suser-name-transact-sql
        /// </summary>
        /// <param name="server_user_id">server user id.</param>
        /// <returns>login name.</returns>
        [FuncStyleConverter]
        public static string SUser_Name(int? server_user_id) => throw new InvalitContextException(nameof(SUser_Name));

        /// <summary>
        /// SUSER_SID
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/suser-sid-transact-sql
        /// </summary>
        /// <param name="login_name">login name.</param>
        /// <returns>the security identification number (SID) for the specified login name.</returns>
        [FuncStyleConverter]
        public static byte[] SUser_SId(string login_name) => throw new InvalitContextException(nameof(SUser_SId));

        /// <summary>
        /// SUSER_SID
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/suser-sid-transact-sql
        /// </summary>
        /// <param name="login_name">login name.</param>
        /// <param name="option">option.</param>
        /// <returns>the security identification number (SID) for the specified login name.</returns>
        [FuncStyleConverter]
        public static byte[] SUser_SId(string login_name, int option) => throw new InvalitContextException(nameof(SUser_SId));

        /// <summary>
        /// SUSER_SNAME
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/suser-sname-transact-sql.
        /// </summary>
        /// <param name="server_user_sid">server user sid.</param>
        /// <returns>user name.</returns>
        [FuncStyleConverter]
        public static string SUser_SName(byte[] server_user_sid) => throw new InvalitContextException(nameof(SUser_SName));

        /// <summary>
        /// SYSTEM_USER
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/system-user-transact-sql
        /// </summary>
        /// <returns>system user.</returns>
        [ClauseStyleConverter]
        public static string System_User() => throw new InvalitContextException(nameof(System_User));

        /// <summary>
        /// USER
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/user-transact-sql
        /// </summary>
        /// <returns>user</returns>
        [ClauseStyleConverter]
        public static string User() => throw new InvalitContextException(nameof(User));

        /// <summary>
        /// USER_ID
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/user-id-transact-sql
        /// </summary>
        /// <param name="user">user</param>
        /// <returns>user id.</returns>
        [FuncStyleConverter]
        public static int? User_Id(string user) => throw new InvalitContextException(nameof(User_Id));

        /// <summary>
        /// USER_NAME
        /// https://docs.microsoft.com/en-us/sql/t-sql/functions/user-name-transact-sql
        /// </summary>
        /// <param name="user_id">user id.</param>
        /// <returns>user name.</returns>
        [FuncStyleConverter]
        public static string User_Name(int? user_id) => throw new InvalitContextException(nameof(User_Name));
    }
}
