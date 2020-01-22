using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nitrogen.Model
{
    /// <summary>
    /// 树形模型.
    /// </summary>
    public class BaseTree
    {
        /// <summary>
        /// 所属节点ID.
        /// </summary>
        [MaxLength(50)]
        public string ParentId { get; set; }

        /// <summary>
        /// 节点左标识.
        /// </summary>
        public int Left { get; set; }

        /// <summary>
        /// 节点右标识。
        /// </summary>
        public int Right { get; set; }

        /// <summary>
        /// 节点深度.
        /// </summary>
        public int Depth { get; set; }

        /// <summary>
        /// 是否叶子节点.
        /// </summary>
        public bool IsLeaf { get; set; }

        /// <summary>
        /// 是否展开的节点.
        /// </summary>
        public bool Expanded { get; set; }
    }
}
