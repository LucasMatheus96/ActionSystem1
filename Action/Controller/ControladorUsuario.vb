Imports Action.DAO
Imports Action.classes
Imports System.Security.Cryptography

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

        Public Function ConsultarUsuarioLogado(objUsuarioLogado As Usuario) As DataTable

            Try
                Return UsuarioDAO.DbConsultarUsuarioLogado(objUsuarioLogado)
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


            If String.IsNullOrEmpty(vlogin) And String.IsNullOrEmpty(vSenha) And String.IsNullOrEmpty(vUsuario) And String.IsNullOrEmpty(vConfirmaSenha) Then
                MessageBox.Show("Preencha todos os campos para se logar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                vRetorno = False


            ElseIf String.IsNullOrEmpty(vlogin) And String.IsNullOrEmpty(vSenha) Then
                MessageBox.Show("Preencha todos os campos para se logar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                vRetorno = False

            ElseIf String.IsNullOrEmpty(vSenha) Then

                MessageBox.Show("Preencha o campo senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)

                vRetorno = False


            ElseIf String.IsNullOrEmpty(vlogin) Then

                MessageBox.Show("Preencha  as informações o campo login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)

                vRetorno = False

            ElseIf vSenha.Length < 6 Then
                MessageBox.Show("Digite uma senha com mias de 6 caracteres")
                vRetorno = False
            Else
                vRetorno = True
            End If
            Return vRetorno
        End Function


#End Region

    End Class
End Namespace

