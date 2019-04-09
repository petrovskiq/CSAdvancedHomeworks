using MyLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Entities
{
    public abstract class Fighter
    {
        private double streetcredit;

        public Fighter(double health, double powerPunch, double speed)
        {
            Health = health;
            PowerPunch = powerPunch;
            Speed = speed;
        }

        public Fighter(double health, double powerPunch, double speed, double streetcredit) : this(health, powerPunch, speed)
        {
            this.streetcredit = streetcredit;
        }

        private double Health { get; set; }
        protected virtual double PowerPunch { get; set; }
        protected virtual double Speed { get; set; }

        public virtual void TakeDamage(double damage)
        {
            Health -= damage;
        }

        public virtual void TakeDamage()
        {
            Health = 0;
        }

        public virtual bool IsDizzy()
        {
            if (Health < 10)
            {
                return true;
            }
            return false;
        }

        protected abstract void Finisher(Fighter opponent);
    }

    public class StreetFighter : Fighter,IStreet
    {
        public StreetFighter(double health, double powerPunch, double speed, double streetcredit):base(health, powerPunch, speed, streetcredit)
        {
            StreetCredit = streetcredit;
        }
        public double StreetCredit { get; set; }

        public void DoStreet(Fighter opponent)
        {
            Console.WriteLine("Do Street");
        }

        protected override void Finisher(Fighter opponent)
        {
            Console.WriteLine("Finisher");
        }

        public override void TakeDamage(double damage)
        {
            Health -= damage;
        }
    }

    public class ProFighter : Fighter, IStreet, IBox
    {
        public ProFighter(double health, double powerPunch, double speed,double experience) : base(health, powerPunch, speed, experience)
        {
            Experience = experience;
        }
       
        public double Experience { get; set; }

        public void DoBoxing(Fighter opponent)
        {
            if (opponent.PowerPunch > PowerPunch)
            {
                Console.WriteLine($"{oppone}");
            }
        }

        public void DoStreet(Fighter opponent)
        {
            throw new NotImplementedException();
        }

        protected override void Finisher(Fighter opponent)
        {
            throw new NotImplementedException();
        }

        public override void TakeDamage(double damage)
        {
            Health -= damage;
        }
    }

    public class RockStarFighter : Fighter,IStreet,IBox,IMuayThai
    {
        public RockStarFighter(double health, double powerPunch, double speed, double reputation) : base(health, powerPunch, speed, reputation)
        {
            Reputation = reputation;
        }
       
        public double Reputation { get; set; }

        public void DoBoxing(Fighter opponent)
        {
            throw new NotImplementedException();
        }
    
        public void DoMuayThai(Fighter opponent)
        {
            throw new NotImplementedException();
        }

        public void DoStreet(Fighter opponent)
        {
            throw new NotImplementedException();
        }

        protected override void Finisher(Fighter opponent)
        {
            throw new NotImplementedException();
        }

        public override void TakeDamage(double damage)
        {
            Health -= damage;
        }
    }


}
