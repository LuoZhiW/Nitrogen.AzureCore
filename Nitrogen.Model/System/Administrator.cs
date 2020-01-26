using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nitrogen.Model
{
    /// <summary>
    /// 管理员.
    /// </summary>
    public class Administrator
    {

        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// 用户名.
        /// </summary>
        [StringLength(40)]
        public string UserName { get; set; }

        /// <summary>
        /// NormalizedUserName.
        /// </summary>
        [StringLength(40)]
        public string NormalizedUserName { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        [StringLength(40)]
        public string Email { get; set; }

        /// <summary>
        /// NormalizedEmail.
        /// </summary>
        [StringLength(40)]
        public string NormalizedEmail { get; set; }

        /// <summary>
        /// 邮箱确认.
        /// </summary>
        public bool EmailConfirmed { get; set; }


        /// <summary>
        /// 密码加密hash.
        /// </summary>
        public string PasswordHash { get; set; }


        /// <summary>
        /// SecurityStamp.
        /// </summary>
        public string SecurityStamp { get; set; }

        /// <summary>
        /// ConcurrencyStamp.
        /// </summary>
        public string ConcurrencyStamp { get; set; }

        /// <summary>
        /// PhoneNumber.
        /// </summary>
        [StringLength(30)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// PhoneNumberConfirmed
        /// </summary>
        public bool PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// TwoFactorEnabled.
        /// </summary>
        public bool TwoFactorEnabled { get; set; }
        /// <summary>
        /// LockoutEnd.锁定时间
        /// </summary>
        public DateTime LockoutEnd { get; set; }

        /// <summary>
        /// LockoutEnabled.
        /// </summary>
        public bool LockoutEnabled { get; set; }


        /// <summary>
        /// 登录失败次数.
        /// </summary>
        public int AccessFailedCount { get; set; }
    }
}
