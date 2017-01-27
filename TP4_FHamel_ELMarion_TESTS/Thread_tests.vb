Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP4_FHamel_ELMarion
Imports System.IO

<TestClass()> Public Class Thread_tests

    <TestMethod()> Public Sub CreationThread()
        Dim util1 As New Utilisateurs("Jean", "123")
        Dim Thread1 As New Thread("1", util1, "Titre1", "Tests")
        Assert.AreEqual(Thread1.Auteur, util1)
        Assert.AreEqual(Thread1.Message, "1")
        Assert.AreEqual(Thread1.Titre, "Titre1")
        Assert.AreEqual(Thread1.Categorie, "Tests")
        Assert.AreEqual(Thread1.EvalDown.Count, 0)
        Assert.AreEqual(Thread1.EvalUp.Count, 0)
    End Sub 

    <TestMethod()> Public Sub Exporter()
        Dim util1 As New Utilisateurs("Jean", "123")
        Dim util2 As New Utilisateurs("Jean2", "123")
        Dim util3 As New Utilisateurs("Jean3", "123")
        Dim Thread1 As New Thread("1", util1, "Titre1", "Tests")
        Thread1.Voter(util2, 1)
        Thread1.Voter(util3, -1)
        Dim sw As New StreamWriter("./export.txt")
        Thread1.Exporter(sw)
        sw.Close()
        Dim sr As New StreamReader("./export.txt")
        Dim txt As String
        txt = sr.ReadToEnd
        Assert.AreEqual(txt, "<thread>" & vbCrLf & "<auteur>Jean</auteur>" & vbCrLf & "<categorie>Tests</categorie>" & vbCrLf & "<titre>Titre1</titre>" & vbCrLf & "<message>1</message>" & vbCrLf & "<voteUp>Jean2|</voteUp>" & vbCrLf & "<voteDown>Jean3|</voteDown>" & vbCrLf & "</thread>" & vbCrLf)
    End Sub

End Class