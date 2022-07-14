#nullable disable

namespace DataAccess.DataAccess
{
    public partial class AccountDb
    {
        public string UserId { get; set; }
        public string AccountPassword { get; set; }
        public string AccountFullName { get; set; }
        public int? AccountRole { get; set; }
    }
}
