Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports Action.Conexao
Imports Action.Controller
Imports Action.DAO

Namespace classes
    Public Class Usuario
        Dim Hash As New Criptografia(SHA512.Create())
#Region "Propriedades"


        Public Property Id As Integer
        Public Nome As String
        Public Usuario As String
        Public Senha As String
        Public DataCadastro As Date = Now
        Public Permissao As String
#End Region




#Region "Construtores"

        'Public Sub New(_Nome As String, _Usuario As String)

        '    If _Nome = "" Or _Usuario = "" Then
        '        Dim Exception As New ArgumentOutOfRangeException("Favor Verificar os dados digitados", _Nome)
        '    End If

        'End Sub

#End Region
#Region "Métodos"



#End Region

    End Class
End Namespace

