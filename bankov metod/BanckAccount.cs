﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankov_metod
{
    internal class BanckAccount
    {
        private int id;
        private double balance;
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }   
        public void Deposit(double amount)
        {
            if(amount < 0)
            
                throw new ArgumentException("nepravilno vuvedena suma");
            
            this.balance += amount;

        }
        public void Withdraw(double amount)
        {
            if (amount > this.balance) throw new InvalidOperationException("");
                this.balance -= amount;
        }
        public override string ToString()
        {
            return $"Account{this.id}, balance: {this.balance}";
        }
        
       
        
          
        

    }
}

