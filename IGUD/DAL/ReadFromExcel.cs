//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net;
//using System.Web.Http;
//using System.Data;
//using System.IO;
//using System.Web;
//using ExcelDataReader;
//using DAL.ReadFromExcelDAL.models;
using ExcelDataReader;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;


namespace DAL
{
   public class ReadFromExcelDAL
    {
    //    public string ExcelUpload()
    //    {
    //        string message = "";
    //        HttpResponseMessage result = null;
    //        var httpRequest = HttpContext.Current.Request;
    //        using (IgudDBEntities objEntity = new IgudDBEntities())
    //        {

    //            if (httpRequest.Files.Count > 0)
    //            {
    //                HttpPostedFile file = httpRequest.Files[0];
    //                Stream stream = file.InputStream;

    //                IExcelDataReader reader = null;

    //                if (file.FileName.EndsWith(".xls"))
    //                {
    //                    reader = ExcelReaderFactory.CreateBinaryReader(stream);
    //                }
    //                else if (file.FileName.EndsWith(".xlsx"))
    //                {
    //                    reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
    //                }
    //                else
    //                {
    //                    message = "This file format is not supported";
    //                }

    //                DataSet excelRecords = reader.AsDataSet();
    //                reader.Close();

    //                var finalRecords = excelRecords.Tables[0];
    //                for (int i = 0; i < finalRecords.Rows.Count; i++)
    //                {
    //                    User objUser = new User();
    //                    objUser.UserName = finalRecords.Rows[i][0].ToString();
    //                    objUser.EmailId = finalRecords.Rows[i][1].ToString();
    //                    objUser.Gender = finalRecords.Rows[i][2].ToString();
    //                    objUser.Address = finalRecords.Rows[i][3].ToString();
    //                    objUser.MobileNo = finalRecords.Rows[i][4].ToString();
    //                    objUser.PinCode = finalRecords.Rows[i][5].ToString();

    //                    objEntity.Users.Add(objUser);

    //                }

    //                int output = objEntity.SaveChanges();
    //                if (output > 0)
    //                {
    //                    message = "Excel file has been successfully uploaded";
    //                }
    //                else
    //                {
    //                    message = "Excel file uploaded has fiald";
    //                }

    //            }

    //            else
    //            {
    //                result = Request.CreateResponse(HttpStatusCode.BadRequest);
    //            }
    //        }
    //        return message;
    //    }
    //    public List<User> BindUser()
    //    {
    //        List<User> lstUser = new List<User>();
    //        using (IgudDBEntities objEntity = new IgudDBEntities())
    //        {
    //            lstUser = objEntity.Users.ToList();
    //        }
    //        return lstUser;
    //    }
    }
}
