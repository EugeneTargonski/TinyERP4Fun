﻿using Xunit;
using System.Threading.Tasks;
using TinyERP4Fun.ModelServises;
using TinyERP4Fun.Models.Common;
using TinyERP4Fun.Data;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Linq;

using System.Threading;
using TinyERP4Fun.Interfaces;

namespace TinyERP4Fun.Tests.Services.CommonTests
{
    public class CurrencyRatesServiceTests
    {
        public Mock<IDefaultContext> Mock { get; set; }
        public Mock<DbSet<CurrencyRates>> MockSet { get; set; }
        public CurrencyRates singleEntity = new CurrencyRates { Id = 2 };
        public CurrencyRates newEntity = new CurrencyRates { Id = 15 };
        public CurrencyRates anyEntity = It.IsAny<CurrencyRates>();
        public CurrencyRatesService testedService;
        public readonly IQueryable<CurrencyRates> testEntities =
            new CurrencyRates[] {
                        new CurrencyRates {Id=0},
                        new CurrencyRates {Id=1},
                        new CurrencyRates {Id=2},
                        new CurrencyRates {Id=3},
                        new CurrencyRates {Id=4}
                        }.AsQueryable();
        public CurrencyRatesServiceTests()
        {
            long Id = singleEntity.Id;
            Mock = DefaultContextMock.GetMock();
            MockSet = SetUpMock.SetUpFor(testEntities);
            Mock.Setup(c => c.Set<CurrencyRates>()).Returns(MockSet.Object);
            Mock.Setup(c => c.CurrencyRates).Returns(MockSet.Object);
            testedService = new CurrencyRatesService(Mock.Object);
        }
        [Fact]
        public async Task GetAsync2_ReturnsRecordWithId2()
        {
            //Assert

            //Act
            var result = await testedService.GetAsync(2, false);

            //Assert
            Assert.Equal(testEntities.ToArray()[2], result);
        }
        [Fact]
        public async Task GetAsync5_ReturnsNull()
        {
            //Assert

            //Act
            var result = await testedService.GetAsync(5, false);

            //Assert
            Assert.Null(result);
        }
        [Fact]
        public async Task GetAsync2Tracking_ReturnsRecordWithId2()
        {
            //Assert

            //Act
            var result = await testedService.GetAsync(2, true);
            //Assert
            Assert.Equal(testEntities.ToArray()[2], result);
        }
        [Fact]
        public async Task GetAsync5Tracking_ReturnsNull()
        {
            //Assert

            //Act
            var result = await testedService.GetAsync(5, true);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetIQueryable_ReturnsRightValues()
        {
            //Assert

            //Act
            var result = testedService.GetIQueryable();

            //Assert
            Assert.Equal(testEntities.ToList(), result.ToList());
        }
        [Fact]
        public async Task GetListAsync_ReturnsRightValues()
        {
            //Assert

            //Act
            var result = await testedService.GetListAsync();

            //Assert
            Assert.Equal(testEntities.ToList(), result);
        }
        [Fact]
        public async Task AddAsync_AddsEntity()
        {
            //Assert

            //Act
            await testedService.AddAsync(newEntity);

            //Assert
            Mock.Verify(c => c.Add(newEntity), Times.Once());
            Mock.Verify(c => c.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once());
        }
        [Fact]
        public async Task DeleteAsync_RemovesEntity()
        {
            //Assert

            //Act
            await testedService.DeleteAsync(singleEntity.Id);

            //Assert
            Mock.Verify(c => c.Remove(anyEntity), Times.Once());
            Mock.Verify(c => c.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once());
        }
        [Fact]
        public async Task UpdateAsync_UpdatesEntity()
        {
            //Assert

            //Act
            await testedService.UpdateAsync(singleEntity);

            //Assert
            Mock.Verify(c => c.Update(singleEntity), Times.Once());
            Mock.Verify(c => c.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once());
        }
    }
}
