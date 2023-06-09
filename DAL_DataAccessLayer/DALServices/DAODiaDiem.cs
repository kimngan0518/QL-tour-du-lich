﻿using DAL_DataAccessLayer.DatabaseContext;
using DAL_DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DALServices
{
    public class DAODiaDiem
    {
        public ICollection<DiaDiem> GetAll()
        {
            using (QuanLiTourDbContext _context = new QuanLiTourDbContext())
            {
                return _context.DiaDiems
                    .Include("ThamQuans")
                    .ToList();
            }
        }
        public DiaDiem GetById(int Id)
        {
            using (QuanLiTourDbContext _context = new QuanLiTourDbContext())
            {
                return _context.DiaDiems.Find(Id);
            }
        }
        public void Create(DiaDiem diaDiem)
        {
            using(QuanLiTourDbContext context = new QuanLiTourDbContext())
            {
                context.DiaDiems.Add(diaDiem);
                context.SaveChanges();
            }
        }
    }
}
