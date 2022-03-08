﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFContentDal : GenericRepository<Content>, IContentDal
    {
        public List<Content> WriterContent(int id)
        {
            using (var x = new Context())
            {
                return x.Contents.Where(n => n.WriterID == id).ToList();
            }
        }
    }
}
