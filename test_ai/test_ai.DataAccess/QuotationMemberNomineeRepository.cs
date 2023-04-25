using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using test_ai.DTO;

namespace test_ai
{
    public class QuotationMemberNomineeRepository
    {
        private readonly DbContext _context;

        public QuotationMemberNomineeRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<GetQuotationMemberNominees> GetAll()
        {
            return _context.Set<GetQuotationMemberNominees>().ToList();
        }

        public GetQuotationMemberNominees GetById(int id)
        {
            return _context.Set<GetQuotationMemberNominees>().Find(id);
        }

        public IEnumerable<GetQuotationMemberNominees> Find(Expression<Func<GetQuotationMemberNominees, bool>> predicate)
        {
            return _context.Set<GetQuotationMemberNominees>().Where(predicate);
        }

        public void Add(GetQuotationMemberNominees entity)
        {
            _context.Set<GetQuotationMemberNominees>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(GetQuotationMemberNominees entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(GetQuotationMemberNominees entity)
        {
            _context.Set<GetQuotationMemberNominees>().Remove(entity);
            _context.SaveChanges();
        }
    }
}