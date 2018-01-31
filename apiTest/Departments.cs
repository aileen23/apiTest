﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    /// <summary>
    /// 부서 정보
    /// </summary>
    public class Departments
    {
        /// <summary>
        /// 엔트리 타입 0: 부서, 1: 그룹, 2:사용자
        /// </summary>
        public int EntryType { get; set; }

        /// <summary>
        /// 부서코드
        /// </summary>
        public string DeptCode { get; set; }

        /// <summary>
        /// 부서이름
        /// </summary>
        public string DeptName { get; set; }

        /// <summary>
        /// AD DisplayName
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Leaf여부
        /// </summary>
        public bool IsLeaf { get; set; }

        /// <summary>
        /// 하위부서의 유무
        /// </summary>
        public bool HasSubDept { get; set; }

        /// <summary>
        /// 이메일주소
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 회사 코드
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// 회사명
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 부서 경로
        /// </summary>
        public string DeptPath { get; set; }

        /// <summary>
        /// 자식부서의 정보
        /// </summary>
        public List<Departments> ChildDept { get; } = new List<Departments>();

        /// <summary>
        /// 
        /// </summary>
        public bool DisableDND { get; set; }

        public override string ToString()
        {
            return "DeptCode : " + DeptCode + "DeptName : " + DeptName + "CompanyCode : " + CompanyCode + "CompanyName : " + CompanyName;
        }
    }
}
