using blogpessoal.Model;
using FluentValidation;

namespace blogpessoal.Validator
{
    public class PostagemValidator : AbstractValidator<Postagem>
    {
        public PostagemValidator() {

            RuleFor(p => p.Titulo)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(1000);

            RuleFor(p => p.Texto)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(1000);
        }


    }
}
