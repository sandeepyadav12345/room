using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Iservice
{
  public  interface IAuthorService
    {
        bool Save(AuthorModel model);
        bool Update(AuthorModel model);
        bool Delete(int authorId);
        List<AuthorModel> ListAllData();
        AuthorModel GetAuthorById(int authorId);

    }
}
