﻿using Xunit;
using System.Threading.Tasks;
using TinyERP4Fun.ModelServises;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Linq;
using System.Threading;
using TinyERP4Fun.Interfaces;
using TinyERP4Fun.Models.Expenses;

namespace TinyERP4Fun.Tests.Services.ExpensesTests
{
    public class ExpencesServiceTests
    {
        public Mock<IDefaultContext> Mock { get; set; }
        public Mock<DbSet<Expences>> MockSet { get; set; }
        public Expences singleEntity = new Expences { Id = 2 };
        public Expences newEntity = new Expences { Id = 15 };
        public Expences anyEntity = It.IsAny<Expences>();
        public ExpencesService testedService;
        public readonly IQueryable<Expences> testEntities =
            new Expences[] {
                        new Expences {Id=0},
                        new Expences {Id=1},
                        new Expences {Id=2},
                        new Expences {Id=3},
                        new Expences {Id=4}
                        }.AsQueryable();
        public ExpencesServiceTests()
        {
            long Id = singleEntity.Id;
            Mock = DefaultContextMock.GetMock();
            MockSet = SetUpMock.SetUpFor(testEntities);
            Mock.Setup(c => c.Set<Expences>()).Returns(MockSet.Object);
            Mock.Setup(c => c.Expences).Returns(MockSet.Object);
            testedService = new ExpencesService(Mock.Object);
        }
        [Fact]
        public async Task GetAsync2_ReturnsRecordWithId2()
        {
            //Assert

            //Act
            var result = await testedService.GetAsync(2);

            //Assert
            Assert.Equal(testEntities.ToArray()[2], result);
        }
        [Fact]
        public async Task GetAsync5_ReturnsNull()
        {
            //Assert

            //Act
            var result = await testedService.GetAsync(5);

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
