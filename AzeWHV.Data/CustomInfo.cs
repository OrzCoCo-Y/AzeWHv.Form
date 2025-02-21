using System.ComponentModel.DataAnnotations;

namespace AzeWHV.Data
{
    /// <summary>
    /// 客户信息
    /// </summary>
    public class CustomInfo
    {
        [Key]
        public Guid CustomId { get; set; }

        /// <summary>
        /// 姓【护照】
        /// </summary>
        [Required]
        public string? FamilyName { get; set; }

        /// <summary>
        /// 名【护照
        /// </summary>
        public string? GivenName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string? Sex { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// 护照编码
        /// </summary>
        public string? Passport { get; set; }

        /// <summary>
        /// 护照过期日期
        /// </summary>
        public DateTimeOffset? PassportExpireDate { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public DateTimeOffset? Birthday { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string? IdNumber { get; set; }


        /// <summary>
        /// 身份证开始时间
        /// </summary>
        public DateTimeOffset? IdStart { get; set; }

        /// <summary>
        /// 身份证结束时间
        /// </summary>
        public DateTimeOffset? IdEnd { get; set; }

        /// <summary>
        /// 城市(现居址)
        /// </summary>
        public string? AddressCity { get; set; }

        /// <summary>
        /// 区/县(现居址)
        /// </summary>
        public string? AddressSuburb { get; set; }

        /// <summary>
        /// 街道(现居址)
        /// </summary>
        public string? AddressStreet { get; set; }

        /// <summary>
        /// 是否去过新西兰
        /// </summary>
        public string? BeenToNZ { get; set; }
        /// <summary>
        /// 上次去新西兰的时间
        /// </summary>
        public DateTimeOffset? NzVisitTime { get; set; }


    }
}
