using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newWord = new Item("word");
      Assert.AreEqual(typeof(Item), newWord.GetType());
    }
    [TestMethod]
    public void ItemConstructor_CreatesSortedArray_Array()
    {
      
      Assert.AreEqual(typeof(Item), main.MainWordArray(main));
    }
  }
}