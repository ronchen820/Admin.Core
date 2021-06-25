﻿using Admin.Core.Common.Input;
using Admin.Core.Common.Output;
using Admin.Core.Service.Personnel.Employee;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Admin.Core.Model.Personnel;
using Admin.Core.Service.Personnel.Employee.Input;

namespace Admin.Core.Controllers.Personnel
{
    /// <summary>
    /// 员工管理
    /// </summary>
    public class EmployeeController : AreaController
    {
        private readonly IEmployeeService _employeeServices;

        public EmployeeController(
            IEmployeeService employeeServices
        )
        {
            _employeeServices = employeeServices;
        }

        /// <summary>
        /// 查询单条用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IResponseOutput> Get(long id)
        {
            return await _employeeServices.GetAsync(id);
        }

        /// <summary>
        /// 查询分页用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        //[ResponseCache(Duration = 60)]
        public async Task<IResponseOutput> GetPage(PageInput<EmployeeEntity> input)
        {
            return await _employeeServices.PageAsync(input);
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IResponseOutput> Add(EmployeeAddInput input)
        {
            return await _employeeServices.AddAsync(input);
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IResponseOutput> Update(EmployeeUpdateInput input)
        {
            return await _employeeServices.UpdateAsync(input);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IResponseOutput> SoftDelete(long id)
        {
            return await _employeeServices.SoftDeleteAsync(id);
        }

        /// <summary>
        /// 批量删除用户
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IResponseOutput> BatchSoftDelete(long[] ids)
        {
            return await _employeeServices.BatchSoftDeleteAsync(ids);
        }
    }
}