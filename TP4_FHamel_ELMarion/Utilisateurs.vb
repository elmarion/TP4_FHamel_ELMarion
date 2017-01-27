<Serializable>
Public Class Utilisateurs
    Private _login As String
    Private _psw As String
    Private _lstEcrits As List(Of Texte)

#Region "get/set"
    Public Property LstEcrits() As List(Of Texte)
        Get
            Return _lstEcrits
        End Get
        Set(ByVal value As List(Of Texte))
            _lstEcrits = value
        End Set
    End Property
    Public Property Psw() As String
        Get
            Return _psw
        End Get
        Set(ByVal value As String)
            _psw = value
        End Set
    End Property
    Public Property Login() As String
        Get
            Return _login
        End Get
        Set(ByVal value As String)
            _login = value
        End Set
    End Property
#End Region

    Public Sub New(pLogin As String, pPsw As String)
        Login = pLogin
        Psw = pPsw
        _lstEcrits = New List(Of Texte)
    End Sub

    Public Overrides Function ToString() As String
        Return Login
    End Function
End Class
