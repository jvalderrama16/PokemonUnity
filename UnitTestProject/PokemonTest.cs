﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class PokemonTest
    {
        #region HP/Status...
        [TestMethod]
        public void Pokemon_SetHP_To_Zero()
        {
            Pokemon pokemon = new Pokemon();
            //Assert.Equals(0, pokemon.HP);
            Assert.Fail();
        }

        [TestMethod]
        public void Pokemon_SetStatus_To_Faint() { Assert.Fail(); }

        [TestMethod]
        public void Pokemon_FullyHeal() { Assert.Fail(); }

        [TestMethod]
        public void Pokemon_MakeFainted() { Assert.Fail(); }

        [TestMethod]
        public void Pokemon_SetPokerus_To_Infected() { Assert.Fail(); }
        #endregion

        #region Level/stats...
        #endregion

        #region Moves...
        #endregion

        #region
        #endregion
    }
}