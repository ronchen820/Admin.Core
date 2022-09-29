﻿using System.ComponentModel.DataAnnotations;
using ZhonTai.Admin.Domain.User;

namespace ZhonTai.Admin.Services.User.Dto;

/// <summary>
/// 添加
/// </summary>
public class UserAddInput
{
    /// <summary>
    /// 账号
    /// </summary>
    [Required(ErrorMessage = "请输入账号")]
    public string UserName { get; set; }

    /// <summary>
    /// 密码
    /// </summary>
    [Required(ErrorMessage = "请输入密码")]
    public string Password { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    [Required(ErrorMessage = "请输入姓名")]
    public string Name { get; set; }

    /// <summary>
    /// 手机号
    /// </summary>
    public string Mobile { get; set; }

    /// <summary>
    /// 邮箱
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// 角色
    /// </summary>
    public long[] RoleIds { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public UserStatusEnum Status { get; set; }

    /// <summary>
    /// 员工
    /// </summary>
    public StaffAddInput Staff { get; set; }
}