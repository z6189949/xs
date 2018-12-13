using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Entity;
using Busines;
using PetaPoco;
using Newtonsoft.Json;
using MyXls.SL2;
using org.in2bits.MyXls;

namespace xs.ht
{
    public partial class ShowStuInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static string getStudentInfoPage(int pageIndex, int pageSize)
        {
            int code = 1;
            string message = "success";
            Page<StudentsUser> stuInfoPage = new Page<StudentsUser>();
            using (StudentsUserBLL bll = new StudentsUserBLL())
            {
                stuInfoPage = bll.getStuUserPage(pageIndex, pageSize);
            }
            return JsonConvert.SerializeObject(
                new { code = code, message = message, stuInfoPage = stuInfoPage });
        }
        [WebMethod]
        public static string getAllDataToExcel()
        {
            int code = 1;
            string message = "success";
            List<StudentsUser> listUser = new List<StudentsUser>();
            using (StudentsUserBLL bll = new StudentsUserBLL())
            {
                listUser = bll.getStudentUser();
            }
            XlsDocument xls = new XlsDocument();

            if (listUser.Count != 0)
            {
                xls.FileName = DateTime.Now.ToString("u").Replace(":", "_").Replace(" ", "_") + ".xls";
                Worksheet sheet = xls.Workbook.Worksheets.Add("考生数据");
                Cells cells = sheet.Cells;
                cells.Add(1, 1, "身份证号");
                cells.Add(1, 2, "姓名");
                cells.Add(1, 3, "准考证");
                cells.Add(1, 4, "手机号");
                for (int i = 1; i <= listUser.Count; i++)
                {
                    cells.Add(i + 1, 1, listUser[i - 1].Sfzh);
                    cells.Add(i + 1, 2, listUser[i - 1].StuName);
                    cells.Add(i + 1, 3, listUser[i - 1].Zkzh);
                    cells.Add(i + 1, 4, listUser[i - 1].Mobile);
                }
                xls.Save(HttpContext.Current.Server.MapPath("~/uploads") + "//");
            }
            return JsonConvert.SerializeObject(
                new { code = code, message = message, filePath = "uploads/" + xls.FileName });
        }
        [WebMethod]
        public static string getAllStu()
        {
            int code = 1;
            string message = "success";
 
            List<StuAllInfo> listUser = new List<StuAllInfo>();
            using (StuAllInfoBLL bll = new StuAllInfoBLL())
            {
                listUser = bll.getStuAllInfo();
            }
            XlsDocument xls = new XlsDocument();

            if (listUser.Count != 0)
            {
                xls.FileName = DateTime.Now.ToString("u").Replace(":", "_").Replace(" ", "_") + ".xls";
                Worksheet sheet = xls.Workbook.Worksheets.Add("考生数据");
                Cells cells = sheet.Cells;
                cells.Add(1, 1, "身份证号");
                cells.Add(1, 2, "姓名");
                cells.Add(1, 3, "准考证");
                cells.Add(1, 4, "性别");
                cells.Add(1, 5, "手机号");
                cells.Add(1, 6, "第一志愿");
                cells.Add(1, 7, "第二志愿");
                for (int i = 1; i <= listUser.Count; i++)
                {
                    cells.Add(i + 1, 1, listUser[i - 1].Sfzh);
                    cells.Add(i + 1, 2, listUser[i - 1].StuName);
                    cells.Add(i + 1, 3, listUser[i - 1].Zkzh);
                    cells.Add(i + 1, 4, listUser[i - 1].Xb == 1 ? "男" : "女");
                    cells.Add(i + 1, 5, listUser[i - 1].Mobile);
                    if (listUser[i - 1].FrsZY != null)
                    {
                        cells.Add(i + 1, 6, getZymcByZybh(listUser[i - 1].FrsZY));

                    }
                    if (listUser[i - 1].SecZY != null)
                    {
                        if (listUser[i - 1].SecZY.Trim().Length != 0)
                        {
                            cells.Add(i + 1, 7, getZymcByZybh(listUser[i - 1].SecZY));
                        }
                    }
                }
                xls.Save(HttpContext.Current.Server.MapPath("~/uploads") + "//");
            }
            return JsonConvert.SerializeObject(
                new { code = code, message = message, filePath = "uploads/" + xls.FileName });
        }
        private static string getZymcByZybh(String zybh)
        {
            string zymc = string.Empty;
            using (ZYBLL bll = new ZYBLL())
            {
                zymc = bll.getZymcByZydm(zybh);
            }
            return zymc;
        }
    }
}