using System;
using System.ComponentModel.DataAnnotations;

namespace Nitrogen.Model
{
    /// <summary>
    /// 权限.
    /// </summary>
    public class Permissions
    {
        /// <summary>
        /// Id.
        /// </summary>
        [Key]
        public Guid PermissionId { get; set; }

        /// <summary>
        /// 权限编码.
        /// </summary>
        public string PermissionCode { get; set; }

        /// <summary>
        /// 权限名.
        /// </summary>
        public string PermissionName { get; set; }

        /// <summary>
        /// 类别Id.
        /// </summary>
        public Guid PermissionsCategoryId { get; set; }

        /// <summary>
        /// 所属类别.
        /// </summary>
        public virtual PermissionsCategory PermissionsCategory { get; set; }

        /// <summary>
        /// 创建时间.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 创建人.
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// 最后修改时间.
        /// </summary>
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// 最后修改人.
        /// </summary>
        public string LastUpdateUser { get; set; }
    }
}
