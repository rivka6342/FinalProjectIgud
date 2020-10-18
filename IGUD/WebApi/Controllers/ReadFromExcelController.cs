using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.IO;
using System.Web;
using System.Data.Entity;
//using WebApi.Models;
using ExcelDataReader;
using DAL;

namespace WebApi.Controllers
{
    [RoutePrefix("Api/Excel")]
    public class ReadFromExcelController : ApiController
    {
            [Route("UploadExcel")]
            [HttpPost]
            public string ExcelUpload()
            {
                string message = "";
                HttpResponseMessage result = null;
                var httpRequest = HttpContext.Current.Request;
                using (IgudDBEntities objEntity = new IgudDBEntities())
                {

                    if (httpRequest.Files.Count > 0)
                    {
                        HttpPostedFile file = httpRequest.Files[0];
                        Stream stream = file.InputStream;

                        IExcelDataReader reader = null;

                        if (file.FileName.EndsWith(".xls"))
                        {
                            reader = ExcelReaderFactory.CreateBinaryReader(stream);
                        }
                        else if (file.FileName.EndsWith(".xlsx"))
                        {
                            reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                        }
                        else
                        {
                            message = "This file format is not supported";
                        }

                        DataSet excelRecords = reader.AsDataSet();
                        reader.Close();

                        var finalRecords = excelRecords.Tables[0];
                        for (int i = 0; i < finalRecords.Rows.Count; i++)
                        {
                            User objUser = new User();
                            objUser.UserId = finalRecords.Rows[i][0].ToString();
                            objUser.FirstName = finalRecords.Rows[i][1].ToString();
                            objUser.LastName = finalRecords.Rows[i][2].ToString();
                            objUser.Email = finalRecords.Rows[i][3].ToString();
                            objUser.CommunityId= Convert.ToInt32(finalRecords.Rows[i][4].ToString());
                            objUser.UserType = Convert.ToInt32(finalRecords.Rows[i][5].ToString());
                            objUser.BirthDate = Convert.ToDateTime(finalRecords.Rows[i][6].ToString());
                            objUser.Street = finalRecords.Rows[i][7].ToString();
                            objUser.HouseNumber = Convert.ToInt32(finalRecords.Rows[i][8].ToString());
                            objUser.Phone = finalRecords.Rows[i][9].ToString();
                            objUser.Sector = finalRecords.Rows[i][10].ToString();

                        objEntity.Users.Add(objUser);

                        }

                        int output = objEntity.SaveChanges();
                        if (output > 0)
                        {
                            message = "Excel file has been successfully uploaded";
                        }
                        else
                        {
                            message = "Excel file uploaded has fiald";
                        }

                    }

                    else
                    {
                        result = Request.CreateResponse(HttpStatusCode.BadRequest);
                    }
                }
                return message;
            }

            [Route("UserDetails")]
            [HttpGet]
        public List<User> BindUser()
        {
            List<User> lstUser = new List<User>();
            using (IgudDBEntities objEntity = new IgudDBEntities())
            {
                lstUser = objEntity.Users.ToList();
            }
            return lstUser;
        }
    }
    }
