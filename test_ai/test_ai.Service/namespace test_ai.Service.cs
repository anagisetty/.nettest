using System;
using System.Collections.Generic;
using System.Linq;
using test_ai.DataAccess;
using test_ai.DTO;

namespace test_ai.Service
{
    public class QuotationMemberNomineeService
    {
        private QuotationMemberNomineeRepository _quotationMemberNomineeRepository;

        public QuotationMemberNomineeService(QuotationMemberNomineeRepository quotationMemberNomineeRepository)
        {
            _quotationMemberNomineeRepository = quotationMemberNomineeRepository;
        }

        public List<GetQuotationMemberNominees> GetQuotationMemberNominees()
        {
            return _quotationMemberNomineeRepository.GetAll().ToList();
        }

        public GetQuotationMemberNominees GetQuotationMemberNomineeById(int id)
        {
            return _quotationMemberNomineeRepository.GetById(id);
        }

        public void AddQuotationMemberNominee(GetQuotationMemberNominees getQuotationMemberNominee)
        {
            _quotationMemberNomineeRepository.Add(getQuotationMemberNominee);
        }

        public void UpdateQuotationMemberNominee(GetQuotationMemberNominees getQuotationMemberNominee)
        {
            _quotationMemberNomineeRepository.Update(getQuotationMemberNominee);
        }

        public void DeleteQuotationMemberNominee(GetQuotationMemberNominees getQuotationMemberNominee)
        {
            _quotationMemberNomineeRepository.Delete(getQuotationMemberNominee);
        }
    }
}