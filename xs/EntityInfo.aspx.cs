using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Entity;
using Newtonsoft.Json;
using Busines;
using Aspose.Words;
using Aspose.Words.Drawing;
using System.IO;

namespace xs
{
    public partial class EntityInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Request.Session[]
        }
        [WebMethod]
        public static string getSelectInfo(string id)
        {
            int code = 1;
            string message = "返回数据成功";
            StudentsUser user = new StudentsUser();
            if (HttpContext.Current.Session["user_"] == null
                && id != "0")
            {
                using (StudentsUserBLL bll = new StudentsUserBLL())
                {
                    user = bll.GetEntity(int.Parse(id));
                }
            }
            else if (HttpContext.Current.Session["user_"] != null) {
                user = HttpContext.Current.Session["user_"] as StudentsUser;
            }
           
            List<Nation> listNation = new List<Nation>();
            List<ZZMM> listZZMM = new List<ZZMM>();
            List<AreaCode_> shiAreaCode = new List<AreaCode_>();
            List<KSLB> listKslb = new List<KSLB>();
            List<BYLB> listBylb = new List<BYLB>();
            List<ZY> listZy = new List<ZY>();
            StudentInfo info = new StudentInfo();
            Wish wish = new Wish();
            if (user != null)
            {


                using (NationBLL bll = new NationBLL())
                {
                    listNation = bll.getListNation();
                }
                using (ZZMMBLL bll = new ZZMMBLL())
                {
                    listZZMM = bll.getZZMMList();
                }
                using (AfficheBLL bll = new AfficheBLL())
                {
                    shiAreaCode = bll.getShiAreaCode();
                }
                using (KSLBBLL bll = new KSLBBLL())
                {
                    listKslb = bll.getListKslb();
                }

                using (BYLBBLL bll = new BYLBBLL())
                {
                    listBylb = bll.getListBylb();
                }
                using (ZYBLL bll = new ZYBLL())
                {
                    listZy = bll.getListZy();
                }
                using (StudentInfoBLL bll = new StudentInfoBLL())
                {
                    info = bll.getEntity(user.Sfzh);
                }
                using (WishBLL bll = new WishBLL())
                {
                    wish = bll.getEntity(user.Sfzh);
                }
            }
            else
            {
                code = 0;
                message = "请登录后在操作";
            }
            string str3 = JsonConvert.SerializeObject(new
            {
                code = code,
                message = message,
                listNation = listNation,
                listZZMM = listZZMM,
                shiAreaCode = shiAreaCode,
                listBylb = listBylb,
                listKslb = listKslb,
                listZy = listZy,
                user = user,
                info = info,
                wish = wish

            });
            return str3;
        }
        [WebMethod]
        public static string getXianByShi(string shiCode)
        {
            int code = 1;
            string message = "返回数据成功";
            List<AreaCode_> listXian = new List<AreaCode_>();
            using (AfficheBLL bll = new AfficheBLL())
            {
                listXian = bll.getXianAreaCodeByShiAreaCode(shiCode);
            }
            return JsonConvert.SerializeObject(new
            {
                code = code,
                message = message,
                listXian = listXian
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SignUpNum"></param>
        /// <param name="Zkzh"></param>
        /// <param name="Sfzh"></param>
        /// <param name="StuName"></param>
        /// <param name="Csrq"></param>
        /// <param name="Xb"></param>
        /// <param name="Mobile"></param>
        /// <param name="Nation"></param>
        /// <param name="Health"></param>
        /// <param name="KSLB"></param>
        /// <param name="AreaCode_Shi"></param>
        /// <param name="AreaCode"></param>
        /// <param name="Byxx"></param>
        /// <param name="BYLB"></param>
        /// <param name="LikeSpecial"></param>
        /// <param name="Tel"></param>
        /// <param name="Yzbm"></param>
        /// <param name="Txdz"></param>
        /// <param name="FrsZY"></param>
        /// <param name="SecZy"></param>
        /// <returns></returns>
        [WebMethod]
        public static string saveInfo(string SignUpNum, string Zkzh, string Sfzh, string StuName,
            string Csrq, string Xb, string Mobile, string Nation, string ZZMM, int Health,
            string KSLB, string AreaCode_Shi, string AreaCode, string Byxx, string BYLB, string LikeSpecial,
            string Tel, string Yzbm, string Txdz, string FrsZY, string SecZy, int IsAdjust, string AcceptPeople)
        {
            String strCsrq = Sfzh.Substring(6, 4) + "-" + Sfzh.Substring(10, 2) + "-" + Sfzh.Substring(12, 2);
            int _XB = 0;
            if (int.Parse(Sfzh.Substring(14, 3)) % 2 != 0)
            {
                _XB = 1;
            }
            int code = 1;
            string message = "保存成功";
            try
            {
                StudentInfo _setInfo = new StudentInfo();
                _setInfo.AcceptPeople = AcceptPeople;
                _setInfo.AreaCode = AreaCode;
                _setInfo.BYLB = BYLB;
                _setInfo.Byyx = Byxx;
                _setInfo.Csrq = DateTime.Parse(strCsrq);
                _setInfo.Health = Health;
                _setInfo.KSLB = KSLB;
                _setInfo.LikeSpecial = LikeSpecial;
                _setInfo.Mobile = Mobile;
                _setInfo.Nation = Nation;
                //_setInfo.PicPath
                _setInfo.Sfzh = Sfzh;
                _setInfo.Tel = Tel;
                _setInfo.Txdz = Txdz;
                _setInfo.Xb = _XB;
                _setInfo.Yzbm = Yzbm;
                _setInfo.ZZMM = ZZMM;
                using (StudentInfoBLL bll = new StudentInfoBLL())
                {
                    if (bll.getEntity(Sfzh) == null)
                    {
                        bll.Insert(_setInfo);
                    }
                    else
                    {
                        bll.Update(_setInfo);
                    }
                }
                Wish _wish = new Wish();
                _wish.Sfzh = Sfzh;
                _wish.IsAdjust = IsAdjust;
                _wish.FrsZY = FrsZY;
                _wish.SecZY = SecZy;
                using (WishBLL bll = new WishBLL())
                {
                    if (bll.getEntity(Sfzh) == null)
                    {
                        bll.Insert(_wish);
                    }
                    else
                    {
                        bll.Update(_wish);
                    }
                }
            }
            catch (Exception)
            {
                code = 0;
                message = "数据合法性错误";

            }

            return JsonConvert.SerializeObject(new { code = code, message = message });
        }
        [WebMethod]
        public static string pointInfo()
        {
            int code = 1;
            string message = "打印成功";
            StudentsUser user = HttpContext.Current.Session["user_"] as StudentsUser;
            List<Nation> listNation = new List<Nation>();
            List<ZZMM> listZZMM = new List<ZZMM>();
            List<AreaCode_> shiAreaCode = new List<AreaCode_>();
            List<KSLB> listKslb = new List<KSLB>();
            List<BYLB> listBylb = new List<BYLB>();
            List<ZY> listZy = new List<ZY>();
            StudentInfo stuInfo = new StudentInfo();
            Wish wish = new Wish();
            Nation nation_ = new Nation();
            AreaCode_ areaCode, areaShiCode = new AreaCode_();
            if (user != null)
            {


                using (NationBLL bll = new NationBLL())
                {
                    listNation = bll.getListNation();
                }
                using (ZZMMBLL bll = new ZZMMBLL())
                {
                    listZZMM = bll.getZZMMList();
                }
                using (AfficheBLL bll = new AfficheBLL())
                {
                    shiAreaCode = bll.getShiAreaCode();
                }
                using (KSLBBLL bll = new KSLBBLL())
                {
                    listKslb = bll.getListKslb();
                }

                using (BYLBBLL bll = new BYLBBLL())
                {
                    listBylb = bll.getListBylb();
                }
                using (ZYBLL bll = new ZYBLL())
                {
                    listZy = bll.getListZy();
                }
                using (StudentInfoBLL bll = new StudentInfoBLL())
                {
                    stuInfo = bll.getEntity(user.Sfzh);
                    //if (stuInfo.PicPath.Trim().Length != null)
                    //{
                    //    HttpContext.Current.Session["PicPath_"] =stuInfo.PicPath;
                    //}
                }
                using (WishBLL bll = new WishBLL())
                {
                    wish = bll.getEntity(user.Sfzh);
                }
                Document doc = new Document(System.Web.HttpContext.Current.Server.MapPath("~/uploads") + "//templet.doc");
                foreach (Bookmark item in doc.Range.Bookmarks)
                {
                    if (item != null)
                    {
                        switch (item.Name)
                        {
                            case "SignUpNum":
                                item.Text = user.SignUpNum;
                                break;
                            case "Sfzh_1":
                            case "Sfzh_2":
                            case "Sfzh_3":
                            case "Sfzh_4":
                            case "Sfzh_5":
                            case "Sfzh_6":
                            case "Sfzh_7":
                            case "Sfzh_8":
                            case "Sfzh_9":
                            case "Sfzh_10":
                            case "Sfzh_11":
                            case "Sfzh_12":
                            case "Sfzh_13":
                            case "Sfzh_14":
                            case "Sfzh_15":
                            case "Sfzh_16":
                            case "Sfzh_17":
                            case "Sfzh_18":
                                item.Text = user.Sfzh.Substring(int.Parse(item.Name.Substring(5))-1, 1);
                                break;
                            case "Zkzh_1":                            
                            case "Zkzh_2":
                            case "Zkzh_3":
                            case "Zkzh_4":
                            case "Zkzh_5":
                            case "Zkzh_6":
                            case "Zkzh_7":
                            case "Zkzh_8":
                            case "Zkzh_9":
                            case "Zkzh_10":
                            case "Zkzh_11":
                            case "Zkzh_12":
                            case "Zkzh_13":
                            case "Zkzh_14":
                                item.Text = user.Zkzh.Substring(int.Parse(item.Name.Substring(5))-1, 1);
                                break;
                            case "PicPath":
                                DocumentBuilder builder = new DocumentBuilder(doc);
                                string imgPath = System.Web.HttpContext.Current.Server.MapPath("~/uploads") + "\\" + user.Sfzh + ".jpg";
                                if (File.Exists(imgPath))
                                {
                                    builder.MoveToBookmark("PicPath");
                                    builder.InsertImage(imgPath, RelativeHorizontalPosition.Margin, 1, RelativeVerticalPosition.Margin, 1, 80, 100, WrapType.Square);
                                }
                                break;
                            case "StuName":
                                item.Text = user.StuName;
                                break;
                            ///Tel
                            case "Tel":
                                item.Text = stuInfo.Tel;
                                break;
                            ///Txdz
                            case "Txdz":
                                item.Text = stuInfo.Txdz;
                                break;
                            ///Xb
                            case "Xb":
                                item.Text = (stuInfo.Xb == 0 ? "女" : "男");
                                break;
                            ///Yzbm
                            case "Yzbm":
                                item.Text = stuInfo.Yzbm;
                                break;
                            ///AcceptPeople
                            case "AcceptPeople":
                                item.Text = stuInfo.AcceptPeople;
                                break;
                            ///Byyx
                            case "Byyx":
                                item.Text = stuInfo.Byyx;
                                break;
                            ///Csrq
                            case "Csrq":
                                item.Text = stuInfo.Csrq.ToString("yyyy-MM-dd");
                                break;
                            ///Health
                            case "Health":
                                if (stuInfo.Health == 0) { item.Text = "好"; }
                                else if (stuInfo.Health == 1) { item.Text = "一般"; }
                                else if (stuInfo.Health == 2) { item.Text = "比较好"; }
                                else if (stuInfo.Health == 3) { item.Text = "差"; }
                                break;
                            ///IsAdjust
                            case "IsAdjust":
                                item.Text = (wish.IsAdjust == 0 ? "否" : "是");
                                break;
                            ///LikeSpecial
                            case "LikeSpecial":
                                item.Text = stuInfo.LikeSpecial;
                                break;
                            ///Mobile
                            case "Mobile":
                                item.Text = stuInfo.Mobile;
                                break;

                            ///Nation
                            case "Nation":
                                using (NationBLL bll = new NationBLL())
                                {
                                    nation_ = bll.getNationName(stuInfo.Nation);
                                }
                                item.Text = nation_.NationName.ToString();
                                break;
                            ///AreaCode
                            case "AreaCode":
                                using (AreaCodeBLL bll = new AreaCodeBLL())
                                {
                                    areaCode = bll.getAreaName(stuInfo.AreaCode.Substring(0, 4));
                                    areaShiCode = bll.getAreaName(stuInfo.AreaCode);
                                }
                                item.Text = areaCode.AreaName.ToString() + areaShiCode.AreaName.ToString();
                                break;
                            ///ZZMM
                            case "ZZMM":
                                //var answerZzmm = (from p in listZZMM
                                //                  where p.ZzmmDm == stuInfo.ZZMM
                                //                  select p).Single();

                                using (ZZMMBLL bll = new ZZMMBLL())
                                {
                                    item.Text = bll.getZZMMByZzmmDm(stuInfo.ZZMM).ZzmmMc;
                                }

                                break;
                            ///BYLB
                            case "BYLB":
                                var answerBylb = (from p in listBylb
                                                  where p.BylbDm == stuInfo.BYLB
                                                  select p).Single();
                                item.Text = answerBylb.BylbMc.ToString();
                                break;
                            ///KSLB
                            case "KSLB":
                                var answerKslb = (from p in listKslb
                                                  where p.KslbDm == stuInfo.KSLB
                                                  select p).Single();
                                item.Text = answerKslb.KslbMc.ToString();
                                break;
                            case "FrsZY":
                                var answerFrszy = (from p in listZy
                                                   where p.ZYDM == wish.FrsZY.Trim()
                                                   select p);
                                string stringFrsZY = string.Empty;
                                foreach (var item1 in answerFrszy)
                                {
                                    stringFrsZY = item1.ZYMC;
                                }

                                item.Text = stringFrsZY.ToString();
                                break;
                            ///SecZY
                            case "SecZY":
                                var answerSeczy = (from pp in listZy
                                                   where pp.ZYDM == wish.SecZY.Trim()
                                                   select pp);
                                string stringSecZY = string.Empty;
                                foreach (var item2 in answerSeczy)
                                {
                                    stringSecZY = item2.ZYMC;
                                }
                                item.Text = stringSecZY.ToString();
                                break;
                        }
                    }
                }

               doc.Save("d:\\abc.pdf",SaveFormat.Pdf);
            }

            return JsonConvert.SerializeObject(new { code = code, message = message });
        }
    }
}
