
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2018-04-03 15:16:28
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失
//     作者：Harbour CTS
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DapperTest.Model;
using DapperTest.Data;

namespace DapperTest.Service
{	
	public partial class Table1Service:BaseService<Table1>
    {
        /// 删除一条数据
        /// </summary>
        public bool DeleteByPrimaryKey(int  Id)
        {
               Table1 newClass = new Table1
			   {
			         Id = Id   
			   };   
            return base.Delete(newClass);
        }

    }
}

