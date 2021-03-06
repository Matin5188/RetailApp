﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RetailApp.Models;
using RetailApp.BAL.Models;

namespace RetailApp.Tests
{
    [TestClass]
    public class DiscountUnitTest
    {
        [TestMethod]
        public void Employee_Gets_30_Discount_Non_Groceries()
        {
            // Arrange
            Employee emp = new Employee();
            Product prod = new Product();         
            prod.BillAmount = 60;
            prod.Category = ProductCategory.NonGrocery;

            emp.Product = prod;

            // Act
            var netPayable = emp.GetDiscount(emp);

            // Assert
            Assert.AreEqual(42, netPayable);
        }

        [TestMethod]
        public void Employee_Gets_5_Discount_every_100_On_Groceries()
        {
            // Arrange
            Employee emp = new Employee();
            Product prod = new Product();
            prod.BillAmount = 990;
            prod.Category = ProductCategory.Grocery;

            emp.Product = prod;

            // Act
            var netPayable = emp.GetDiscount(emp);

            // Assert
            Assert.AreEqual(945, netPayable);
        }

        [TestMethod]
        public void Affiliate_Gets_10_Discount_Non_Groceries()
        {
            // Arrange
            Affiliate aff = new Affiliate();            

            Product prod = new Product();
            prod.BillAmount = 60;
            prod.Category = ProductCategory.NonGrocery;

            aff.Product = prod;

            // Act
            var netPayable = aff.GetDiscount(aff);

            // Assert
            Assert.AreEqual(54, netPayable);
        }

        [TestMethod]
        public void Affiliate_Gets_5_Discount_every_100_On_Groceries()
        {
            // Arrange
            Affiliate aff = new Affiliate();            

            Product prod = new Product();
            prod.BillAmount = 310;
            prod.Category = ProductCategory.Grocery;

            aff.Product = prod;

            // Act
            var netPayable = aff.GetDiscount(aff);

            // Assert
            Assert.AreEqual(295, netPayable);
        }

        [TestMethod]
        public void Customer_Over_2_Years_Gets_5_Discount_Non_Groceries()
        {
            // Arrange
            Customer cust = new Customer();            
            cust.CustomerSinceYear = 3;

            Product prod = new Product();
            prod.BillAmount = 60; // expected 5% discount which is 3 and net payable = 57
            prod.Category = ProductCategory.NonGrocery;

            cust.Product = prod;

            // Act
            var netPayable = cust.GetDiscount(cust);

            // Assert
            Assert.AreEqual(57, netPayable);
        }

        [TestMethod]
        public void Customer_Less_Than_2_Years_Gets_0_Discount_Non_Groceries()
        {
            // Arrange
            Customer cust = new Customer();            
            cust.CustomerSinceYear = 1;

            Product prod = new Product();
            prod.BillAmount = 60;
            prod.Category = ProductCategory.NonGrocery;
            cust.Product = prod;

            // Act
            var netPayable = cust.GetDiscount(cust);

            // Assert
            Assert.AreEqual(60, netPayable);
        }

        [TestMethod]
        public void Customer_Gets_5_Discount_every_100_On_Groceries()
        {
            // Arrange
            Customer cust = new Customer ();            

            Product prod = new Product();
            prod.BillAmount = 310;
            prod.Category = ProductCategory.Grocery;
            cust.Product = prod;

            // Act
            var result = cust.GetDiscount(cust);

            // Assert
            Assert.AreEqual(295, result);
        }
    }
}
