using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlzMON.Models
    {
    
    public class ApplicationUser : IdentityUser
    {
        // public int InitializerlsId { get; set; }
        // public Initializers Initializer { get; set; }
    }

    // Кандидаты
    public class Initializers
    {
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "Фамилия обязательно")]

        public string PersonSurname { get; set; }

        //[Required(ErrorMessage = "Имя обязательно")]
        public string PersonName { get; set; }

        //public int Pin { get; set; }
        public string PersonPatronymic { get; set; }

        public string GetFullName { get { return PersonSurname + " " + PersonName + " " + PersonPatronymic; } }

        public int PossitionsId { get; set; }

        public Possitions Possition { get; set; }

        public int EducationsId { get; set; }

        public Educations Education { get; set; }

        public string WorkExpierence { get; set; }

        public int AreassId { get; set; }
        public Areass Areak { get; set; }

        public int RegionsId { get; set; }
        public Regions Region { get; set; }

        // public int DocumentsId { get; set; }
        //  public Documents Documents { get; set; }
        public DateTime DateOfBirth { get; set; }

        //[Required(ErrorMessage = "Телефон обязателен")]
        public string CellPhone { get; set; }

        // [Required(ErrorMessage = "Адресс почты обязателен")]
        public string EmailAddress { get; set; }

        //  [Required(ErrorMessage = "Адресс обязателен")]
        public string PersonAddress { get; set; }

        // files names
        public string FilesNamesZayavleniye { get; set; } = "";
        public string FilesNamesPredstavleniye { get; set; } = "";
        public string FilesNamesTrudovaya { get; set; } = "";
        public string FilesNamesNagrady { get; set; } = "";
        public string FilesNamesVypyska { get; set; } = "";


        // Награда
        public int AwardsId { get; set; }
        public Awards Award { get; set; }

        // Приказ
        public int OrderId { get; set; }
        public Orders Orders { get; set; }
    }


    // Приказы
    public class Orders
    {
        //[Required(ErrorMessage = "Поле обязательно")]
        public int Id { get; set; }
        public string OrderName { get; set; }
        public int OrderCode { get; set; }
        public DateTime OrderDate { get; set; }

        // Список кандидатов
        public List<Initializers> InitiList { get; set; }
    }

    // Награда
    public class Awards
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Поле обязательно")]
        public string AwardName { get; set; }
    }

    public class Regions
    {
        public int Id { get; set; }
        // [Required(ErrorMessage = "Поле обязательно")]
        public string RegName { get; set; } 

        public int AreassId { get; set; }
        public Areass Areass { get; set; }
    }

    public class Areass
    {
        public int Id { get; set; }
        // [Required(ErrorMessage = "Поле обязательно")]
        public string AreaName { get; set; }

        public List<Regions> Regions { get; set; }
    }

    public class Possitions
    {
        public int Id { get; set; }
        //  [Required(ErrorMessage = "Поле обязательно")]
        public string PossName { get; set; }
    }

    public class Educations
    {
        public int Id { get; set; }
        // [Required(ErrorMessage = "Поле обязательно")]
        public string EduName { get; set; }
    }

    public class Departaments
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        //[Required(ErrorMessage = "ФИО обязателен")]
        public string Person { get; set; }
        // [Required(ErrorMessage = "Телефон обязателен")]
        public string InitPhone { get; set; }
        //[Required(ErrorMessage = "Адресс почты обязателен")]
        public string InitEmail { get; set; }
        // [Required(ErrorMessage = "Адресс обязателен")]
        public string InitAddress { get; set; }
        //public DateTime CreateDate { get; set; }
    }

    public class SecondDeps
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Наименование обязательно")]
        public string DepName { get; set; }
        // [Required(ErrorMessage = "Название депортамента обязательно")]
        // public int DepId { get; set; }
        // [Required(ErrorMessage = "ФИО обязателен")]
        public string Person { get; set; }
        //[Required(ErrorMessage = "Телефон обязателен")]
        public string DepPhone { get; set; }
        // [Required(ErrorMessage = "Адресс почты обязателен")]
        public string DepEmail { get; set; }
        //[Required(ErrorMessage = "Адресс обязателен")]
        public string DepAddress { get; set; }
        // public DateTime CreateDate { get; set; }
    }

    public class Commissions
    {
        public int Id { get; set; }
        // [Required(ErrorMessage = "Поле обязательно")]
        // public int SecondDepId { get; set; }
        public string Person { get; set; }
    }


    public class Documents
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Поле обязательно")]
        public string DocName { get; set; }
    }
    

}
   