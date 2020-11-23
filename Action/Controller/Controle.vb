Imports Action.classes
Imports Action.Conexao
Imports Action.DAO

Namespace Controller
    Public Class Controle

        'CONTROLE REFERENTE A CLASSE RENDA FIXA

#Region "Classe Renda Fixa"
        Public Sub CadastrarRendaFixa(Titulo As RendaFixa)

            Try
                RendaFixaDAO.CadastrarRendaFixa(Titulo)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Public Sub AlterarRendaFixa(Titulo As RendaFixa)
            Try
                RendaFixaDAO.AlterarRendaFixa(Titulo)
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Function ConsultarTipoRendaFixa() As DataTable
            Try
                Return RendaFixaDAO.ConsultarTipoRendaFixa()

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Function ConsultarRendaFixa() As DataTable
            Try
                Return RendaFixaDAO.ConsultarRendaFixa
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Sub ExcluirRendaFixa(IdRendaFixa As Integer)
            Try
                RendaFixaDAO.ExcluirRendaFixa(IdRendaFixa)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub
#End Region


        'CONTROLE REFERENTE A CLASSE USUARIO
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

        'CONTROLE REFERENTE A CLASSE CARTEIRA
#Region "Classe Carteira"


        Public Function ConsultarCarteira() As DataTable

            Try

                Return CarteiraDAO.DbConsultarUsuario()
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try


        End Function

        Public Function CadastrarCarteira(carteira As Carteira) As String

            Try
                CarteiraDAO.DBCadastrarCarteira(carteira)
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try
            Return MsgBox("Cadastro Efetuado com sucesso.")
        End Function

        Public Function AtualizarCarteira(carteira As Carteira) As String
            Try
                CarteiraDAO.DBAtualizaCarteira(carteira)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return MsgBox("Carteira Alterada com Sucesso.")
        End Function

        Public Function ExcluirCarteira(IdCliente As Integer, Optional NomeCarteira As String = "") As String

            Try
                CarteiraDAO.DBExcluirCarteira(IdCliente, NomeCarteira)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return MsgBox("Carteira Excluida com sucesso.")
        End Function
#End Region

        'CONTROLE REFERENTE A CLASSE AÇÃO
#Region "Classe Ação"

        Public Sub CadastrarAcao(objAcao As Acao)

            Try
                AcaoDAO.CadastrarAcao(objAcao)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Sub AlterarAcao(objAcao As Acao)

            Try
                AcaoDAO.AlterarAcao(objAcao)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Function ConsultarAcao() As DataTable

            Try
                Return AcaoDAO.ConsultarAcao()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Sub ExcluirAcao(IdAcao As Integer)

            Try
                AcaoDAO.ExcluirAcao(IdAcao)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Function ConsultarTipoAcao() As DataTable
            Try
                Return AcaoDAO.ConsultarTipoAcao()

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Function

#End Region

        'CONTROLE REFERENTE A CLASSE FUNDO IMOBILIARIO
#Region "Classe Fundo imobiliario"

        Public Sub CadastrarFundoImobiliario(objFundoImobiliario As FundoImobiliario)
            Try
                Dim FundoImobiliarioDAO As New FundoImobiliarioDAO

                FundoImobiliarioDAO.CadastrarFundoImobiliario(objFundoImobiliario)
            Catch ex As Exception

                Throw ex
            End Try

        End Sub

        Public Sub AlterarFundoImobiliario(objFundoImobiliario As FundoImobiliario)

            Try
                FundoImobiliarioDAO.AlterarFundoImobiliario(objFundoImobiliario)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Function ConsultarFundoImobiliario() As DataTable

            Try
                Return FundoImobiliarioDAO.ConsultarFundoImobiliario()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Sub ExcluirFundoImobiliario(IdFundoImobiliario As Integer)

            Try
                FundoImobiliarioDAO.ExcluirFundoImobiliario(IdFundoImobiliario)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Function ConsultarTipoFundoImobiliario() As DataTable
            Try
                Return FundoImobiliarioDAO.ConsultarTipoFundoImobiliario()

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Function
#End Region
    End Class
End Namespace

