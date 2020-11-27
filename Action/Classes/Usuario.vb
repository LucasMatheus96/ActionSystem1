Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports Action.Conexao
Imports Action.Controller
Imports Action.DAO

Namespace classes
    Public Class Usuario

#Region "Propriedades"


        Public Property Id As Integer
        Public Nome As String
        Public Usuario As String
        Public Senha As String
        Public DataCadastro As Date = Now
        Public Permissao As String
#End Region




#Region "Construtores"
#End Region
#Region "Métodos"



#End Region

    End Class
End Namespace

