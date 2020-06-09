using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalsBlz.Models
{
    public class ApplicationUser: IdentityUser
    {
        public int HospitalsId { get; set; }   // Код департамента
        public Hospitals Hospitals { get; set; }
    }

   
    public class Hospitals
    {
        public int Id { get; set; }
        public string Code { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public string Name { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public string Contacts { get; set; }
        public string Description { get; set; }
    }

    public class Departments
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Наименование обязательна")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Контактное лицо обязательна")]
        public string Contacts { get; set; }
        [Required(ErrorMessage = "Телефон обязательна")]
        public string Phone { get; set; }
        public int TotalPlaceQty { get; set; }
        public int PlaceCovidQty { get; set; }
        public int TotalPasients { get; set; }
        public int CovidQtyPasients { get; set; }
        public int TotalFreePlace { get; set; }
        public int TotalFreeCovidPlace { get; set; }
        public int HospitalsId { get; set; }
        public Hospitals Hospitals { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime CreateDate { get; set; }
    }
    public class DepartmentsHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contacts { get; set; }
        public string Phone { get; set; }
        public int TotalPlaceQty { get; set; }
        public int PlaceCovidQty { get; set; }
        public int TotalPasients { get; set; }
        public int CovidQtyPasients { get; set; }
        public int TotalFreePlace { get; set; }
        public int TotalFreeCovidPlace { get; set; }
        public int HospitalsId { get; set; }
        public Hospitals Hospitals { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int OldId { get; set; }
        public string Action { get; set; }
    }
    public class Positions
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public string Name { get; set; }
        public string Desc { get; set; }
    }

    public class Emp
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public string Name { get; set; }
        public int PositionsId { get; set; }
        public Positions Positions { get; set; }
        public int HospitalsId { get; set; }
        public Hospitals Hospitals { get; set; }
        public string Desc { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime CreateDate { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public string Name { get; set; }
        public string Desc { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public string Name { get; set; }
        public string Desc { get; set; }
        public int CategoryId { get; set; }
        public Category  Category { get; set; }
    }

    public class ProductCount
    {
        public int Id { get; set; }
        public int DepartmentsId { get; set; }
        public Departments Departments { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Qty { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
    public class ProductCountHistory
    {
        public int Id { get; set; }
        public int DepartmentsId { get; set; }
        public Departments Departments { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Qty { get; set; }
        public DateTime CreateDate { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int OldId { get; set; }
        public string Action { get; set; }
    }

}