﻿using Digitala.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Digitala.Models
{
    public class Teachers
    {
        int teacherID;
        string teacherFname;
        string teacherSurName;
        string teacherEmail;
        string teacherPassword;
        DateTime teacherAlert;
        bool teacherAdmin;
  
        public Teachers(){}

        public Teachers(int teacherID, string teacherFname, string teacherSurName, string teacherEmail, string teacherPassword, DateTime teacherAlert, bool teacherAdmin)
        {
            TeacherID = teacherID;
            TeacherFname = teacherFname;
            TeacherSurName = teacherSurName;
            TeacherEmail = teacherEmail;
            TeacherPassword = teacherPassword;
            TeacherAlert = teacherAlert;
            TeacherAdmin = teacherAdmin;
        }

        public int TeacherID { get => teacherID; set => teacherID = value; }
        public string TeacherFname { get => teacherFname; set => teacherFname = value; }
        public string TeacherSurName { get => teacherSurName; set => teacherSurName = value; }
        public string TeacherEmail { get => teacherEmail; set => teacherEmail = value; }
        public string TeacherPassword { get => teacherPassword; set => teacherPassword = value; }
        public DateTime TeacherAlert { get => teacherAlert; set => teacherAlert = value; }
        public bool TeacherAdmin { get => teacherAdmin; set => teacherAdmin = value; }

        public void Insert()
        {
            DBServices dbs = new DBServices();
            dbs.Insert(this);
        }
    }
}