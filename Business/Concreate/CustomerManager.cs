﻿using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class CustomerManager : ICustomerManager
    {
        private readonly ICustomerDal _customer;

        public CustomerManager(ICustomerDal customer)
        {
            _customer = customer;
        }

        [ValidationAspect(typeof(CustomerValidator))]

        public IResult Add(Customer customer)
        {
            _customer.Add(customer);
            return new SuccessResult("Müşteri başarılı bir şekilde eklendi"); 
        }

        public IResult Delete(int id)
        {
            _customer.Delete(id);
            return new SuccessResult("Müşteri başarılı bir şekilde silindi");
        }
        public IResult Update(Customer nesne)
        {
            _customer.Update(nesne);
            return new SuccessResult("Müşteri başarılı bir şekilde güncellendi.");
        }
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customer.GetAll());
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customer.GetById(id));
        }
    }
}
