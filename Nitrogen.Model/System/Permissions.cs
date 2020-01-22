using System;
using System.ComponentModel.DataAnnotations;

namespace Nitrogen.Model
{
    /// <summary>
    /// 权限.
    /// </summary>
    public class Permissions : BaseTree
    {
        /// <summary>
        /// Id.
        /// </summary>
        [Key]
        public Guid PermissionId { get; set; }

        /// <summary>
        /// 权限编码.
        /// </summary>
        [MaxLength(30)]
        public string PermissionCode { get; set; }

        /// <summary>
        /// 权限名.
        /// </summary>
        [MaxLength(30)]
        public string PermissionName { get; set; }

        [MaxLength(30)]
        public string Icon { get; set; }

        [MaxLength(150)]
        public string UrlAddress { get; set; }

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
        [MaxLength(50)]
        public string CreateUser { get; set; }

        /// <summary>
        /// 最后修改时间.
        /// </summary>
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// 最后修改人.
        /// </summary>
        [MaxLength(50)]
        public string LastUpdateUser { get; set; }

        /// <summary>
        /// 排序编码.
        /// </summary>
        public int SortCode { get; set; }

        /// <summary>
        /// 有效标记.
        /// </summary>
        public bool EnabledMark { get; set; }

        /// <summary>
        /// 删除标记.
        /// </summary>
        public bool DeleteMark { get; set; }
    }
}
