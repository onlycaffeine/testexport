using testexportfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testexportfile.EF;

namespace testexportfile.Dao
{
    public class EmployeeInfoDao
    {
        MVCTutorialEntities db = null;
        public EmployeeInfoDao()
        {
            db = new MVCTutorialEntities();
        }

        public List<EmployeeInfo> ListAll()
        {
            return db.EmployeeInfoes.Where(x => x.EmployeeName != "").OrderBy(x => x.EmployeeId).ToList();
        }

        public IEnumerable<EmployeeInfo> ListAll1()
        {
            List<EmployeeInfo> listLinks = new List<EmployeeInfo>();
            var model = from l in db.EmployeeInfoes // lấy toàn bộ sp
                        select new
                        {
                            l.EmployeeId,
                            l.EmployeeName,
                            l.Email,
                            l.Phone,
                            l.Exprience
                        };

            foreach (var item in model)
            {
                EmployeeInfo temp = new EmployeeInfo();
                temp.EmployeeId = item.EmployeeId;
                temp.EmployeeName = item.EmployeeName;
                temp.Email = item.Email;
                temp.Phone = item.Phone;
                temp.Exprience = item.Exprience;
                listLinks.Add(temp);
            }

            return listLinks.OrderBy(x => x.EmployeeId);
        }
    }
}