﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Persistance.Context;

namespace UdemyCarBook.Persistance.Repositories;

public class Repsositroy<T> : IRepository<T> where T : class
{
    private readonly CarBookContext _context;

    public Repsositroy(CarBookContext context)
    {
        _context = context;
    }

    public async Task Create(T entity)
    {
        _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<List<T>> GetAllAsync()
    {
       return await _context.Set<T>().ToListAsync();

    }

    public async Task<T> GetAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task Update(T entity)
    {
         _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }
}
