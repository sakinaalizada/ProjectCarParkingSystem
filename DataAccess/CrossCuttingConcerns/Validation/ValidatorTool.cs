using FluentValidation;
namespace DataAccess.CrossCuttingConcerns.Validation
{
    public static class ValidatorTool
    {
        public static void Validate<T>(T entity,IValidator validator)
        {
            var context = new ValidationContext<T>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
