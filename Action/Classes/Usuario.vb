Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports Action.Conexao
Imports Action.Dao

Namespace classes
    Public Class Usuario
        Dim Hash As New Criptografia(SHA512.Create())
#Region "Propriedades"

        Public Id As Integer
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
                UsuarioDAO.DbCadastroUsuario(Usuario)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try


        End Sub

        Public Sub AtualizarUsuario(ByVal Usuario As Usuario)

            Try
                UsuarioDAO.DbAtualizaCadastro(Usuario)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try


        End Sub

        Public Sub ExcluirUsuario(ByVal IdCliente As Integer)

            Try
                UsuarioDAO.DbExcluirCadastro(IdCliente)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try



        End Sub


        Public Function ConsultarUsuario() As DataTable

            Try
                Return UsuarioDAO.DbConsultarUsuario
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try



        End Function

        Public Function ValidarAcesso(vLogin As String, vSenhaTentativa As String) As DataTable

            Try
                Return UsuarioDAO.DbValidaAcesso(vLogin, vSenhaTentativa)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try


        End Function

        Public Function ChecarCampos(Optional ByVal vlogin As String = "", Optional vSenha As String = "", Optional ByVal vUsuario As String = "", Optional ByVal vConfirmaSenha As String = "") As Boolean
            Dim vRetorno As Boolean


            If vlogin = "" And vSenha = "" And vUsuario = "" And vConfirmaSenha = "" Then
                MsgBox("Preencha todos os campos para se logar")
                vRetorno = False


            ElseIf vlogin = "" And vSenha = "" Then
                MsgBox("Preencha todos os campos para se logar")
                vRetorno = False


                'ElseIf vUsuario = "" Then

                '    MsgBox("Preencha as informações do campo usuario")


            ElseIf vSenha = "" Then

                MsgBox("Preencha o campo senha")

                vRetorno = False

                'ElseIf vConfirmaSenha = "" Then
                '    MsgBox("Confirme sua senha")

            ElseIf vlogin = "" Then


                MsgBox("Preencha as informações do campo login")
                vRetorno = False

            Else
                vRetorno = True
            End If
            Return vRetorno
        End Function


#End Region

    End Class
End Namespace

