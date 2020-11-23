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

        Public Sub CadastrarUsuario(ByVal Usuario As Usuario)

            Try
                Dim Controle As New Controle
                Controle.CadastrarUsuario(Usuario)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try


        End Sub

        Public Sub AtualizarUsuario(ByVal Usuario As Usuario)

            Try
                Dim Controle As New Controle
                Controle.AtualizarUsuario(Usuario)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try


        End Sub

        Public Sub ExcluirUsuario(ByVal IdCliente As Integer)

            Try
                Dim Controle As New Controle
                Controle.ExcluirUsuario(IdCliente)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try



        End Sub


        Public Function ConsultarUsuario() As DataTable

            Try
                Dim Controle As New Controle

                Return Controle.ConsultarUsuario
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try



        End Function

        Public Function ValidarAcesso(vLogin As String, vSenhaTentativa As String) As DataTable

            Try
                Dim Controle As New Controle
                Return Controle.ValidarAcesso(vLogin, vSenhaTentativa)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try


        End Function

        Public Function ChecarCampos(Optional ByVal vlogin As String = "", Optional vSenha As String = "", Optional ByVal vUsuario As String = "", Optional ByVal vConfirmaSenha As String = "") As Boolean
            Try
                Dim Controle As New Controle

                Return Controle.ChecarCampos(vlogin, vSenha, vUsuario, vConfirmaSenha)

            Catch ex As Exception
                Throw ex
            End Try

        End Function


#End Region

    End Class
End Namespace

