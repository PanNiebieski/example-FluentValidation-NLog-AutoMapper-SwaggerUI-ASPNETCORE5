using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddingStuffAndChecking
{
    public class MonsterHunter
    {
        public MonsterHunter()
        {

        }

        public string Title { get; set; }
        public int Strenght { get; set; }
        public int Magic { get; set; }
        public int Life { get; set; }

        public int Age { get; set; }
        public HeroType Type { get; set; }

        public IEnumerable<Monster> DefeatedMonsters { get; set; }
    }

    public class MonsterHunterValidator : AbstractValidator<MonsterHunter>
    {
        public MonsterHunterValidator()
        {
            RuleForEach(c => c.DefeatedMonsters).NotEmpty()
                .SetValidator(new MonsterValidator());

            RuleFor(c => c.Age).InclusiveBetween(0, 100);
            RuleFor(c => c.Title).MaximumLength(100)
                .NotNull();
            RuleFor(c => c.Type).IsInEnum();


            RuleFor(c => c.Strenght).GreaterThanOrEqualTo(1);
            RuleFor(c => c.Magic).GreaterThanOrEqualTo(1);
            RuleFor(c => c.Life).GreaterThanOrEqualTo(1);
        }
    }

    public enum HeroType
    {
        Warrior = 1,
        Mage = 2,
        Barbarian = 3,
        Thief = 4,
        Priest = 5
    }

    public class MonsterValidator : AbstractValidator<Monster>
    {
        public MonsterValidator()
        {
            RuleFor(c => c.Name).Length(3, 100)
                .NotNull().NotEmpty().NotEqual("-");
            RuleFor(c => c.Power).
                Must(BeAValidPower).
                WithMessage("Please specify a valid Power");

            RuleFor(c => c.FightType).IsInEnum();
        }

        private bool BeAValidPower(int power)
        {
            if (power < 0)
                return false;
            return true;
        }
    }


    public class Monster
    {


        public string Name { get; set; }
        public int Power { get; set; }
        public FightType FightType { get; set; }
    }

    public enum FightType
    {
        Magic = 1,
        Strenght = 2
    }


}
