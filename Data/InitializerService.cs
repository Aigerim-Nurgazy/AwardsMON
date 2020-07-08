using System;
using System.Collections.Generic;
using System.Linq;
using BlzMON.Models;
namespace BlzMON.Data
{
    public class InitializerService
    {
        private readonly ApplicationDbContext _db;
        public InitializerService(ApplicationDbContext db)
        {
            _db = db;
        }
        //for CRUD operation
        //get all Employee
        public List<Initializers> GetInitializers()
        {
            // var empList = _db.Employees.ToList();
            var initList = _db.Initializers.ToList();
            return initList;


        }
        //insert Employee info
        public string Create(Initializers objInitializer)
        {
            _db.Initializers.Add(objInitializer);
            // _db.SaveChanges();
            _db.SaveChangesAsync();

            return "Save saccesfully";

        }
        //get Employee by ID
        public Initializers GetInitializerById(int id)
        {
            Initializers initializer = _db.Initializers.FirstOrDefault(s => s.Id == id);
            return initializer;

        }
        //Update employee info
        public string UpdateInitializer(Initializers objInitializer)
        {
            _db.Initializers.Update(objInitializer);
            // _db.SaveChanges();
            _db.SaveChangesAsync();
            return "Update succesfully";
        }
        // Delete Employee
        public string DeleteInitInfo(Initializers initializer)
        {
            _db.Remove(initializer);
            //_db.SaveChanges();
            _db.SaveChangesAsync();
            return "Delete succesfully";
        }

    }
}
