Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports Action.Conexao
Imports Action.Controller
Imports Action.DAO

Namespace Classes
    Public Class Usuario

#Region "Propriedades"


        Public Property Id As Integer
        Public Property Nome As String
        Public Property Usuario As String
        Public Property Senha As String
        Public Property DataCadastro As Date = Now
        Public Property Permissao As String
#End Region

#Region "Construtores"
#End Region
#Region "Métodos"



#End Region

    End Class
End Namespace

