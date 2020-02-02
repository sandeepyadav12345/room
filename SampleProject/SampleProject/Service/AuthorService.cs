using SampleProject.Iservice;
using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleProject.Service
{
    public class AuthorService : IAuthorService
    {
        public bool Delete(int authorId)
        {
            throw new NotImplementedException();
        }

        public AuthorModel GetAuthorById(int authorId)
        {
            throw new NotImplementedException();
        }

        public List<AuthorModel> ListAllData()
        {
            throw new NotImplementedException();
        }

        public bool Save(AuthorModel model)
        {
            throw new NotImplementedException();

            using (var _context = new OLMDBEntities())
            {
                try
                {
                    var data = new Author()
                {
                    AuthorID model.AuthorID,
                    AuthorName=model.AuthorID,
                    Description = model.Description
                };
                    _context.Authors.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }



            }

        }

        public bool Update(AuthorModel model)
        {
            throw new NotImplementedException();
        }
    }
}