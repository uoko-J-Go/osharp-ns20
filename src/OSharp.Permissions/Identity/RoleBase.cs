﻿// -----------------------------------------------------------------------
//  <copyright file="RoleBase.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-09-04 19:33</last-date>
// -----------------------------------------------------------------------

using System;
using System.ComponentModel.DataAnnotations;

using OSharp.Entity;


namespace OSharp.Identity
{
    /// <summary>
    /// 角色信息基类
    /// </summary>
    /// <typeparam name="TRoleKey">角色编号类型</typeparam>
    public abstract class RoleBase<TRoleKey> : EntityBase<TRoleKey>, ICreatedTime, ILockable
        where TRoleKey : IEquatable<TRoleKey>
    {
        /// <summary>
        /// 获取或设置 角色名称
        /// </summary>
        [Required, StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 标准化角色名称
        /// </summary>
        public string NormalizedName { get; set; }

        /// <summary>
        /// 获取或设置 一个随机值，每当某个角色被保存到存储区时，该值将发生变化。
        /// </summary>
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// 获取或设置 角色描述
        /// </summary>
        [StringLength(500)]
        public string Remark { get; set; }

        /// <summary>
        /// 获取或设置 是否管理员角色
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// 获取或设置 是否默认角色，用户注册后拥有此角色
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// 获取或设置 是否系统角色
        /// </summary>
        public bool IsSystem { get; set; }

        /// <summary>
        /// 获取或设置 是否锁定
        /// </summary>
        public bool IsLocked { get; set; }

        /// <summary>
        /// 获取设置 信息创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}