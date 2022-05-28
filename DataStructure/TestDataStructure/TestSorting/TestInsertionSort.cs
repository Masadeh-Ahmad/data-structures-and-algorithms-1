﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataStructure.DSA.InsertionSort;

namespace TestDataStructure
{
    public class TestInsertionSort
    {
        [Fact]
        public void NormalValuesTest()
        {
            int[] array = { 8, 4, 23, 42, 16, 15 };
            int[] result = { 4, 8, 15, 16, 23, 42 };
            InsertionSort.InsertionSortMethod(array); 
            Assert.Equal(array, result);
        }

        [Fact]
        public void DuplicatesTest()
        {
            int[] array = { 4, 4, 23, 42, 16, 15 };
            int[] result = { 4, 4, 15, 16, 23, 42 };
            InsertionSort.InsertionSortMethod(array);      
            Assert.Equal(array, result);
        }

        [Fact]
        public void PositiveNegativeValuesTest()
        {
            int[] array = { 8, -4, 23, 42, 16, 15 };
            int[] result = { -4, 8, 15, 16, 23, 42 };
            InsertionSort.InsertionSortMethod(array);
            Assert.Equal(array, result);
        }

        [Fact]
        public void NegativeValuesTest()
        {
            int[] array = { -8, -4, -23, -42, -16, -15 };
            int[] result = { -42, -23, -16, -15, -8, -4 };
            InsertionSort.InsertionSortMethod(array);
            Assert.Equal(array, result);
        }
    }
}
