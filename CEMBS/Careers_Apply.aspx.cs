﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;

public partial class Careers_Apply: System.Web.UI.Page
{
    //SqlConnection sqlcon;
    //SqlCommand cmd;
    //string name;
    //string designation;
    //string company;
    //string contact;
    //string email;
    //string from;
    //string to;
    //string cc;
    //string message;
    protected void Page_Load(object sender, EventArgs e)
    {
        //name = txt_firstname.Text;
        //designation = txt_phone.Text;
        //email = txt_phone.Text;
        //company = txt_designation.Text;
        //contact = ContactTextBox.Text;
        //email = txt_email.Text;
        //message = txt_skills.Text;
        //from = txt_email.Text;
        //cc = "naresh@cembs.com";
        //to = "naresh@cembs.com";
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        //string con_string = ConfigurationManager.ConnectionStrings["cembs_connectionstring"].ConnectionString;
        //sqlcon = new SqlConnection(con_string);
        //sqlcon.Open();
        //if (IsPostBack)
        //{
        //    try
        //    {
        //        if (sendmail() == true)
        //        {
        //            resultLabel.Text = "mail sent successfully";
        //            cmd = sqlcon.CreateCommand();
        //            cmd.CommandText = "proc_ins_axrequest";
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@Customername", SqlDbType.VarChar).Value = name;
        //            cmd.Parameters.AddWithValue("@Designation", SqlDbType.VarChar).Value = designation;
        //            cmd.Parameters.AddWithValue("@Company", SqlDbType.VarChar).Value = company;
        //            cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = contact;
        //            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
        //            cmd.Parameters.AddWithValue("@Message", SqlDbType.VarChar).Value = message;
        //            cmd.Parameters.AddWithValue("@RequestDate", SqlDbType.DateTime).Value = System.DateTime.Now;
        //            cmd.ExecuteNonQuery();
        //            cmd.Cancel();
        //            cmd.Dispose();
        //        }
        //        else
        //        {
        //            resultLabel.Text = "Mail was not successful";
        //        }
        //        sqlcon.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        resultLabel.Text = ex.ToString();
        //    }
        //}
    }

    #region email

    protected void mail_axrequest(string name, string from, string to, string cc, string designation, string company, string contact, string email, string message)
    {
        //MailMessage mMailMessage = new MailMessage();
        //mMailMessage.From = new MailAddress(from);
        //mMailMessage.To.Add(new MailAddress(to));
        //if ((cc != null) && (cc != string.Empty))
        //{
        //    mMailMessage.CC.Add(new MailAddress(cc));
        //    //mMailMessage.CC.Add(new MailAddress(bcc));
        //}
        //mMailMessage.Subject = "One Comment from " + name;
        //mMailMessage.Body = message;

        //System.Text.StringBuilder builder = new System.Text.StringBuilder();
        //builder.AppendLine("<strong>" + "Name : " + "</strong>" + name + "<br />");
        //builder.AppendLine("<strong>" + "Designation : " + "</strong>" + designation + "<br />");
        //builder.AppendLine("<strong>" + "Company : " + "</strong>" + company + "<br />");
        //builder.AppendLine("<strong>" + "Contact : " + "</strong>" + contact + "<br />");
        //builder.AppendLine("<strong>" + "Email : " + "</strong>" + email + "<br />");
        //mMailMessage.Body = builder.ToString();

        //mMailMessage.IsBodyHtml = true;
        //mMailMessage.Priority = MailPriority.Normal;
        //SmtpClient mSmtpClient = new SmtpClient();
        //mSmtpClient.Send(mMailMessage);
    }

    #endregion

    //protected bool sendmail()
    //{
    //    //try
    //    //{
    //    //    mail_axrequest(name, from, to, cc, designation, company, contact, email, message);
    //    //    return true;
    //    //}
    //    //catch (Exception ex)
    //    //{
    //    //    resultLabel.Text = ex.ToString();
    //    //    return false;
    //    //}
    //}
}