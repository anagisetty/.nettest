using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using test_ai.DataAccess;
using test_ai.DTO;
using test_ai.Service;

namespace test_ai.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotationMemberNomineeController : ControllerBase
    {
        private QuotationMemberNomineeService _quotationMemberNomineeService;

        public QuotationMemberNomineeController(QuotationMemberNomineeService quotationMemberNomineeService)
        {
            _quotationMemberNomineeService = quotationMemberNomineeService;
        }
        
        // GET: api/QuotationMemberNominee
        [HttpGet]
        public IEnumerable<GetQuotationMemberNominees> GetQuotationMemberNominees()
        {
            return _quotationMemberNomineeService.GetQuotationMemberNominees();
        }

        // GET: api/QuotationMemberNominee/5
        [HttpGet("{id}")]
        public GetQuotationMemberNominees GetQuotationMemberNomineeById(int id)
        {
            return _quotationMemberNomineeService.GetQuotationMemberNomineeById(id);
        }

        // POST: api/QuotationMemberNominee
        [HttpPost]
        public void AddQuotationMemberNominee([FromBody] GetQuotationMemberNominees getQuotationMemberNominee)
        {
            _quotationMemberNomineeService.AddQuotationMemberNominee(getQuotationMemberNominee);
        }

        // PUT: api/QuotationMemberNominee/5
        [HttpPut("{id}")]
        public void UpdateQuotationMemberNominee(int id, [FromBody] GetQuotationMemberNominees getQuotationMemberNominee)
        {
            _quotationMemberNomineeService.UpdateQuotationMemberNominee(getQuotationMemberNominee);
        }
        
        // DELETE: api/QuotationMemberNominee/5
        [HttpDelete("{id}")]
        public void DeleteQuotationMemberNominee(int id, [FromBody] GetQuotationMemberNominees getQuotationMemberNominee)
        {
            _quotationMemberNomineeService.DeleteQuotationMemberNominee(getQuotationMemberNominee);
        }
    }
}