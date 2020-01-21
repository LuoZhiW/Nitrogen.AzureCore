using System;
using System.ComponentModel.DataAnnotations;

namespace Nitrogen.Model
{
    /// <summary>
    /// 权限分类.
    /// </summary>
    public class PermissionsCategory
    {
        /// <summary>
        /// 权限类别Id.
        /// </summary>
        [Key]
        public Guid PermissionsCategoryId { get; set; }

        /// <summary>
        /// 权限类别名. // 菜单 按钮  
        /// </summary>
        public string PermissionsCategoryName { get; set; }

        /// <summary>
        /// 权限类别编码.
        /// </summary>
        public string PermissionCategoryCode { get; set; }


    }
}
