Imports Action.DAO
Imports Action.classes

Namespace Controller
    Public Class ControladorUsuario
#Region "Classe Usuario"
        'CONTROLE REFERENTE A CLASSE USUARIO 
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

            ElseIf vSenha = "" Then

                MsgBox("Preencha o campo senha")

                vRetorno = False


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

