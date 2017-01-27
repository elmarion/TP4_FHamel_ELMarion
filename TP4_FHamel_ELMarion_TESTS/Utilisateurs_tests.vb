Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP4_FHamel_ELMarion

<TestClass()> Public Class Utilisateurs_tests

    <TestMethod()> Public Sub CreationCompte()
        Dim nouveauCompte As New Utilisateurs("Jean", "123")
        Assert.AreEqual(nouveauCompte.Login, "Jean")
        Assert.AreEqual(nouveauCompte.Psw, "123")
        Assert.AreEqual(nouveauCompte.LstEcrits.Count, 0)
    End Sub
End Class