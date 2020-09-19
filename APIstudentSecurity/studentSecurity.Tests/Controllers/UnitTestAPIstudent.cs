using System;
using APIstudentSecurity.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace studentSecurity.Tests.Controllers
{
    [TestClass]
    public class UnitTestAPIstudent
    {
        [TestMethod]
        public void TestGetStudent()
        {
            //Arrange           objeto            instancia        clase
            StudentsController studentsController = new StudentsController(); //objeto
            //Act  nombredelista    objeto           Tabla de varios estudiantes
            var listaEstudiantes = studentsController.GetStudents();
            //Assert            nombredelista
            Assert.IsNotNull(listaEstudiantes);
        }
    }
}
