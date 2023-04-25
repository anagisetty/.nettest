namespace test_ai
{
    public class QuotationMemberNomineeController
    {
        public int Id { get; set; }

        public void DeleteQuotationMemberNominee(int id)
        {
            using (var context = new TestAIContext())
            {
                QuotationMemberNominee quotationMemberNominee = context.QuotationMemberNominees.Find(id);
                context.QuotationMemberNominees.Remove(quotationMemberNominee);
                context.SaveChanges();
            }
        }
    }
}