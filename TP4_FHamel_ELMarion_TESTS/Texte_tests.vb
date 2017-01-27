Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP4_FHamel_ELMarion
Imports System.IO

<TestClass()> Public Class Texte_tests

    <TestMethod()> Public Sub CreerTexte()
        Dim util1 As New Utilisateurs("Jean", "123")
        Dim commentaire1 As New Texte("1", util1)
        Assert.AreEqual(commentaire1.Auteur, util1)
        Assert.AreEqual(commentaire1.EvalDown.Count, 0)
        Assert.AreEqual(commentaire1.EvalUp.Count, 0)
        Assert.AreEqual(commentaire1.Message, "1")
    End Sub

        <TestMethod()> Public Sub Voter()
        Dim util1 As New Utilisateurs("Jean", "123")
        Dim util2 As New Utilisateurs("Robert", "123")
        Dim commentaire1 As New Texte("1", util1)
        commentaire1.Voter(util2, 1)
        Assert.AreEqual(commentaire1.EvalUp.Count, 1)
        Assert.AreEqual(commentaire1.EvalUp(0), util2)
        Assert.AreEqual(commentaire1.EvalDown.Count, 0)
        Try
            commentaire1.Voter(util2, 1)
        Catch ex As Exception
            Assert.AreEqual(ex.Message, "Vous avez déjà voté pour ce texte !")
        End Try

        Try
            commentaire1.Voter(util1, 1)
        Catch ex As Exception
            Assert.AreEqual(ex.Message, "Vous ne pouvez pas voter pour vos propres textes !")
        End Try

        Dim util3 As New Utilisateurs("Dereck", "aqw")
        commentaire1.Voter(util3, -1)
        Assert.AreEqual(commentaire1.EvalUp.Count, 1)
        Assert.AreEqual(commentaire1.EvalDown.Count, 1)
    End Sub

    <TestMethod()> Public Sub Exporter()
        Dim util1 As New Utilisateurs("Jean", "123")
        Dim util2 As New Utilisateurs("Jean2", "123")
        Dim util3 As New Utilisateurs("Jean3", "123")
        Dim commentaire1 As New Texte("1", util1)
        commentaire1.Voter(util2, 1)
        commentaire1.Voter(util3, -1)
        Dim sw As New StreamWriter("./export2.txt")
        commentaire1.Exporter(sw)
        sw.Close()
        Dim sr As New StreamReader("./export2.txt")
        Dim txt As String
        txt = sr.ReadToEnd
        Assert.AreEqual(txt, "<commentaire>" & vbCrLf & "<auteur>Jean</auteur>" & vbCrLf & "<message>1</message>" & vbCrLf & "<voteUp>Jean2|</voteUp>" & vbCrLf & "<voteDown>Jean3|</voteDown>" & vbCrLf & "</commentaire>" & vbCrLf)
        sr.Close()
    End Sub

End Class